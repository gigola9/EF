using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WarehouseEntities1 model = new WarehouseEntities1();
            User us = new User()
            {
                Name = textBox1.Text,
                LastName = textBox2.Text,
                Nickname = textBox3.Text,
                Password = textBox4.Text,
                WarehouseId = 1,
                RoleId = 1
            };
            model.Users.Add(us);
            model.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
