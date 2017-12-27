using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Generator
{
    public class User
    {
        string userName;
        string userSurname;
        bool userStatus;
        string login;
        string password = "nicecti1!";

        public string UserName
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

        public string UserSurname
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

        public bool UserStatus
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

        public string Login
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

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
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
            this.password = password;
        }
    }

}
