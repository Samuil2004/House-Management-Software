using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using System.Data;

namespace House_Management_Software
{
    internal class SqlDatabase
    {

        private SqlConnection sqlConn;
        DataManager dataManager;
        public SqlDatabase(DataManager dataManager)
        {
            this.dataManager = dataManager;
            sqlConn = new SqlConnection("Server = IWillNotTellYouMyServer; Database=StudentHousehold; User Id = dbi527531_housesoft; Password=IWillNotTellYouMyPassword; TrustServerCertificate=True");
        }
        public SqlDatabase()
        {
            this.dataManager = new DataManager();
            sqlConn = new SqlConnection("Server = IWillNotTellYouMyServer; Database=StudentHousehold; User Id = dbi527531_housesoft; Password=IWillNotTellYouMyPassword; TrustServerCertificate=True");
        }

        public List<User> InsertAllUsersFromSqlToVS()
        {
            List<User> allUsers = new List<User>();
            try
            {
                sqlConn.Open();
                string query = $"SELECT * from AllUsers order by apartmentNumber ASC";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string firstName = reader["firstName"].ToString();
                    string lastName = reader["lastName"].ToString();
                    string email = reader["email"].ToString();
                    string phoneNumber = reader["phoneNumber"].ToString();
                    int apartmentNumber = Convert.ToInt32(reader["apartmentNumber"]);
                    int apartmentCode = Convert.ToInt32(reader["apartmentCode"]);
                    string userPassword = reader["userPassword"].ToString();
                    string userStatus = reader["userStatus"].ToString();
                    int id = Convert.ToInt32(reader["id"]);
                    User newUser = new User(id, firstName, lastName, userStatus);
                    newUser.Email = email;
                    newUser.PhoneNumber = phoneNumber;
                    newUser.ApartmentNumber = apartmentNumber;
                    newUser.ApartmentCode = apartmentCode;
                    newUser.Password = userPassword;
                    allUsers.Add(newUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return allUsers;
        }

        public void InsertNewUserFromVSToSql(User user)
        {
            try
            {
                sqlConn.Open();
                string query = $"INSERT INTO AllUsers (firstName,lastName,email,phoneNumber,apartmentNumber,apartmentCode,userPassword,userStatus) VALUES (@firstName,@lastName,@email,@PhoneNumber,@ApartmentNumber,@ApartmentCode,@Password,@Status)";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                cmd.Parameters.AddWithValue("@lastName", user.LastName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                cmd.Parameters.AddWithValue("@ApartmentNumber", user.ApartmentNumber);
                cmd.Parameters.AddWithValue("@ApartmentCode", user.ApartmentCode);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Status", user.Status);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public void ApplyChangesToProfileCredentials(User user, string newEmail, string newPhoneNumber, string newPassowrd)
        {
            try
            {
                sqlConn.Open();
                string query = $"UPDATE Allusers SET email = @newEmail, phoneNumber = @newPhoneNumber, userPassword = @newPassowrd WHERE email = @Email;";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@newEmail", newEmail);
                cmd.Parameters.AddWithValue("@newPhoneNumber", newPhoneNumber);
                cmd.Parameters.AddWithValue("@newPassowrd", newPassowrd);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public int GetTheHighestId()
        {
            int id = 0;
            try
            {
                sqlConn.Open();
                string query = $"SELECT MAX(id) as MaxId FROM AllUsers;";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["MaxId"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return id;
        }
        public void DeleteUserByAdmin(User user)
        {
            try
            {
                sqlConn.Open();
                string query = $"DELETE from AllUsers Where id = @id ";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@id", user.Id);
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public void DeleteATasksThatAreConnectedToADeleteUser(User user)
        {
            try
            {
                sqlConn.Open();
                string query = $"DELETE from AllTasks " +
                $" WHERE assignedTo = @assignedTo;";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@assignedTo", user.Id);
                int effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public void DeleteUserFromTheGarbage(User user)
        {
            GarbageManager.DeleteUserFromGarbage(user);
        }

        public List<Task> AllTasksSql(User user)
        {
            ChangeExpiredTasksSql();
            List<Task> tasks = new List<Task>();
            try
            {
                sqlConn.Open();
                string query = $"SELECT * from AllTasks " +
                    $"Where expiredTask = 0 " +
                    $"AND studentApartmentNo = @studentApartmentNo " +
                    $"AND dateTime < @dateTime;";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@studentApartmentNo", user.ApartmentNumber);
                cmd.Parameters.AddWithValue("@dateTime", DateTime.Today.AddDays(6));
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string category = reader["taskCategory"].ToString();
                    string taskDescription = reader["taskDescription"].ToString();
                    DateTime DateTime = Convert.ToDateTime(reader["dateTime"]);
                    bool status = Convert.ToBoolean(reader["status"]);
                    int AssignedTo = Convert.ToInt32(reader["assignedTo"]);
                    int studentRoomNumber = Convert.ToInt32(reader["studentApartmentNo"]);
                    taskCategories enum_category = (taskCategories)Enum.Parse(typeof(taskCategories), category);
                    Task task = new Task(id,enum_category, taskDescription, DateTime, status, dataManager.GetUserById(AssignedTo), studentRoomNumber);
                    tasks.Add(task);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return tasks;
        }
       

        public void InsertNewTaskToSql(Task task)
        {
            try
            {
                sqlConn.Open();
                string query = $"INSERT INTO AllTasks (id,taskCategory, taskDescription, dateTime, status, assignedTo, studentApartmentNo, expiredTask) VALUES (@id,@taskCategory,@taskDescription,@dateTime,@status,@assignedTo, @studentApartmentNo, @expiredTask)";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@id", task.GetId);
                cmd.Parameters.AddWithValue("@taskCategory", Convert.ToString(task.GetCategory));
                cmd.Parameters.AddWithValue("@taskDescription", task.TaskDescription);
                cmd.Parameters.AddWithValue("@dateTime", task.GetDate);
                cmd.Parameters.AddWithValue("@status", task.GetStatus);
                cmd.Parameters.AddWithValue("@assignedTo", task.GetUser.Id);
                cmd.Parameters.AddWithValue("@studentApartmentNo", task.StudentRoomNumber);
                cmd.Parameters.AddWithValue("@expiredTask", false);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public  void ChangeStatusTaskSql(Task selectedTask)
        {
            try
            {
                sqlConn.Open();

                string query = $"UPDATE AllTasks SET status = @status WHERE id = @id;";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@id", selectedTask.GetId);
                cmd.Parameters.AddWithValue("@status", true);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public void ChangeExpiredTasksSql()
        {
            try
            {
                sqlConn.Open();
                string query = $"UPDATE AllTasks " +
                $"SET expiredTask = @expiredTask WHERE dateTime < @CurrentDate;";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@expiredTask", true);

                int effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public int GetTheHighestIdForTask()
        {
            int id = 0;
            try
            {
                sqlConn.Open();
                string query = $"SELECT MAX(id) AS MaxId FROM AllTasks";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["MaxId"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return id;
        }

        public void DeleteATask(Task selectedTask)
        {
            try
            {
                sqlConn.Open();
                string query = $"DELETE from AllTasks " +
                $" WHERE id = @id;";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@id", selectedTask.GetId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public List<Task> AllTasksAdminSql()
        {
            ChangeExpiredTasksSql();
            List<Task> tasks = new List<Task>();
            try
            {
                sqlConn.Open();
                string query = $"SELECT * from AllTasks " +
                $"Where expiredTask = 1 " +
                $"AND status = 0 ";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string category = reader["taskCategory"].ToString();
                    string taskDescription = reader["taskDescription"].ToString();
                    DateTime DateTime = Convert.ToDateTime(reader["dateTime"]);
                    bool status = Convert.ToBoolean(reader["status"]);
                    int AssignedTo = Convert.ToInt32(reader["assignedTo"]);
                    int studentRoomNumber = Convert.ToInt32(reader["studentApartmentNo"]);
                    taskCategories enum_category = (taskCategories)Enum.Parse(typeof(taskCategories), category);
                    Task task = new Task(id,enum_category, taskDescription, DateTime, status, dataManager.GetUserById(AssignedTo), studentRoomNumber);
                    tasks.Add(task);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            List<Task> sortedTasks = tasks.OrderBy(task => task.StudentRoomNumber).ToList();
            return sortedTasks;
        }

        public void InsertProductToSQLGroceryList(Product product)
        {
            try
            {
                sqlConn.Open();
                string query = $"INSERT INTO GroceryList (id,name, amount, description, status, apartmentNumber) VALUES (@id,@name,@amount,@description,@status,@apartmentNumber)";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@id", product.GetId);
                cmd.Parameters.AddWithValue("@name", product.GetName);
                cmd.Parameters.AddWithValue("@amount", product.GetAmount);
                cmd.Parameters.AddWithValue("@description", product.Description);
                if (product.GetStatus)
                {
                    cmd.Parameters.AddWithValue("@status", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@status", 0);
                }
                cmd.Parameters.AddWithValue("@apartmentNumber", product.ApartmentNumber);
                int effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public List<Product> GroceryListFromSQL(User user)
        {
            List<Product> products = new List<Product>();
            bool status = false;
            try
            {
                sqlConn.Open();
                string query = $"SELECT * from GroceryList " +
                $"Where status = 0 " +
                $"And apartmentNumber = @apartmentNumber ";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@apartmentNumber", user.ApartmentNumber);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string name = reader["name"].ToString();
                    int amount = Convert.ToInt32(reader["amount"]);
                    string description = reader["description"].ToString();
                    if (Convert.ToInt32(reader["status"]) == 1)
                    {
                        status = true;
                    }
                    int apartmentNumber = Convert.ToInt32(reader["apartmentNumber"]);
                    Product newProduct = new Product(id, name, amount, status, apartmentNumber);
                    newProduct.Description = description;
                    products.Add(newProduct);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return products;
        }

        public void ChangeStatusProductSql(Product product)
        {
            try
            {
                sqlConn.Open();
                string query = $"UPDATE GroceryList SET status = @status WHERE id = @id;";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@status", true);
                cmd.Parameters.AddWithValue("@id", product.GetId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }
        
        public int GetTheHighestIdForProduct()
        {
            int id = 0;
            try
            {
                sqlConn.Open();
                string query = $"SELECT MAX(id) AS MaxId FROM GroceryList";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["MaxId"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return id;
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                sqlConn.Open();
                string query = $"DELETE from GroceryList WHERE id = @id;";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@id", product.GetId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }


        public int GetTheHighestIdForEvent()
        {
            int id = 0;
            try
            {
                sqlConn.Open();
                string query = $"SELECT MAX(id) AS MaxId FROM Events";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["MaxId"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return id;
        }

        public void InsertEventIntoSQL(Event newEvent)
        {
            try
            {
                sqlConn.Open();
                string query = $"INSERT INTO Events (title, description, dateTime, student, apartmentNumber,id) VALUES (@title,@description,@dateTime,@student,@apartmentNumber,@id)";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@title", newEvent.GetTitle);
                cmd.Parameters.AddWithValue("@description", newEvent.GetDescription);
                cmd.Parameters.AddWithValue("@dateTime", newEvent.GetDateTime);
                cmd.Parameters.AddWithValue("@student", newEvent.GetStudent.Email);
                cmd.Parameters.AddWithValue("@apartmentNumber", newEvent.GetStudent.ApartmentNumber);
                cmd.Parameters.AddWithValue("@id", newEvent.GetId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public List<Event> AllEventsFromSQL(User user)
        {
            List<Event> events = new List<Event>();
            bool status = false;
            try
            {
                sqlConn.Open();
                string query = $"SELECT * from Events " +
                $"Where dateTime >= GETDATE()" +
                $"And apartmentNumber = @apartmentNumber ORDER BY dateTime ASC";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@apartmentNumber", user.ApartmentNumber);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    DateTime dateTime = Convert.ToDateTime(reader["dateTime"]);
                    string email = reader["student"].ToString();
                    User newUser = dataManager.GetUsers().FirstOrDefault(user => user.Email.Equals(email));
                    int apartmentNumber = Convert.ToInt32(reader["apartmentNumber"]);
                    int id = Convert.ToInt32(reader["id"]);
                    Event newEvent = new Event(id, title, description, dateTime, newUser);
                    events.Add(newEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return events;
        }

        public void CancelEvent(Event selectedEvent)
        {
            try
            {
                sqlConn.Open();
                string query = $"DELETE from Events WHERE id = @id;";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@id", selectedEvent.GetId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public List<Event> AllEventsFromSQLForAdmin()
        {
            List<Event> events = new List<Event>();
            bool status = false;
            try
            {
                sqlConn.Open();
                string query = $"SELECT * from Events " +
                $"Where dateTime >= GETDATE() " +
                $"ORDER BY dateTime ASC";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    DateTime dateTime = Convert.ToDateTime(reader["dateTime"]);
                    string email = reader["student"].ToString();
                    User newUser = dataManager.GetUsers().FirstOrDefault(user => user.Email.Equals(email));
                    int apartmentNumber = Convert.ToInt32(reader["apartmentNumber"]);
                    int id = Convert.ToInt32(reader["id"]);
                    Event newEvent = new Event(id, title, description, dateTime, newUser);
                    events.Add(newEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return events;
        }
    }
}
