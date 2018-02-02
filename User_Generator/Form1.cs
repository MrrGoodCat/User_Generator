using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Generator
{
    public partial class Form1 : Form
    {
        DataGenerator dataGenerator;
        public Form1()
        {
            InitializeComponent();
            dataGenerator = new DataGenerator();
        }

        private void GenerateDataBtn_Click(object sender, EventArgs e)
        {
            int numberOfUsers = Convert.ToInt32(textBoxNumberOfUsers.Text);
            int numberOfGroups = Convert.ToInt32(textBoxGroupsCount.Text);
            dataGenerator.GenerateUsers(numberOfUsers);
            dataGenerator.GenerateGroups(numberOfGroups);
            dataGenerator.GenerateUserGroupDependency();
            dataGenerator.Serialise(@"C:\", dataGenerator.Users,dataGenerator.Agents, dataGenerator.Dependencies, dataGenerator.Groups);
        }
    }
}
