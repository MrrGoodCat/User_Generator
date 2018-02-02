using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Generator.Database;
using Csv.Serialization;
using System.IO;

namespace User_Generator
{
    public class DataGenerator
    {
        Data data = new Data();
        public List<User> Users = new List<User>();
        public List<Agent> Agents = new List<Agent>();
        public List<Group> Groups = new List<Group>();
        public List<UserGroupDependency> Dependencies = new List<UserGroupDependency>();

        public void GenerateUsers(int count)
        {
            int UserId = 40;
            while (count != 0)
            {
                string firstName = data.GetRandomName();
                string lastName = data.GetRandomSurname();
                string login = firstName + lastName;
                User user = new User(UserId, firstName, lastName, true, login, "nicecti1!");
                Users.Add(user);
                count--;
                UserId++;
            }
        }

        public void GenerateGroups(int count)
        {
            int groupId = 105;
            int parentId = -1;
            while (count != 0)
            {
                string groupName = data.GetRandomGroupName();
                Group group = new Group(groupId, groupName, parentId);
                Groups.Add(group);
                count--;
                groupId++;
            }

        }

        public void GenerateUserGroupDependency()
        {
            
            Random random = new Random();
            foreach (var group in Groups)
            {
                int NumberOfUsersInGroup = random.Next(0, Users.Count/Groups.Count*4);
                for (int i = 0; i < NumberOfUsersInGroup; i++)
                {
                    User user;
                    do
                    {
                        user = Users[(random.Next(0, Users.Count))];
                    } while (user.IsManager || user.UsersGroups.Contains(group));

                    if (user.UsersGroups.Count == 0 && group.GroupManager == null)
                    {
                        group.GroupManager = user;
                        user.IsManager = true;
                    }
                    group.Users.Add(user);
                    user.UsersGroups.Add(group);
                }
            }

            foreach (var user in Users)
            {
                if (user.UsersGroups.Count != 0)
                {
                    foreach (var group in user.UsersGroups)
                    {
                        UserGroupDependency ugd = new UserGroupDependency(user.user_id, group.id, user.IsManager);
                        Dependencies.Add(ugd);
                    }
                }
            }
        }

        public void Serialise(string pathToFile, List<User> users, List<Agent> agents, List<UserGroupDependency> dependencies, List<Group> groups)
        {
            using (var stream = new FileStream("ImpUsers.csv", FileMode.Create, FileAccess.Write))
            {
                var csu = new CsvSerializer<User>()
                {
                    UseTextQualifier = true,
                };
                csu.Serialize(stream, users, "#Users");              
            }

            using (var stream = new FileStream("ImpUsers.csv", FileMode.Append, FileAccess.Write))
            {
                var csg = new CsvSerializer<Agent>()
                {
                    UseTextQualifier = true,
                };
                csg.Serialize(stream, agents, "Additional Agent Identities");
            }

            using (var stream = new FileStream("ImpUsers.csv", FileMode.Append, FileAccess.Write))
            {
                var csg = new CsvSerializer<UserGroupDependency>()
                {
                    UseTextQualifier = true,
                };
                csg.Serialize(stream, dependencies, "User Groups");
            }

            using (var stream = new FileStream("ImpUsers.csv", FileMode.Append, FileAccess.Write))
            {
                var csg = new CsvSerializer<Group>()
                {
                    UseTextQualifier = true,
                };
                csg.Serialize(stream, groups, "Groups");
            }
        }
    }
}
