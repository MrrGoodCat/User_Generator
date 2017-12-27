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
            dataGenerator.GenerateUsers(5);
            dataGenerator.Serialise(@"C:\", dataGenerator.Users);
        }
    }
}
