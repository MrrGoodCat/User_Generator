using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Generator
{
    public class Agent
    {
        string _user_id = "1";
        string _switch = "2";
        int _agent_id = 1;
        int _extension = 1;
        string _email = "e";
        string _alias = "a";

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

        public int agent_id
        {
            get
            {
                return _agent_id;
            }

            set
            {
                _agent_id = value;
            }
        }

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

        public string email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

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

        public Agent()
        {

        }
    }
}
