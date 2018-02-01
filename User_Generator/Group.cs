using Csv.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Generator
{
    public class Group
    {
        string _groupName;
        int _groupId;
        int _parentId;
        User groupManager;
        List<User> users;

        public string GroupName
        {
            get
            {
                return _groupName;
            }

            set
            {
                _groupName = value;
            }
        }

        public int GroupId
        {
            get
            {
                return _groupId;
            }

            set
            {
                _groupId = value;
            }
        }

        public int ParentId
        {
            get
            {
                return _parentId;
            }

            set
            {
                _parentId = value;
            }
        }
        [CsvIgnore]
        public User GroupManager
        {
            get
            {
                return groupManager;
            }

            set
            {
                groupManager = value;
            }
        }
        [CsvIgnore]
        public List<User> Users
        {
            get
            {
                return users;
            }

            set
            {
                users = value;
            }
        }
    }
}
