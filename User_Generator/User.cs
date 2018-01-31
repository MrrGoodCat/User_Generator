using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using Csv.Serialization;

namespace User_Generator
{
    public class User
    {
        string userName;
        string userSurname;
        static bool userStatus = true;
        string login;
        string passw = "";
        string hireDate = DateTime.UtcNow.ToString("G",
                        CultureInfo.CreateSpecificCulture("en-us"));
        string graduationDate = DateTime.UtcNow.ToString("G",
                        CultureInfo.CreateSpecificCulture("en-us"));
        int graduationScore = 0;
        int internalUserId = 2;
        string userState = (UserStatus == true ? "active" : "inactive");

        public string first_name
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string last_name
        {
            get
            {
                return userSurname;
            }

            set
            {
                userSurname = value;
            }
        }

        [CsvIgnore]
        static public bool UserStatus
        {
            get
            {
                return userStatus;
            }

            set
            {
                userStatus = value;
            }
        }

        public string os_login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string password
        {
            get
            {
                return passw;
            }

            set
            {
                passw = value;
            }
        }

        public string hire_date
        {
            get
            {
                return hireDate;
            }

            set
            {
                hireDate = value;
            }
        }

        public string graduation_date
        {
            get
            {
                return graduationDate;
            }

            set
            {
                graduationDate = value;
            }
        }

        public int graduation_score
        {
            get
            {
                return graduationScore;
            }

            set
            {
                graduationScore = value;
            }
        }

        public int internal_user_id
        {
            get
            {
                return internalUserId;
            }

            set
            {
                internalUserId = value;
            }
        }

        public string status
        {
            get
            {
                return userState;
            }

            set
            {
                userState = value;
            }
        }

        public User()
        {

        }

        public User(string name, string surname, bool status)
        {
            userName = name;
            userSurname = surname;
            userStatus = status; 
        }

        public User(string name, string surname, bool status, string login, string password)
        {
            userName = name;
            userSurname = surname;
            userStatus = status;
            this.login = login;
            passw = password;
        }
    }

}
