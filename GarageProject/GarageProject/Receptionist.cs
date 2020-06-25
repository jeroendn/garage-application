using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace GarageProject
{
    public partial class Receptionist : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private List<string>[] myList;
        private string dgselectedid;

        public Receptionist()
        {
            InitializeComponent();
        }

        private void bsAgenda_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BindGrid()
        {
            DBConnect myDBConnect = new DBConnect();
            List<string>[] myList = myDBConnect.GetAppointments(string.Empty);
            dgAgenda.Rows.Clear();
            for (int i = 0; i < myList[0].Count; i++)
            {
                {

                    if (myList[0][i].ToString() != "")
                    {
                        string[] row1 = new string[] { myList[0][i].ToString(), myList[1][i].ToString(), myList[2][i].ToString(), myList[3][i].ToString(), myList[4][i].ToString(), myList[5][i].ToString(), myList[6][i].ToString(), myList[7][i].ToString(), myList[8][i].ToString() };

                        dgAgenda.Rows.Add(row1);
                    }

                }

            }

        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            this.BindGrid();
            dtpPlanningDag.Format = DateTimePickerFormat.Custom;
            dtpPlanningDag.CustomFormat = "dd-MM-yyyy";
            DBConnect myDBConnect1 = new DBConnect();
            List<string>[] myList = myDBConnect1.GetEmployees();
            for (int i = 0; i < myList[0].Count; i++)
            {
                {
                    if (myList[0][i].ToString() != "")
                    {
                        string[] row1 = new string[] { myList[0][i].ToString() };
                        string[] row2 = new string[] { myList[1][i].ToString() };
                        string[] row3 = new string[] { myList[2][i].ToString() };
                        string[] row4 = new string[] { myList[3][i].ToString() };
                        ComboboxItem item = new ComboboxItem();
                        item.Text = row2[0] + " " + row3[0];
                        item.Value = row1;
                        cboMonteur.Items.Add(item);
                        ;
                    }
                }
            }

            DBConnect myDBConnect2 = new DBConnect();
            List<string>[] myList1 = myDBConnect2.GetStatus();
            for (int i = 0; i < myList1[0].Count; i++)
            {
                {
                    if (myList1[0][i].ToString() != "")
                    {
                        string[] row1 = new string[] { myList1[0][i].ToString() };
                        cboStatus.Items.Add(row1[0]);
                        ;
                    }
                }
            }


        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            dtpPlanningDag.Format = DateTimePickerFormat.Custom;
            dtpPlanningDag.CustomFormat = "dd-MM-yyyy";
            string sDag = dtpPlanningDag.Text.Substring(0,2);
            string sMaand = dtpPlanningDag.Text.Substring(3, 2);
            string sJaar = dtpPlanningDag.Text.Substring(6, 4);
            string sTotDatum = sJaar + "-" + sMaand + "-" + sDag;
            DBConnect myDBConnect = new DBConnect();
            List<string>[] myList = myDBConnect.GetAppointments(sTotDatum);
            dgAgenda.Rows.Clear();
            for (int i = 0; i < myList[0].Count; i++)
            {
                {

                    if (myList[0][i].ToString() != "")
                    {
                        string[] row1 = new string[] { myList[0][i].ToString(), myList[1][i].ToString(), myList[2][i].ToString(), myList[3][i].ToString(), myList[4][i].ToString(), myList[5][i].ToString(), myList[6][i].ToString(), myList[7][i].ToString(), myList[8][i].ToString(), myList[9][i].ToString() };

                        dgAgenda.Rows.Add(row1);
                    }

                }

            }

        }

        private void btnToonAlles_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //Collectie van eigenschappen van de geselecteerde rij

            DataGridViewRow row = dgAgenda.Rows[rowIndex];
            cboStatus.Text = row.Cells[6].Value.ToString();
            cboMonteur.Text = row.Cells[7].Value.ToString() + " " + row.Cells[8].Value.ToString();
            tbxOpmerking.Text = row.Cells[1].Value.ToString();
            dgselectedid = row.Cells[0].Value.ToString();

        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(cboMonteur.SelectedValue.ToString());
            //cboMonteur.SelectedIndex = 0;
            //MessageBox.Show(cboMonteur.SelectedItem.ToString());
            if (dgselectedid != "")
            {
                int dgId = Convert.ToInt32(dgselectedid);
                DBConnect myDBConnect2 = new DBConnect();
                myDBConnect2.UpdateReceptionist(cboStatus.SelectedItem.ToString(), cboMonteur.SelectedItem.ToString(), tbxOpmerking.Text, Convert.ToInt32(dgselectedid));
                BindGrid();
            }

            // MessageBox.Show(cboMonteur.SelectedIndex.ToString());

        }
    }
}
