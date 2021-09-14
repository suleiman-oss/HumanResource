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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess ac = new DataAccess();
            if (!ac.IsEmpValid(int.Parse(eid.Text)))
                MessageBox.Show("Employee Doesn't Exist");
            else
                ac.AddHist(int.Parse(eid.Text), Company.Text, Start.Value, End.Value);
        }
    }
}
