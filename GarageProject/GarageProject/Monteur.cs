using MySqlX.XDevAPI.Relational;
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
    public partial class Monteur : Form
    {

        private string dgselectedid;


        public Monteur()
        {
            InitializeComponent();
        }

        private void Monteur_Load(object sender, EventArgs e)
        {
            this.BindGrid();
            dtpPlanningDag.Format = DateTimePickerFormat.Custom;
            dtpPlanningDag.CustomFormat = "dd-MM-yyyy";
            DBConnect myDBConnect = new DBConnect();
            List<string>[] myList = myDBConnect.GetEmployees();
            for (int i = 0; i < myList[0].Count; i++)
            {
                {
                    if (myList[0][i].ToString() != "")
                    {
                        string[] row1 = new string[] { myList[1][i].ToString() };
                        string[] row2 = new string[] { myList[2][i].ToString() };
                        cboMonteur.Items.Add(row1[0] + " " + row2[0]);
                        ;
                    }
                }
            }

            List<string>[] myList1 = myDBConnect.ReturnList("SELECT status FROM appointment_status order by status asc", "status");
            for (int i = 0; i < myList1[0].Count; i++)
            {
                {
                    if (myList1[0][i].ToString() != "")
                    {
                        string[] row1 = new string[] { myList1[0][i].ToString() };
                        cboWerkplaatsStatus.Items.Add(row1[0]);
                        ;
                    }
                }
            }

            List<string>[] myList2 = myDBConnect.ReturnList("SELECT name FROM parts order by name asc","name");
            for (int i = 0; i < myList2[0].Count; i++)
            {
                {
                    if (myList2[0][i].ToString() != "")
                    {
                        string[] row1 = new string[] { myList2[0][i].ToString() };
                        cboOnderdeel.Items.Add(row1[0]);
                        ;
                    }
                }
            }


        }
        private void BindGrid()
        {
            DBConnect myDBConnect = new DBConnect();
            List<string>[] myList = myDBConnect.GetAppointments(string.Empty, string.Empty);
            dgMonteur.Rows.Clear();
            for (int i = 0; i < myList[0].Count; i++)
            {
                {

                    if (myList[0][i].ToString() != "")
                    {
                        string[] row1 = new string[] { myList[0][i].ToString(), myList[5][i].ToString(), myList[6][i].ToString(), myList[2][i].ToString(), myList[1][i].ToString(), myList[7][i].ToString(), myList[8][i].ToString()};

                        dgMonteur.Rows.Add(row1);
                    }

                }

            }

        }

        private void RefreshdgOnderdeel()
        {
            try
            {
                DBConnect myDBConnect = new DBConnect();
                List<string>[] myList = myDBConnect.GetParts(dgselectedid);
                dgOnderdelen.Rows.Clear();
                for (int i = 0; i < myList[0].Count; i++)
                {
                    {

                        if (myList[0][i].ToString() != "")
                        {
                            string[] row2 = new string[] { myList[0][i].ToString(), myList[1][i].ToString(), myList[2][i].ToString(), myList[3][i].ToString() };

                            dgOnderdelen.Rows.Add(row2);
                        }

                    }

                }
            }
            catch { }

        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            dtpPlanningDag.Format = DateTimePickerFormat.Custom;
            dtpPlanningDag.CustomFormat = "dd-MM-yyyy";
            string sDag = dtpPlanningDag.Text.Substring(0, 2);
            string sMaand = dtpPlanningDag.Text.Substring(3, 2);
            string sJaar = dtpPlanningDag.Text.Substring(6, 4);
            string sTotDatum = sJaar + "-" + sMaand + "-" + sDag;
            DBConnect myDBConnect = new DBConnect();
            List<string>[] myList = myDBConnect.GetAppointments(sTotDatum, string.Empty);
            dgMonteur.Rows.Clear();
            for (int i = 0; i < myList[0].Count; i++)
            {
                {

                    if (myList[0][i].ToString() != "")
                    {
                        string[] row1 = new string[] { myList[0][i].ToString(), myList[5][i].ToString(), myList[6][i].ToString(), myList[2][i].ToString(), myList[1][i].ToString(), myList[7][i].ToString(), myList[8][i].ToString() };

                        dgMonteur.Rows.Add(row1);
                    }

                }

            }

        }

        private void btnToonAlles_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgMonteur_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgMonteur.SelectedRows)
            {
                dgselectedid = row.Cells[0].Value.ToString();
                cboWerkplaatsStatus.Text = row.Cells[2].Value.ToString();
                tbxOpmerking.Text = row.Cells[4].Value.ToString();
                cboMonteur.Text = row.Cells[5].Value.ToString() + " " + row.Cells[6].Value.ToString();
            }


            RefreshdgOnderdeel();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            int dgId = Convert.ToInt32(dgselectedid);
            DBConnect myDBConnect = new DBConnect();
            myDBConnect.UpdateStatusMonteurOpmerking(cboWerkplaatsStatus.SelectedItem.ToString(), "", tbxOpmerking.Text, Convert.ToInt32(dgselectedid));
            BindGrid();
        }

        private void btnOnderdeelToevoegen_Click(object sender, EventArgs e)
        {

            string partsid = string.Empty;
            string partsprice = string.Empty;
            string totalprice = string.Empty;
            string query = string.Empty;

            //Haal de appointment id op uit het datagrid dgmonteur
            try
            {
                foreach (DataGridViewRow row in dgMonteur.SelectedRows)
                {
                    dgselectedid = row.Cells[0].Value.ToString();
                }
            }
            catch { }

            if (dgselectedid != "")
            {
                //Haal van het onderdeel de prijs en id op met de naam van het onderdeel uit de combobox cboOnderdeel 
                DBConnect myDBConnect = new DBConnect();
                List<string>[] myList = myDBConnect.GetPartsIDAndPrice(cboOnderdeel.SelectedItem.ToString());
                for (int i = 0; i < myList[0].Count; i++)
                {
                    {
                        if (myList[0][i].ToString() != "")
                        {
                            string[] row1 = new string[] { myList[0][i].ToString() };
                            string[] row2 = new string[] { myList[1][i].ToString() };
                            partsid = row1[0];
                            partsprice = row2[0];
                            ;
                        }
                    }
                }

                //Als er een parts.id is gevonden, kan er een databaserij worden ingevoegd
                if (partsid != string.Empty && tbxAantal.Text != string.Empty)
                {
                    partsprice = partsprice.Replace(",", ".");
                    tbxAantal.Text = tbxAantal.Text.Replace(",", ".");
                    query = "INSERT INTO appointment_part(appointment_id, part_id, amount, price_per_piece) VALUES (" + dgselectedid +
                                            ", " + partsid + ", " + tbxAantal.Text + ", " + partsprice + ")";
                    myDBConnect.ExecuteSQL(query);

                    query = "select sum(price_per_piece * amount) as totalprice from appointment_part where appointment_id = " + dgselectedid;
                    List<string>[] myList1 = myDBConnect.ReturnList(query, "totalprice");
                    for (int i = 0; i < myList1[0].Count; i++)
                    {
                        {
                            if (myList1[0][i].ToString() != "")
                            {
                                string[] row1 = new string[] { myList1[0][i].ToString() };
                                totalprice = row1[0];
                            }
                        }
                    }

                    totalprice = totalprice.Replace(",", ".");
                    query = "Update appointments set total_price = " + totalprice + " where id = " + dgselectedid;
                    myDBConnect.ExecuteSQL(query);

                }
                RefreshdgOnderdeel();

            }
        }

        private void btnZoekMonteur_Click(object sender, EventArgs e)
        {

        }
    }
}
