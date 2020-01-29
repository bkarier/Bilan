using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bilan2016
{
    public partial class Annexes : Form
    {

        private void checkBalance(string Customer_Code, int Fiscal_Year)
        {
            SqlConnection sqlconn = new SqlConnection("Data Source=srvdwh;Initial Catalog=FisoDWH;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM [dbo].[vAnnexesCheckBal] WHERE Customer_Code = '" + Customer_Code + "' AND FiscalYear = " + Fiscal_Year.ToString(), sqlconn);
            SqlDataReader reader;
            try
            {
                reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    decimal X20 = reader.GetDecimal(reader.GetOrdinal("X20"));
                    decimal X211 = reader.GetDecimal(reader.GetOrdinal("X211"));
                    decimal X212 = reader.GetDecimal(reader.GetOrdinal("X212"));
                    decimal X213 = reader.GetDecimal(reader.GetOrdinal("X213"));
                    decimal X221 = reader.GetDecimal(reader.GetOrdinal("X221"));
                    decimal X222 = reader.GetDecimal(reader.GetOrdinal("X222"));
                    decimal X223 = reader.GetDecimal(reader.GetOrdinal("X223"));
                    decimal X30 = reader.GetDecimal(reader.GetOrdinal("X30"));
                    decimal X31_32 = reader.GetDecimal(reader.GetOrdinal("X31_32"));
                    decimal X40_42 = reader.GetDecimal(reader.GetOrdinal("X40_42"));

                    if (X20 == 0)
                    {
                        labFraisEtablissement.Enabled = false;
                        tBFraisEtablissement.Enabled = false;
                        CBFraisEtablissement.Enabled = false;
                    }

                    if (X211 == 0)
                    {
                        labX211.Enabled = false;
                        tBX211.Enabled = false;
                        cBX211.Enabled = false;
                    }
                    if (X212 == 0)
                    {
                        labX212.Enabled = false;
                        tBX212.Enabled = false;
                        cBX212.Enabled = false;
                    }
                    if (X213 == 0)
                    {
                        labX213.Enabled = false;
                        tBX213.Enabled = false;
                        cBX213.Enabled = false;
                    }
                    if (X221 == 0)
                    {
                        labX221.Enabled = false;
                        tBX221.Enabled = false;
                        cBX221.Enabled = false;
                    }
                    if (X222 == 0)
                    {
                        labX222.Enabled = false;
                        tBX222.Enabled = false;
                        cBX222.Enabled = false;
                    }
                    if (X223 == 0)
                    {
                        labX223.Enabled = false;
                        tBX223.Enabled = false;
                        cBX223.Enabled = false;
                    }
                    reader.Close();
                }

            }
            catch
            { }
            
            sqlcmd = new SqlCommand("SELECT * FROM [dbo].[Annexes_Legales] WHERE Customer_Code = '" + Customer_Code + "' AND Fiscal_Year = " + Fiscal_Year.ToString(), sqlconn);
            try
            {
                reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    tBFraisEtablissement.Text = reader.GetString(reader.GetOrdinal("Période frais établissement"));
                    CBFraisEtablissement.Text = reader.GetString(reader.GetOrdinal("Méthode frais établissement"));
                    tBX211.Text = reader.GetString(reader.GetOrdinal("Taux frais de recherche"));
                    cBX211.Text = reader.GetString(reader.GetOrdinal("Méthode frais de recherche"));
                    tBX212.Text = reader.GetString(reader.GetOrdinal("Taux concessions"));
                    cBX212.Text = reader.GetString(reader.GetOrdinal("Méthode concessions"));
                    tBX213.Text = reader.GetString(reader.GetOrdinal("Taux fonds de commerce"));
                    cBX213.Text = reader.GetString(reader.GetOrdinal("Méthode fonds de commerce"));
                    tBX221.Text = reader.GetString(reader.GetOrdinal("Taux terrains"));
                    cBX221.Text = reader.GetString(reader.GetOrdinal("Méthode terrains"));
                    tBX222.Text = reader.GetString(reader.GetOrdinal("Taux installations techniques"));
                    cBX222.Text = reader.GetString(reader.GetOrdinal("Méthode installations techniques"));
                    tBX223.Text = reader.GetString(reader.GetOrdinal("Taux autres installations"));
                    cBX223.Text = reader.GetString(reader.GetOrdinal("Méthode autres installations"));
                }
                reader.Close();
            }
            catch
            {
            }
        }
        public string sCustomer_Code;
        public int iYear;

        public Annexes(string company, int fiscalYear)
        {
            InitializeComponent();
            sCustomer_Code = company.Substring(0, 6);
            iYear = fiscalYear;

            this.Text = "Annexes légales - "+company.ToString();
            labFiscalYear.Text = fiscalYear.ToString();
            checkBalance(company.Substring(0,6),fiscalYear);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection("Data Source=srvdwh;Initial Catalog=FisoDWH;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlCommand sqlcmd;
            sqlconn.Open();
            sqlcmd = sqlconn.CreateCommand();
            sqlcmd.CommandText = "DELETE FROM dbo.Annexes_Legales WHERE Customer_Code = '" + sCustomer_Code + "' AND Fiscal_Year = " + iYear;
            sqlcmd.ExecuteNonQuery();
            sqlcmd.CommandText = "INSERT INTO dbo.Annexes_Legales VALUES ('" + sCustomer_Code + "',"+iYear+",'"+tBFraisEtablissement.Text+"','"+CBFraisEtablissement.Text+"','"+tBX211.Text+"','"+cBX211.Text + "','" + tBX212.Text + "','" + cBX212.Text + "','" + tBX213.Text + "','" + cBX213.Text + "','" + tBX221.Text + "','" + cBX221.Text + "','" + tBX222.Text + "','" + cBX222.Text + "','" + tBX223.Text + "','" + cBX223.Text + "')";
            sqlcmd.ExecuteNonQuery();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
