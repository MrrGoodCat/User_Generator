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
                string firstName = data.GetRandomName();
                string lastName = data.GetRandomSurname();
                string login = firstName + lastName;
                User user = new User(firstName, lastName, true, login, "nicecti1!");
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
                cs.Serialize(stream, users, "Users");
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
