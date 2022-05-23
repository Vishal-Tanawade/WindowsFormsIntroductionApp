using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsIntroductionApp
{
    public partial class Form1 : Form
    {
        string[] DaysOfWeek = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday" };
        
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnGreet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, "+txtName.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string Day in DaysOfWeek)
            {
                cmbDaysOfWeek.Items.Add(Day);
            }
        }
    }
}
