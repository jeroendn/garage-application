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
using System.Windows.Forms.DataVisualization.Charting;

namespace GarageProject
{
    public partial class Eigenaar : Form
    {
        DBConnect myDBConnect = new DBConnect();
        public  string totalprice;
        public  string hours;

        public Eigenaar()
        {
            InitializeComponent();
        }

        private void Eigenaar_Load(object sender, EventArgs e)
        {
            //Bij de load vul de datagridview en toon de grafiek
            BindGrid();
            ChartLast6Months();
        }
        private void BindGrid()
        {
            List<string>[] myList = myDBConnect.GetAppointments(string.Empty, string.Empty);
            dgEigenaar.Rows.Clear();
            for (int i = 0; i < myList[0].Count; i++)
            {
                {

                    if (myList[0][i].ToString() != "")
                    {
                        //vul de rijen van de datagridview
                        string[] row1 = new string[] { myList[0][i].ToString(), myList[2][i].ToString(), myList[5][i].ToString(), myList[4][i].ToString() };

                        dgEigenaar.Rows.Add(row1);
                    }

                }

            }

        }
        private void btnZoekenOpMaand_Click(object sender, EventArgs e)
        {
            //Om te kunnen zoeken in SQL hebben we het maandnummer nodig.
            int intMaand = 0;
            switch (cboMaand.SelectedItem.ToString())
            {
                case "Januari": intMaand = 1;
                    break;
                case "Februari": intMaand = 2;
                    break;
                case "Maart": intMaand = 3;
                    break;
                case "April": intMaand = 4;
                    break;
                case "Mei": intMaand = 5;
                    break;
                case "Juni": intMaand = 6;
                    break;
                case "Juli": intMaand = 7;
                    break;
                case "Augustus": intMaand = 8;
                    break;
                case "September": intMaand = 9;
                    break;
                case "Oktober": intMaand = 10;
                    break;
                case "November": intMaand = 11;
                    break;
                case "December": intMaand = 12;
                    break;

            }
            List<string>[] myList = myDBConnect.GetAppointments(string.Empty, Convert.ToString(intMaand));
            dgEigenaar.Rows.Clear();
            for (int i = 0; i < myList[0].Count; i++)
            {
                {

                    if (myList[0][i].ToString() != "")
                    {
                        string[] row1 = new string[] { myList[0][i].ToString(), myList[2][i].ToString(), myList[5][i].ToString(), myList[4][i].ToString() };

                        dgEigenaar.Rows.Add(row1);
                    }

                }
                TotaleMaandOmzet(intMaand);
            }

        }
        private void TotaleMaandOmzet(int intMonth)
        {
            lblTotaleMaandOmzet.Text = "";
            string totalprice = string.Empty;
            string query = "select sum(total_price) as totalprice from appointments where Month(appointments.created_at) = " + intMonth +
                           " and  Year(appointments.created_at) = " + DateTime.Now.Year + " and status_id = 5";
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
            if (totalprice != string.Empty)
            {
                lblTotaleMaandOmzet.Text = "Totale maandomzet: EUR " + totalprice;
            }
        }
        private void ChartLast6Months()
        {

            //geeft string terug van de laatste 6 volle maanden vb 02-2020
            var lastSixMonths = Enumerable.Range(0, 6).Select(i => DateTime.Now.AddMonths(i - 6).ToString("MM/yyyy"));

            //zet de waardes in een list
            List<string>[] mylist = new List<string>[1];
            mylist[0] = new List<string>();

            foreach (var monthAndYear in lastSixMonths)
            {
                mylist[0].Add(monthAndYear);
            }

            //Maak legenda
            chartEigenaar.Series.Add("Omzet");
            chartEigenaar.Series.Add("Uren");

            //loop door de laatste 6 maandenlijst
            for (int i = 0; i < mylist[0].Count; i++)
            {
                {
                    string[] row1 = new string[] { mylist[0][i].ToString() };
                    if (string.IsNullOrEmpty(hours)) { hours = "0"; }
                    if (string.IsNullOrEmpty(totalprice)) { totalprice = "0"; }
                    GetMonthlyRev(row1[0]);

                    totalprice = totalprice.Replace(",", ".");
                    hours = hours.Replace(",", ".");
                    // chartEigenaar.Series[0].Label = totalprice;
                    // chartEigenaar.Series[1].Label = hours;
                    chartEigenaar.Series[0].Points.AddXY(row1[0], totalprice);
                    chartEigenaar.Series[1].Points.AddXY(row1[0], hours);

                }
            }
            chartEigenaar.Legends["Legend1"].Enabled = true;



            string sSeries = string.Empty;
        }

        public void GetMonthlyRev(string MonthYear)
        {
            string myMonth = MonthYear.Substring(0, 2);
            string myYear = MonthYear.Substring(3, 4);

            if (myMonth.Substring(0,1) == "0")
            {
                myMonth = myMonth.Substring(1, 1);
            }

            try
            {
                //In deze query worden de omzet(total price) en de uren per maand opgeteld.
                string query = "select sum(total_price) as totalprice, sum(hours) as uren from appointments where Month(appointments.created_at) = " + myMonth +
                               " and Year(appointments.created_at) = " + myYear + " and status_id = 5";
                List<string>[] myList = myDBConnect.GetMonthlyRevenueAndHours(query, "totalprice", "uren");
                for (int i = 0; i < myList[0].Count; i++)
                {
                    {
                        if (myList[0][i].ToString() != "")
                        {
                            string[] row1 = new string[] { myList[0][i].ToString() };
                            string[] row2 = new string[] { myList[1][i].ToString() };
                            totalprice = row1[0];
                            hours = row2[0];
                        }
                    }
                }
            }
            catch { };


           // return;
        }
    }
}
