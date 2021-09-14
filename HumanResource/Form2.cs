using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dlist.Items.Clear();
            dlist.Items.Add("Add Employee");
            dlist.Items.Add("Update details");
            dlist.Items.Add("Delete Enteries");
            dlist.Items.Add("Display");
            dlist.Items.Add("Reports");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess ac = new DataAccess();
            string action = dlist.SelectedItem.ToString();
            switch (action)
            {
                case "Add Employee":
                    //MessageBox.Show("You have selected to add");
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                    break;
                case "Update details":
                    MessageBox.Show("You have selected to update");
                    break;
                case "Delete Enteries":
                   // MessageBox.Show("You have selected to delete");
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
                    break;
                case "Display":
                    //MessageBox.Show("You have selected to display");
                    Form7 f7 = new Form7();
                    f7.ShowDialog();
                    break;
                case "Reports":
                    MessageBox.Show("You chose reports");
                    break;
            }
        }
    }
}
