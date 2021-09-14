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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess ac = new DataAccess();
            try
            {
                ac.Delete(int.Parse(ID.Text));
                MessageBox.Show("Entry Deleted");
            }
            catch(Exception)
            {
                MessageBox.Show("Entry with the given Id does not exist");
            }
        }
    }
}
