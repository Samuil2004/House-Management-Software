using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace House_Management_Software
{
    public class GarbageManager
    {
        DataManager dataManager;
        private string fileName;
        private List<Garbage> garbages;
        private User currentUser;
        private List<User> users;

        public GarbageManager(User loggenInUser)
        {
            this.dataManager = new DataManager();
            this.currentUser = loggenInUser;
            this.garbages = new List<Garbage>();
            fileName = "Garbage.dat";
            this.users = dataManager.GetUsers();
            SortUsers();
        }
        
        public void SortUsers()
        {
            users = this.users.Where(user => user.ApartmentNumber.Equals(currentUser.ApartmentNumber)).ToList();
        }
        private List<Garbage> GiveExpiredGarbages()
        {
            List<Garbage> garbagesExpired = this.garbages.Where(garbage => garbage.Date.CompareTo(DateTime.Today) < 0
            && (garbage.User.ApartmentNumber.Equals(currentUser.ApartmentNumber))).ToList();
            return garbagesExpired;
        }
        public User UserForTrash()
        {

            List<Garbage> garbagesForCurrentApartment = GarbagesForCurrentApartment();

            List<User> avaibleUsers = users.Where(user => !garbagesForCurrentApartment.Any(g => g.User.Equals(user)))
            .ToList();
            Random random = new Random();
            int num;
            if (avaibleUsers.Count > 0)
            {
                num = random.Next(0, avaibleUsers.Count);

                return avaibleUsers[num];
            }
            else
            {
                num = random.Next(0, users.Count);
                return users[num];
            }

        }
        public void InsertIntoFile()
        {
            try
            {

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (Garbage garbage in garbages)
                    {
                        writer.WriteLine(garbage.User.Id);
                        writer.WriteLine(garbage.Date);
                        writer.WriteLine(garbage.Category);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving garbage disposal data: {ex.Message}");
            }
        }

        public void ExtractFromFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        int userId = Convert.ToInt32(reader.ReadLine());
                        DateTime date = Convert.ToDateTime(reader.ReadLine());
                        string category = Convert.ToString(reader.ReadLine());
                        Garbage garbage = new Garbage(dataManager.GetUserById(userId), category, date);
                        garbages.Add(garbage);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading garbage disposal data: {ex.Message}");
            }
            finally
            {
                List<Garbage> garbagesExpired = GiveExpiredGarbages();
                if (garbagesExpired.Count > 0)
                {
                    ChangeDate();
                }
            }
        }
        public List<Garbage> GarbagesForCurrentApartment()
        {
            List<Garbage> garbagesForCurrentApartment = garbages.Where
            (garbage => garbage.User.ApartmentNumber.Equals(currentUser.ApartmentNumber)).ToList();
            return garbagesForCurrentApartment;
        }
        public void ChangeDate()
        {
            List<Garbage> expired = GiveExpiredGarbages();

            foreach (Garbage garbage in expired)
            {
                garbage.Date = garbage.Date.AddDays(21);
                garbage.User = UserForTrash();
            }
        }
        public string ChangeDateLabel(string category)
        {
            List<Garbage> garbagesForCurrentApartment = GarbagesForCurrentApartment();

            return garbagesForCurrentApartment.FirstOrDefault(garbage => garbage.Category == category)?.Date.ToString("yyyy MM dd");
        }
        public string ChangeTextLabel(string category)
        {
            List<Garbage> garbagesForCurrentApartment = GarbagesForCurrentApartment();

            return garbagesForCurrentApartment.FirstOrDefault(garbage => garbage.Category == category)?.User?.GetFirstandLastName;
        }
        public static void DeleteUserFromGarbage(User user)
        {
            List<Garbage> garbages = ExtractFromFileDeleteUser();
            foreach (Garbage garbage in garbages)
            {
                if (garbage.User.Id == user.Id)
                {
                    garbage.User = UserForTrashDeleteUser(garbage.User.ApartmentNumber);
                }
            }
            InsertIntoFileDeleteUser(garbages);
        }
        public static User UserForTrashDeleteUser(int apartNumber)
        {

            List<Garbage> garbagesForCurrentApartment = ExtractFromFileDeleteUser().Where
            (garbage => garbage.User.ApartmentNumber.Equals(apartNumber)).ToList();
            DataManager dataManager = new DataManager();
            List<User> users = dataManager.GetUsers().Where(user => user.ApartmentNumber.Equals(apartNumber)).ToList();
            List<User> avaibleUsers = users.Where(user => !garbagesForCurrentApartment.Any(g => g.User.Id.Equals(user.Id)))
            .ToList();
            Random random = new Random();
            int num;
            if (avaibleUsers.Count > 0)
            {
                num = random.Next(0, avaibleUsers.Count);

                return avaibleUsers[num];
            }
            else
            {
                num = random.Next(0, users.Count);
                return users[num];
            }

        }
        public static List<Garbage> ExtractFromFileDeleteUser()
        {
            DataManager dataManager = new DataManager();
            List<Garbage> garbages = new List<Garbage>();
            try
            {
                using (StreamReader reader = new StreamReader("Garbage.dat"))
                {
                    while (!reader.EndOfStream)
                    {
                        int userId = Convert.ToInt32(reader.ReadLine());
                        DateTime date = Convert.ToDateTime(reader.ReadLine());
                        string category = Convert.ToString(reader.ReadLine());
                        Garbage garbage = new Garbage(dataManager.GetUserById(userId), category, date);
                        garbages.Add(garbage);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading garbage disposal data: {ex.Message}");
            }
            return garbages;
        }
        public static void InsertIntoFileDeleteUser(List<Garbage> garbages)
        {
            try
            {

                using (StreamWriter writer = new StreamWriter("Garbage.dat"))
                {
                    foreach (Garbage garbage in garbages)
                    {
                        writer.WriteLine(garbage.User.Id);
                        writer.WriteLine(garbage.Date);
                        writer.WriteLine(garbage.Category);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving garbage disposal data: {ex.Message}");
            }
        }
    }
}
