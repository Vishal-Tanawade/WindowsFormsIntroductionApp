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
    public partial class Form2 : Form
    {
        static int flag;
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag <= 100)
            {
                progressBar1.Value = flag;
                flag++;
            }
            else
            {
                timer1.Enabled = false;
                Form1 frm = new Form1();
                frm.Show();
                
            }


        }
    }
}
