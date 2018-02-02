using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Generator
{
    public class UserGroupDependency
    {
        string _user_id;
        string _group_id;
        int _is_manager;

        public string user_id
        {
            get
            {
                return _user_id;
            }

            set
            {
                _user_id = value;
            }
        }

        public string group_id
        {
            get
            {
                return _group_id;
            }

            set
            {
                _group_id = value;
            }
        }

        public int is_manager
        {
            get
            {
                return _is_manager;
            }

            set
            {
                _is_manager = value;
            }
        }

        public UserGroupDependency()
        {

        }

        public UserGroupDependency(string userId, string groupId, bool isManager)
        {
            _user_id = userId;
            _group_id = groupId;
            _is_manager = (isManager == true ? 1 : 0);
        }
    }
}
