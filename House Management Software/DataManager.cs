using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;


namespace House_Management_Software
{
    public class DataManager
    {
        private int[] apartmentNumbers = {101, 202, 303};
        private Dictionary<int, int> ApartmentNumbersAndCodes = new Dictionary<int, int>()
        {
            {101, 111},
            {202, 222},
            {303, 333}
        };
        SqlDatabase sqlDatabase;
        public DataManager()
        {
            sqlDatabase = new SqlDatabase(this);
        }

        public List<User> GetUsers()
        {
            return sqlDatabase.InsertAllUsersFromSqlToVS();
        }
        public string SignUpPageDataManager(string InputedFirstName, string InputedLastName, string InputedEmail, string InputedPhoneNumber, string InputerApartmentNumberString, string InputedApartmentCodeString, string InputedPassword, string InputedPasswordConfirmation,string status)
        {
            if (!string.IsNullOrEmpty(InputedFirstName))
            {
                if (!string.IsNullOrEmpty(InputedLastName))
                {
                    if (!string.IsNullOrEmpty(InputedEmail))
                    {
                        foreach (User user in sqlDatabase.InsertAllUsersFromSqlToVS())
                        {
                            if (user.Email == InputedEmail)
                            {
                                return "Email is already used";
                            }
                        }
                        if (!InputedEmail.Contains('@'))
                        {
                            return "Invalid Email Adress";
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(InputedPhoneNumber))
                            {
                                if (!string.IsNullOrEmpty(InputerApartmentNumberString))
                                {
                                    if (int.TryParse(InputerApartmentNumberString, out int InputedApartmentNumber))
                                    {
                                        if (!apartmentNumbers.Contains(InputedApartmentNumber))
                                        {
                                            return "No such apartment number";
                                        }
                                        else
                                        {
                                            if (!string.IsNullOrEmpty(InputedApartmentCodeString))
                                            {
                                                if (int.TryParse(InputedApartmentCodeString, out int InputedApartmentCode))
                                                {
                                                    if (ApartmentNumbersAndCodes[InputedApartmentNumber] != InputedApartmentCode)
                                                    {
                                                        return "The apartment code is not corresponding to the apartment number";
                                                    }
                                                    else
                                                    {
                                                        if (!string.IsNullOrEmpty(InputedPassword))
                                                        {
                                                            string output = PasswordChecker(InputedPassword);
                                                            if(!output.Equals("add"))
                                                            { 
                                                                return output;
                                                            }
                                                            else if (output.Equals("add"))
                                                            {
                                                                if (!string.IsNullOrEmpty(InputedPasswordConfirmation))
                                                                {
                                                                    if (InputedPassword != InputedPasswordConfirmation)
                                                                    {
                                                                        return "Passwords do not match";
                                                                    }
                                                                    else if (InputedPassword == InputedPasswordConfirmation)
                                                                    {
                                                                        User newUser = new User(sqlDatabase.GetTheHighestId()+1,InputedFirstName, InputedLastName, status);
                                                                        newUser.ApartmentCode = InputedApartmentCode;
                                                                        newUser.ApartmentNumber = InputedApartmentNumber;
                                                                        newUser.PhoneNumber = InputedPhoneNumber;
                                                                        newUser.Email = InputedEmail;
                                                                        newUser.Password = InputedPasswordConfirmation;
                                                                        sqlDatabase.InsertNewUserFromVSToSql(newUser);
                                                                        return "add";
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    return "Please confirm the password";
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            return "Please input a password";
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    return "Please input a valit apartment code";
                                                }
                                            }
                                            else
                                            {
                                                return "Please input an apartment code";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        return "Please input a valid type of apartment number";
                                    }
                                }
                                else
                                {
                                    return "Please input an apartment number";
                                }
                            }
                            else
                            {
                                return "Please input a Phone number";
                            }
                        }
                    }
                    else
                    {
                        return "Please input a email adress";
                    }
                }
                else
                {
                    return "Please input a Last name";
                }
            }
            else
            {
                return "Please input a First name";
            }
            return null;
        }
        public string PasswordChecker(string InputedPassword)
        {
            int errorNum = 0;
            if (InputedPassword.Length <= 7)
            {
                errorNum = 1;
            }
            else if (InputedPassword.Where(char.IsUpper).Count() <= 0)
            {
                errorNum = 2;
            }
            else if (InputedPassword.Where(char.IsLower).Count() <= 2)
            {
                errorNum = 3;
            }
            else if (InputedPassword.Where(char.IsNumber).Count() <= 1)
            {
                errorNum = 4;
            }
            else if (InputedPassword.Where(char.IsSymbol).Count() <= 0)
            {
                errorNum = 5;
            }
            else
            {
                return "add";
            }

            switch (errorNum)
            {
                case 1:
                    return "The minimum lenght of the password must be 8 digits";
                case 2:
                    return "The password must contain at least one capital letter";

                case 3:
                    return "The password must contain at least three lower case letter";

                case 4:
                    return "The password must contain at least one number digit";

                case 5:
                    return "The password must contain at least one symbol";
            }
            return null;
        }

        public void ApplyChangedToProfileCredentials(User user, string newEmail, string newPhoneNumber, string newPassword)
        {
            sqlDatabase.ApplyChangesToProfileCredentials(user, newEmail, newPhoneNumber, newPassword);
        }
        
        public User GetUser(string InfoForAdmin)
        {
            User user = sqlDatabase.InsertAllUsersFromSqlToVS().FirstOrDefault(user => user.GetInfoForAdmin.Equals(InfoForAdmin));
            return user;
        }

        public User GetUserById(int id)
        {
            sqlDatabase.InsertAllUsersFromSqlToVS();
            User user = sqlDatabase.InsertAllUsersFromSqlToVS().FirstOrDefault(user => user.Id.Equals(id));
            return user;
        }

        public string DeteleUser(string InfoForAdmin,User loggedInUser)
        {
            User user = sqlDatabase.InsertAllUsersFromSqlToVS().FirstOrDefault(user => user.GetInfoForAdmin.Equals(InfoForAdmin));
            if (loggedInUser.Email.Equals(user.Email))
            {
                return $"{loggedInUser.FirstName}, you can not delete yourself";
            }
            else if(user.Status.Equals("admin"))
            {
                return $"{loggedInUser.FirstName}, you can not delete admins";
            }
            else
            {
                sqlDatabase.DeleteUserFromTheGarbage(user);
                sqlDatabase.DeleteATasksThatAreConnectedToADeleteUser(user);
                sqlDatabase.DeleteUserByAdmin(user);
                return $"{user.FirstName} has been sucessfully deleted";
            }
        }
    }
}
