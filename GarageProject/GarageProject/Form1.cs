using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInlog_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            PasswordHash ph = new PasswordHash();
        }
    }
}
