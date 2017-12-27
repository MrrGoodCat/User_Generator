﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace User_Generator.Database
{
    public class Data
    {
        List<string> names;
        List<string> surnames;

        Random random;
        string namesFilePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Database\\Names.txt");
        string surnamesFilePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Database\\Surnames.txt");

        public List<string> Names
        {
            get
            {
                return names;
            }

            set
            {
                names = value;
            }
        }

        public List<string> Surnames
        {
            get
            {
                return surnames;
            }

            set
            {
                surnames = value;
            }
        }

        public Data()
        {
            random = new Random(DateTime.Now.Millisecond);
            Names = new List<string>();
            Surnames = new List<string>();
            fillTheList(namesFilePath, this.Names);
            fillTheList(surnamesFilePath, this.Surnames);
        }

        void fillTheList(string filePath, List<string> names)
        {
            string line = null;
            StreamReader streamReader = new StreamReader(filePath);
            while ((line = streamReader.ReadLine()) != null)
            {
                names.Add(line);
            }
        }

        public string GetRandomName()
        {
            string name = Names[random.Next(0, 2000)];
            return name;
        }

        public string GetRandomSurname()
        {
            string surname = Surnames[random.Next(0, 1000)];
            return surname;
        }
    }
}
