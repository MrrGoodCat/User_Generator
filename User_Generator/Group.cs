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
        string _groupId = "NiceGroupId_";
        int _parentId;
        User groupManager;
        List<User> users;

        public string name
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

        [CsvDependency]
        public string id
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

        public int parent_id
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

        public Group()
        {

        }

        public Group(int groupId, string groupName, int parentId)
        {
            _groupId += groupId;
            _groupName = groupName;
            _parentId = parentId;
            users = new List<User>();
        }
    }
}
