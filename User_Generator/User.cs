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
        string _userId = "NiceUserId_";
        string firstName;
        string middleName;
        string lastName;
        string userName;
        static bool userStatus = true;
        string passw = "nicecti1!";
        string login;
        string _department;
        string _location;
        string _site = "Master Site";
        string _jobClass;
        string _jobSkill;
        string _jobFunction;
        string _emailAddress;
        string hireDate = DateTime.UtcNow.ToString("G",
                        CultureInfo.CreateSpecificCulture("en-us"));
        string graduationDate = DateTime.UtcNow.ToString("G",
                        CultureInfo.CreateSpecificCulture("en-us"));
        int graduationScore = 0;
        int internalUserId = 2;
        string userState = (UserStatus == true ? "active" : "inactive");
        string _domain;
        string _agentIdentification;
        string _switch;
        int _agentId;
        int _extension;
        string _alias;
        string _userRtiAgent = "Disabled";


        public string user_id
        {
            get
            {
                return _userId;
            }

            set
            {
                _userId = value;
            }
        }

        public string first_name
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        [CsvIgnore]
        public string middle_name
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }

        public string last_name
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
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
        [CsvIgnore]
        public string department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }
        [CsvIgnore]
        public string location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }

        public string site
        {
            get
            {
                return _site;
            }

            set
            {
                _site = value;
            }
        }
        [CsvIgnore]
        public string job_class
        {
            get
            {
                return _jobClass;
            }

            set
            {
                _jobClass = value;
            }
        }
        [CsvIgnore]
        public string job_skill
        {
            get
            {
                return _jobSkill;
            }

            set
            {
                _jobSkill = value;
            }
        }
        [CsvIgnore]
        public string job_function
        {
            get
            {
                return _jobFunction;
            }

            set
            {
                _jobFunction = value;
            }
        }
        [CsvIgnore]
        public string email_address
        {
            get
            {
                return _emailAddress;
            }

            set
            {
                _emailAddress = value;
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
        [CsvIgnore]
        public string domain
        {
            get
            {
                return _domain;
            }

            set
            {
                _domain = value;
            }
        }
        [CsvIgnore]
        public string agent_identification
        {
            get
            {
                return _agentIdentification;
            }

            set
            {
                _agentIdentification = value;
            }
        }
        [CsvIgnore]
        public string Switch
        {
            get
            {
                return _switch;
            }

            set
            {
                _switch = value;
            }
        }
        [CsvIgnore]
        public int agent_id
        {
            get
            {
                return _agentId;
            }

            set
            {
                _agentId = value;
            }
        }
        [CsvIgnore]
        public int extension
        {
            get
            {
                return _extension;
            }

            set
            {
                _extension = value;
            }
        }
        [CsvIgnore]
        public string alias
        {
            get
            {
                return _alias;
            }

            set
            {
                _alias = value;
            }
        }

        public string user_rti_agent
        {
            get
            {
                return _userRtiAgent;
            }

            set
            {
                _userRtiAgent = value;
            }
        }

        public User()
        {

        }

        public User(int user_id, string name, string surname, bool status)
        {
            _userId += user_id;
            firstName = name;
            lastName = surname;
            userStatus = status;
            internalUserId = user_id;
        }

        public User(int user_id, string name, string surname, bool status, string login, string password)
        {
            _userId += user_id;
            firstName = name;
            lastName = surname;
            userStatus = status;
            this.login = login;
            passw = password;
            internalUserId = user_id;
        }
    }

}
