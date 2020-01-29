using Bilan2016.FisoDWHDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilan2016
{
    public partial class Amortissements : Form
    {
        public Amortissements()
        {
            InitializeComponent();
        }


        private void btPaste_Click(object sender, EventArgs e)
        {
            this.dataGridView1.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dataGridView1.RowCount > 0)
                    dataGridView1.Rows.Clear();

                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                int j = 0;
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });
                    float fvalue;
                    dataGridView1.Rows.Add();
                    int myRowIndex = dataGridView1.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dataGridView1.Rows[j])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                        {
                            if (i >= 2)
                            {
                                try
                                {
                                    float.TryParse(pastedRowCells[i].Replace("%",""), out fvalue);
                                }
                                catch
                                {
                                    fvalue = 0;
                                }
                                myDataGridViewRow.Cells[i].Value = fvalue;
                            }
                            else
                            {
                                myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                            }
                        }
                    }
                    j++;
                }
            }
            //calcGrid();
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
        }

        private void calcGrid()
        {
            int gridRows = dataGridView1.Rows.Count - 1;
            for (int i = 0; i < gridRows; i++)
            {
                DateTime dateAmort = new DateTime(2015, 12, 31);
                float valeur;
                int year;
                int monthAqui;
                float ventes;
                try
                {
                    float.TryParse(dataGridView1.Rows[i].Cells["Ventes"].Value.ToString(), out ventes);
                }
                catch
                {
                    ventes = 0;
                }
                try {
                    float.TryParse(dataGridView1.Rows[i].Cells["Valeur"].Value.ToString(), out valeur);
                } catch {
                    valeur = 0;
                }
                try
                {
                    DateTime dateAcqui = Convert.ToDateTime(dataGridView1.Rows[i].Cells["Date"].Value);
                    monthAqui = dateAcqui.Month;
                    year = dateAcqui.Year;
                } catch {
                    year = 0;
                    monthAqui = 0;
                }
                    
                float div = 5;
                float result = valeur / div;
                

                int monthsFirstYear = 0;
                
                float yearFirst;
                float yearMiddle;
                float yearLast;

                if (monthAqui < 5)
                {
                    monthsFirstYear = 12;

                }
                else
                {
                    if (monthAqui == 12)
                    {
                        monthsFirstYear = 1;
                    }
                    else
                    {
                        monthsFirstYear = 12 - monthAqui + 1;
                    }
                }
                float taux;
                try
                {
                    float.TryParse(dataGridView1.Rows[i].Cells["Taux"].Value.ToString().Replace("%",""), out taux);
                }
                catch
                {
                    taux = 0;
                }
                yearFirst = valeur * monthsFirstYear / 12 * taux / 100;
                yearMiddle = valeur * taux / 100;
                yearLast = valeur * taux / 100 / 12 * (monthAqui - 1);

                float vncDebut = 0;
                float vncFin = 0;
                float amort = 0;
                float acqui = 0;

                if (year == dateAmort.Year)
                {
                    vncDebut = 0;
                    acqui = valeur;
                }
                else if ((year + (100 / taux) < dateAmort.Year))
                {
                    acqui = 0;
                    vncDebut = (float)0.01;
                } else
                {
                    acqui = 0;
                    vncDebut = valeur - yearFirst - (yearMiddle * (dateAmort.Year - year - 1));
                }

                if (year == dateAmort.Year)
                {
                    amort = yearFirst;
                } else if (year + (100 / taux) == dateAmort.Year)
                {
                    amort = yearLast;
                } else if (year + (100 / taux) < dateAmort.Year)
                {
                    amort = 0;
                } else
                {
                    amort = yearMiddle;
                }
                if (vncDebut <= amort && vncDebut > 0) amort = vncDebut - (float)0.01;
                if (vncDebut == 0)
                {
                    vncFin = valeur - amort - ventes;
                } else
                {
                    vncFin = vncDebut - amort - ventes;
                }
                
                dataGridView1.Rows[i].Cells["VNCdebut"].Value = vncDebut;
                dataGridView1.Rows[i].Cells["VNCfin"].Value = vncFin;
                dataGridView1.Rows[i].Cells["Amortissement"].Value = amort;
                dataGridView1.Rows[i].Cells["Acquisitions"].Value = acqui;
                dataGridView1.Rows[i].Cells["Ventes"].Value = ventes;
                dataGridView1.Rows[i].Cells["Taux"].Value = taux;

            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //calcGrid();            
        }

        private void btRecalc_Click(object sender, EventArgs e)
        {
            calcGrid();
        }

        private void Amortissements_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fisoDWHDataSet2.DataTableAmortLevel2' table. You can move, or remove it, as needed.
            //this.dataTableAmortLevel2TableAdapter.Fill(this.fisoDWHDataSet2.DataTableAmortLevel2,comboBox1.SelectedValue.ToString(),tBdossier.Text);
            // TODO: This line of code loads data into the 'fisoDWHDataSet2.DataTableAmortLevel1' table. You can move, or remove it, as needed.
            this.dataTableAmortLevel1TableAdapter.Fill(this.fisoDWHDataSet2.DataTableAmortLevel1);
            this.dataTableAmortLevel2TableAdapter.Fill(this.fisoDWHDataSet2.DataTableAmortLevel2, comboBox1.SelectedValue.ToString(), tBdossier.Text);
            comboBox2.Refresh();
        }
        private void Combo_Level1_Change(object sender, EventArgs e)
        {
            try
            {
                this.dataTableAmortLevel2TableAdapter.Fill(this.fisoDWHDataSet2.DataTableAmortLevel2, comboBox1.SelectedValue.ToString(), tBdossier.Text);
                comboBox2.Refresh();
            } catch {

            }
        }
        private void Combo_Level2_Change(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null) loadTable(tBdossier.Text, Convert.ToInt16(tBYear.Text), comboBox2.SelectedValue.ToString());

        }


        private void btSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection("Data Source=srvdwh;Initial Catalog=FisoDWH;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlCommand sqlcmd;
            string StrQuery = "";
            try
            {
                sqlconn.Open();
                sqlcmd = sqlconn.CreateCommand();
                StrQuery = "DELETE FROM dbo.Depreciation WHERE Customer_Code = '" + tBdossier.Text + "' AND Account = '" + comboBox2.SelectedValue + "' AND Year = " + tBYear.Text;
                sqlcmd.CommandText = StrQuery;
                sqlcmd.ExecuteNonQuery();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DateTime dateAcqui = Convert.ToDateTime(dataGridView1.Rows[i].Cells["Date"].Value);
                    StrQuery = @"INSERT INTO dbo.Depreciation VALUES ("
                        + "'" + tBdossier.Text + "', "
                        + tBYear.Text + " ," 
                        + "'" + comboBox2.SelectedValue + "', "
                        + "'" + dataGridView1.Rows[i].Cells["Designation"].Value + "', "
                        + "'" + dateAcqui.ToString("yyyy-MM-dd HH:MM:ss") + "', "
                        + dataGridView1.Rows[i].Cells["Valeur"].Value + ", "
                        + dataGridView1.Rows[i].Cells["Taux"].Value + ", "
                        + dataGridView1.Rows[i].Cells["VNCdebut"].Value + ", "
                        + dataGridView1.Rows[i].Cells["Acquisitions"].Value + ", "
                        + dataGridView1.Rows[i].Cells["Ventes"].Value + ", "
                        + dataGridView1.Rows[i].Cells["Amortissement"].Value + ", "
                        + dataGridView1.Rows[i].Cells["VNCfin"].Value + ");";
                    sqlcmd.CommandText = StrQuery;
                    sqlcmd.ExecuteNonQuery();
                }
            }
            catch
            {
                Console.WriteLine(StrQuery);
            }
        }

        private void loadTable(string customer_code, int year, string account)
        {
            Console.WriteLine(customer_code + year.ToString() + account);
            this.dataGridView1.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            if (dataGridView1.RowCount > 0) dataGridView1.Rows.Clear();
            FisoDWHDataSet.DepreciationDataTable depData;
            DepreciationTableAdapter depTableAdapter = new DepreciationTableAdapter();
            depData = depTableAdapter.GetData(customer_code, year, account);
            int j = 0;
            foreach (DataRow row in depData.Rows)
            {
                dataGridView1.Rows.Add();
                int myRowIndex = dataGridView1.Rows.Count - 1;
                using (DataGridViewRow myDataGridViewRow = dataGridView1.Rows[j])
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        myDataGridViewRow.Cells[i].Value = row[i];
                    }
                }
                j++;
            }
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadTable("ANT001",2015,"2232");


        }
    }
}
