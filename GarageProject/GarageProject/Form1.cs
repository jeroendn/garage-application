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
            string password = "wordpress";
            string hulpwoord = "ROCA12";
            //textBox1.Text = PWEncrypt;
            string PWEncrypt = PasswordHash.Encrypt(tbxWachtwoord.Text, hulpwoord);
            string PWDecrypt;

            DBConnect myDBConnect = new DBConnect();

            List<string>[] myList = myDBConnect.LoginPerson(tbxEmail.Text, PWEncrypt);
            for (int i = 0; i < myList[0].Count; i++)
            {
                {

                    if (myList[0][i].ToString() != "")
                    {
                         string[] DBEmail = new string[] { myList[0][i].ToString() };
                         string[] DBPassword = new string[] { myList[1][i].ToString() };
                         string[] DBRole = new string[] { myList[2][i].ToString() };

                    }

                }

            }
            PWDecrypt = PasswordHash.Decrypt(myList[1][0].ToString(), hulpwoord);
            if (PWDecrypt==tbxWachtwoord.Text) {
               //MessageBox.Show("Correct Password");
                    switch(myList[2][0].ToString()){
                        case "Eigenaar":     Eigenaar eigenaar = new Eigenaar();
                                             this.Hide();
                                             eigenaar.ShowDialog();
                                             break;
                        case "Receptionist": Receptionist receptionist= new Receptionist();
                                             this.Hide();
                                             receptionist.ShowDialog();
                                             break;
                        case "Monteur":      Monteur monteur = new Monteur();
                                             this.Hide();
                                             monteur.ShowDialog();
                                             break;
                     }

            }
            else{
               MessageBox.Show("Incorrect Password");
            }





           // MessageBox.Show (PWEncrypt);
           // MessageBox.Show(PWDecrypt);

            


            PasswordHash ph = new PasswordHash();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxEmail.Text = "jeroendenijs@garageochten.nl";
            tbxWachtwoord.Text = "wordpress";
        }
    }
}
