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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WarehouseEntities1 model = new WarehouseEntities1();
            List<User> users = model.Users.ToList();
            dataGridView1.DataSource = users;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var user_Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            WarehouseEntities1 model = new WarehouseEntities1();
            var selectedUser = model.Users.Where(i => i.Id == user_Id).FirstOrDefault();
            model.Users.Remove(selectedUser);
            model.SaveChanges();
        }
    }
}
