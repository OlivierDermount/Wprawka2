using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegaty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void SetColumnHeader()
        {
            //Ciało metody
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("MousEnter");
        }
    }
}
