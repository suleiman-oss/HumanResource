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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess ac = new DataAccess();
            if (!ac.IsEmpValid(int.Parse(eid.Text)))
                MessageBox.Show("Employee Doesn't Exist");
            else
                ac.AddBonus(int.Parse(eid.Text), double.Parse(Bonus.Text), BDate.Value);
        }
    }
}
