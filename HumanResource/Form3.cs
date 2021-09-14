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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Depts.Items.Clear();
            Depts.Items.Add("DEV");
            Depts.Items.Add("HR");
            Depts.Items.Add("Marketing");
            Depts.Items.Add("Sales");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess ac = new DataAccess();
            string dname = Depts.SelectedItem.ToString();
            ac.Add(Name1.Text, dname, double.Parse(salary.Text), grade.Text, Manager.Text, company.Text, Start.Value, End.Value,
                double.Parse(Bonus.Text), BDate.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
