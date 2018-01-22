﻿using System;
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

        public void GenerateUsers(int count)
        {
            while (count != 0)
            {
                string name = data.GetRandomName();
                string surName = data.GetRandomSurname();
                User user = new User(name, surName, true, name + surName, "nice");
                Users.Add(user);
                count--;
            }
        }

        public void Serialise(string pathToFile, List<User> users)
        {
            using (var stream = new FileStream("ImpUsers.csv", FileMode.Create, FileAccess.Write))
            {
                var cs = new CsvSerializer<User>()
                {
                    UseTextQualifier = true,
                };
                cs.Serialize(stream, users);
            }
        }
    }
}
