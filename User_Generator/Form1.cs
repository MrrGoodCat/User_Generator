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
            dataGenerator.GenerateUsers(numberOfUsers);
            //dataGenerator.MarkSerializer(@"C:\", "Users");
            dataGenerator.Serialise(@"C:\", dataGenerator.Users);
        }
    }
}
