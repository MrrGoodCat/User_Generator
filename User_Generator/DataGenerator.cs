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

        //CsvSerializer<User> serializer;
        Data data = new Data();
        public List<User> Users = new List<User>();
        public List<Agent> Agents = new List<Agent>();
        public List<Group> Groups = new List<Group>();
        private Object thisLock = new Object();

        public void GenerateUsers(int count)
        {
            int UserId = 10;
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
            int groupId = 100;
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

        public void Serialise(string pathToFile, List<User> users, List<Agent> agents, List<Group> groups)
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
                var csg = new CsvSerializer<Group>()
                {
                    UseTextQualifier = true,
                };
                csg.Serialize(stream, groups, "Groups");
            }
        }

        //public void MarkSerializer(string filePath, string mark)
        //{
        //    //before your loop
        //    var csv = new StringBuilder();
        //    var newLine = string.Format("#{0}", mark);
        //    csv.AppendLine(newLine);

        //    //after your loop
        //    File.WriteAllText(filePath, csv.ToString());
        //}
    }
}
