using System;
using System.Windows.Forms;
using Advantage.Data.Provider;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Net;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using Bilan2016;

namespace QuickBOBload
{
    public partial class Form1 : Form
    {

        public DataTable dt = new DataTable();

        public void get_ac_accoun(string db)
        {
            
            AdsConnection adsconn = new AdsConnection("Data Source=\\\\192.168.5.5:6262\\bob50\\BOB50DATA\\" + db + ";ServerType=REMOTE;TableType=ADT;LockMode=PROPRIETARY;CharType=ADS_ANSI;SecurityMode=IGNORERIGHTS");
            AdsCommand adscmd;
            AdsDataReader adsreader;
            //SqlConnection sqlconn = new SqlConnection("Data Source=srvdwh;Initial Catalog=Staging;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlConnection sqlconn = new SqlConnection("Data Source=SRVSQL\\FISODWH;Initial Catalog=Staging;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlCommand sqlcmd;
            try
            {
                
                adsconn.Open();
                sqlconn.Open();
                adscmd = adsconn.CreateCommand();
                sqlcmd = sqlconn.CreateCommand();
                adscmd.CommandText = "SELECT '" + db + "' AS DB,AID,AISTITLE,HEADING1 FROM ac_accoun";
                adsreader = adscmd.ExecuteReader();
                sqlcmd.CommandText = "DELETE FROM dbo.ac_accoun WHERE DB = '" + db + "'";
                sqlcmd.ExecuteNonQuery();
                using (SqlBulkCopy bulkCopy =
                           new SqlBulkCopy(sqlconn))
                {
                    bulkCopy.DestinationTableName = "dbo.ac_accoun";

                    try
                    {
                        // Write from the source to the destination.
                        bulkCopy.WriteToServer(adsreader);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        // Close the SqlDataReader. The SqlBulkCopy
                        // object is automatically closed at the end
                        // of the using block.
                    }
                }


                adsconn.Close();
                AdsConnection.FlushConnectionPool();
                sqlconn.Close();
            }
            catch (AdsException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void loadSSIS()
        {
            //SqlConnection DbConn = new SqlConnection("Data Source=srvdwh;Initial Catalog=msdb;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlConnection DbConn = new SqlConnection("Data Source=SRVSQL\\FISODWH;Initial Catalog=msdb;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlCommand ExecJob = new SqlCommand();
            ExecJob.CommandType = CommandType.StoredProcedure;
            ExecJob.CommandText = "msdb.dbo.sp_start_job";
            ExecJob.Parameters.AddWithValue("@job_name", "Freelanders Book-In");
            ExecJob.Connection = DbConn; //assign the connection to the command.

            using (DbConn)
            {
                DbConn.Open();
                using (ExecJob)
                {
                    ExecJob.ExecuteNonQuery();
                }
                DbConn.Close();
            }

        }

        public void loadSSIS_DEC002()
        {
            //SqlConnection DbConn = new SqlConnection("Data Source=srvdwh;Initial Catalog=msdb;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlConnection DbConn = new SqlConnection("Data Source=SRVSQL\\FISODWH;Initial Catalog=msdb;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlCommand ExecJob = new SqlCommand();
            ExecJob.CommandType = CommandType.StoredProcedure;
            ExecJob.CommandText = "msdb.dbo.sp_start_job";
            ExecJob.Parameters.AddWithValue("@job_name", "De Cock Book-In");
            ExecJob.Connection = DbConn; //assign the connection to the command.

            using (DbConn)
            {
                DbConn.Open();
                using (ExecJob)
                {
                    ExecJob.ExecuteNonQuery();
                }
                DbConn.Close();
            }

        }

        public void loadSSIS_ING001()
        {
            //SqlConnection DbConn = new SqlConnection("Data Source=srvdwh;Initial Catalog=msdb;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlConnection DbConn = new SqlConnection("Data Source=SRVSQL\\FISODWH;Initial Catalog=msdb;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlCommand ExecJob = new SqlCommand();
            ExecJob.CommandType = CommandType.StoredProcedure;
            ExecJob.CommandText = "msdb.dbo.sp_start_job";
            ExecJob.Parameters.AddWithValue("@job_name", "Ingenium Book-In");
            ExecJob.Connection = DbConn; //assign the connection to the command.

            using (DbConn)
            {
                DbConn.Open();
                using (ExecJob)
                {
                    ExecJob.ExecuteNonQuery();
                }
                DbConn.Close();
            }

        }

        public void upd_Account_Labels(string Customer_Code)
        {
            //SqlConnection DbConn = new SqlConnection("Data Source=srvdwh;Initial Catalog=Staging;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;")
            SqlConnection DbConn = new SqlConnection("Data Source=SRVSQL\\FISODWH;Initial Catalog=Staging;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlCommand ExecJob = new SqlCommand();
            ExecJob.CommandType = CommandType.StoredProcedure;
            ExecJob.CommandText = "dbo.sp_upd_Account_Labels";
            ExecJob.Parameters.AddWithValue("@Customer_Code", Customer_Code);
            ExecJob.Connection = DbConn; //assign the connection to the command.
            ExecJob.CommandTimeout = 180;
            using (DbConn)
            {
                DbConn.Open();
                using (ExecJob)
                {
                    ExecJob.ExecuteNonQuery();
                }
                DbConn.Close();
            }

        }

        public void getData(string db, int fromYear, int toYear)
        {
            AdsConnection adsconn = new AdsConnection("Data Source=\\\\192.168.5.5:6262\\bob50\\BOB50DATA\\" + db + ";ServerType=REMOTE;TableType=ADT;LockMode=PROPRIETARY;CharType=ADS_ANSI;SecurityMode=IGNORERIGHTS");
            AdsCommand adscmd;
            AdsDataReader adsreader;
            //SqlConnection sqlconn = new SqlConnection("Data Source=srvdwh;Initial Catalog=FisoDWH;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlConnection sqlconn = new SqlConnection("Data Source=SRVSQL\\FISODWH;Initial Catalog=FisoDWH;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlCommand sqlcmd;
            adsconn.Open();
            adscmd = adsconn.CreateCommand();
            try
            {
                
                //adscmd.CommandText = "SELECT '"+db+"'+HID AS Account_ID,'"+db+ "' AS Customer_Code,HID AS Account,YR.YEAR AS Year,CASE WHEN HMONTH=0 THEN MONTH(HDOCDATE) ELSE HMONTH END AS Month,ROUND(SUM(HAMOUNT),2) AS Amount FROM ac_ahisto AH INNER JOIN (SELECT HFYEAR,MAX(HYEAR) AS YEAR FROM ac_ahisto GROUP BY HFYEAR)YR ON AH.HFYEAR=YR.HFYEAR GROUP BY HID,YR.YEAR,Month";
                adscmd.CommandText = "SELECT '" + db + "'+HID AS Account_ID,'" + db + "' AS Customer_Code,HID AS Account, RTRIM(HFYEAR) AS Fiscal_Year,CASE WHEN HMONTH = 0 THEN Year(HDOCDATE) ELSE HYEAR END AS Year,CASE WHEN HMONTH = 0 THEN Month(HDOCDATE) ELSE HMONTH END AS Month,ROUND(SUM(HAMOUNT),2) AS Amount, COALESCE(COST_ENTITE,'') AS Cost_Center FROM ac_ahisto AH WHERE CASE WHEN HMONTH = 0 THEN Year(HDOCDATE) ELSE HYEAR END BETWEEN " + fromYear + " AND " + toYear + " GROUP BY HID,HFYEAR,Year,Month,COST_ENTITE";
                adsreader = adscmd.ExecuteReader();
            }
            catch
            {
                adscmd.CommandText = "SELECT '" + db + "'+HID AS Account_ID,'" + db + "' AS Customer_Code,HID AS Account, RTRIM(HFYEAR) AS Fiscal_Year,CASE WHEN HMONTH = 0 THEN Year(HDOCDATE) ELSE HYEAR END AS Year,CASE WHEN HMONTH = 0 THEN Month(HDOCDATE) ELSE HMONTH END AS Month,ROUND(SUM(HAMOUNT),2) AS Amount, '' AS Cost_Center FROM ac_ahisto AH WHERE CASE WHEN HMONTH = 0 THEN Year(HDOCDATE) ELSE HYEAR END BETWEEN " + fromYear + " AND " + toYear + " GROUP BY HID,HFYEAR,Year,Month";
                adsreader = adscmd.ExecuteReader();
            }
                
            try {    
                /*
                while (adsreader.Read())
                {
                    Console.WriteLine(adsreader.GetValue(0) + "\t" + adsreader.GetValue(1) + "\t" + adsreader.GetValue(2) + "\t" + adsreader.GetValue(3) + "\t" + adsreader.GetValue(4) + "\t" + adsreader.GetValue(5) + "\t" + adsreader.GetValue(6));
                }
                */
                sqlconn.Open();
                sqlcmd = sqlconn.CreateCommand();
                sqlcmd.CommandText = "DELETE FROM dbo.account_balance WHERE Customer_Code = '"+db+"' AND Year BETWEEN "+fromYear+" AND "+toYear;
                sqlcmd.ExecuteNonQuery();
                using (SqlBulkCopy bulkCopy =
                           new SqlBulkCopy(sqlconn))
                {
                    bulkCopy.DestinationTableName =
                        "dbo.account_balance";

                    try
                    {
                        // Write from the source to the destination.
                        bulkCopy.WriteToServer(adsreader);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        // Close the SqlDataReader. The SqlBulkCopy
                        // object is automatically closed at the end
                        // of the using block.
                    }
                }
                SqlCommand ExecJob = new SqlCommand();
                ExecJob.CommandType = CommandType.StoredProcedure;
                ExecJob.CommandText = "dbo.sp_update_bs_hier";
                ExecJob.Connection = sqlconn;
                using (sqlconn)
                {
                    using (ExecJob)
                    {
                        ExecJob.ExecuteNonQuery();
                    }
                }

                adsconn.Close();
                AdsConnection.FlushConnectionPool();
                sqlconn.Close();
            }
            catch (AdsException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void getLabelData(string db)
        {
            AdsConnection adsconn = new AdsConnection("Data Source=\\\\192.168.5.5:6262\\bob50\\BOB50DATA\\" + db + ";ServerType=REMOTE;TableType=ADT;LockMode=PROPRIETARY;CharType=ADS_ANSI;SecurityMode=IGNORERIGHTS");
            AdsCommand adscmd;
            AdsDataReader adsreader;
            SqlConnection sqlconn = new SqlConnection("Data Source=SRVSQL\\FISODWH;Initial Catalog=Staging;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlCommand sqlcmd;
            try
            {
                adsconn.Open();
                adscmd = adsconn.CreateCommand();
                adscmd.CommandText = "SELECT '" + db + "' AS DB,AID,AISTITLE,HEADING1,HEADING2 FROM ac_accoun";
                adsreader = adscmd.ExecuteReader();
                sqlconn.Open();
                sqlcmd = sqlconn.CreateCommand();
                sqlcmd.CommandText = "DELETE FROM ac_accoun WHERE DB = '" + db + "'";
                sqlcmd.ExecuteNonQuery();
                using (SqlBulkCopy bulkCopy =
                           new SqlBulkCopy(sqlconn))
                {
                    bulkCopy.DestinationTableName =
                        "dbo.ac_accoun";

                    try
                    {
                        // Write from the source to the destination.
                        bulkCopy.WriteToServer(adsreader);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        // Close the SqlDataReader. The SqlBulkCopy
                        // object is automatically closed at the end
                        // of the using block.
                    }
                }
                SqlCommand ExecJob = new SqlCommand();
                ExecJob.CommandType = CommandType.StoredProcedure;
                ExecJob.CommandText = "dbo.sp_upd_Account_Labels";
                ExecJob.Parameters.Add("@Customer_Code", SqlDbType.VarChar, 19).Value = db;
                ExecJob.Connection = sqlconn;
                using (sqlconn)
                {
                    using (ExecJob)
                    {
                        ExecJob.ExecuteNonQuery();
                    }
                }

                adsconn.Close();
                AdsConnection.FlushConnectionPool();
                sqlconn.Close();
            }
            catch (AdsException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string ShowMyDialogBox()
        {
            Form2 testDialog = new Form2();
            string email = "";
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                email = testDialog.textBox1.Text;
            }
            else
            {
                email = "";
            }
            testDialog.Dispose();
            return email;
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.dP_periodStart.Value = new System.DateTime(System.DateTime.Now.Year - 1, 1, 1);
            this.dP_periodEnd.Value = new System.DateTime(System.DateTime.Now.Year - 1, 12, 31);
            this.dP_period2Start.Value = new System.DateTime(System.DateTime.Now.Year - 2, 1, 1);
            this.dP_period2End.Value = new System.DateTime(System.DateTime.Now.Year - 2, 12, 31);
            this.radioFR.Checked = true;
            string dirPath = @"\\srvts\BOB50\BOB50DATA";
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            if (userName.Equals("FISOGEST\\abartholme")) cB_Customer.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));
            string dossiers = "''";
            foreach (var dir in dirs)
            {
                //if (secretdossiers.Contains(dir.Substring(dir.LastIndexOf("\\") + 1)) && admins.Contains(userName))
                dossiers = dossiers + ",'"+ dir.Substring(dir.LastIndexOf("\\") + 1)+"'";
            }
            //MessageBox.Show(dossiers);

            //SqlConnection sqlconn = new SqlConnection("Data Source=srvdwh;Initial Catalog=FisoDWH;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlConnection sqlconn = new SqlConnection("Data Source=SRVSQL\\FISODWH;Initial Catalog=FisoDWH;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            try
            {
                sqlconn.Open();
                // FISOGEST\abartholme   FISOGEST\shansen   FISOGEST\nhansen   FISOGEST\preeff
                // '3AC001','3AP001','AAS001','BAR002','DEL001','FIS001','KAH001','KAH002','KLA003','MGI001','MGI002','HAN006','PSI001','RUB001','SHI003','SOC007','TAN002','TRA002'
                SqlCommand sqlcmd;
                if (userName.Equals("FISOGEST\\shansen") || userName.Equals("FISOGEST\\nhansen") || userName.Equals("FISOGEST\\preeff") || userName.Equals("FISOGEST\\cbetti") || userName.Equals("FISOGEST\\jhoffmann"))
                {
                    sqlcmd = new SqlCommand("SELECT TradeRelation_Code,[TradeRelation_Code]+' - '+[CustomerName_T] AS Customer FROM [FisoDWH].[dbo].[Customers] WHERE TradeRelation_Code IN (" + dossiers + ") OR TradeRelation_Code IN ('FRE005','FRE008') ORDER BY [TradeRelation_Code]", sqlconn);
                } else if (userName.Equals("FISOGEST\\slizardo"))
                {
                    sqlcmd = new SqlCommand("SELECT TradeRelation_Code,[TradeRelation_Code]+' - '+[CustomerName_T] AS Customer FROM [FisoDWH].[dbo].[Customers] WHERE (TradeRelation_Code IN (" + dossiers + ") OR TradeRelation_Code IN ('FRE005','FRE008')) AND TradeRelation_Code NOT IN ('BAR002','DEL001','FIS001','KAH001','KAH002','KLA003','MGI001','HAN006','PSI001','RUB001','SHI003','SOC007','TAN002','TRA002') ORDER BY [TradeRelation_Code] ", sqlconn);
                } else if (userName.Equals("FISOGEST\\abartholme"))
                {
                    sqlcmd = new SqlCommand("SELECT TradeRelation_Code,[TradeRelation_Code]+' - '+[CustomerName_T] AS Customer FROM [FisoDWH].[dbo].[Customers] WHERE TradeRelation_Code IN ('FRE001','FRE005','TAN001','ZOE001','TOM001','SPO002','FRE008') ORDER BY [TradeRelation_Code] ", sqlconn);
                }
                else
                {
                    sqlcmd = new SqlCommand("SELECT TradeRelation_Code,[TradeRelation_Code]+' - '+[CustomerName_T] AS Customer FROM [FisoDWH].[dbo].[Customers] WHERE (TradeRelation_Code IN (" + dossiers + ") OR TradeRelation_Code IN ('FRE005','FRE008')) AND TradeRelation_Code NOT IN ('3AC001','3AP001','AAS001','BAR002','DEL001','FIS001','KAH001','KAH002','KLA003','MGI001','HAN006','PSI001','RUB001','SHI003','SOC007','TAN002','TRA002') ORDER BY [TradeRelation_Code] ", sqlconn);
                }
                SqlDataReader reader;
                reader = sqlcmd.ExecuteReader();
                
                while(reader.Read())
                {
                    cB_Customer.Items.Add(reader[1]);
                }
                
                /*
                dt.Columns.Add("TradeRelation_Code", typeof(string));
                dt.Columns.Add("Customer", typeof(string));
                dt.Load(reader);

                cB_Customer.ValueMember = "TradeRelation_Code";
                cB_Customer.DisplayMember = "Customer";
                cB_Customer.DataSource = dt;
                */
                sqlconn.Close();
            }
            catch (AdsException e2)
            {
                MessageBox.Show(e2.Message);
            }

        }


        private void buttonReport_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            string[] admins = { "FISOGEST\\nhansen", "FISOGEST\\preeff" , "FISOGEST\\jhoffmann" ,"FISOGEST\\cbetti","FISOGEST\\shansen" };
            string[] secretdossiers = { "3AC001", "3AP001", "AAS001", "BAR002", "DEL001", "FIS001", "KAH001", "KAH002", "KLA003", "MGI001", "HAN006", "PSI001", "RUB001", "SHI003", "SOC007", "TAN002", "TRA002" };
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            if (admins.Contains(userName) || !secretdossiers.Contains(cB_Customer.Text.Substring(0, 6)) || (userName.Equals("FISOGEST\\slizardo") && (cB_Customer.Text.Substring(0, 6).Equals("AAS001") || cB_Customer.Text.Substring(0, 6).Equals("3AC001"))))
            {

                Cursor.Current = Cursors.WaitCursor;

                if (cB_Customer.Text.Substring(0, 6).ToUpper() == "FRE001"
                    || cB_Customer.Text.Substring(0, 6).ToUpper() == "FRE005"
                    || cB_Customer.Text.Substring(0, 6).ToUpper() == "TAN001"
                    || cB_Customer.Text.Substring(0, 6).ToUpper() == "ZOE001"
                    || cB_Customer.Text.Substring(0, 6).ToUpper() == "TOM001"
                    || cB_Customer.Text.Substring(0, 6).ToUpper() == "SPO002"
                    || cB_Customer.Text.Substring(0, 6).ToUpper() == "FRE008"
                    || cB_Customer.Text.Substring(0, 6).ToUpper() == "LDI001"
                    || cB_Customer.Text.Substring(0, 6).ToUpper() == "DEC002"
                    //|| cB_Customer.Text.Substring(0, 6).ToUpper() == "ING001"
                    )
                {

                }
                else
                {
                    this.label4.Text = "Loading BOB50 data ...";
                    panel1.Show();
                    panel1.Refresh();
                    get_ac_accoun(cB_Customer.Text.Substring(0, 6));
                    upd_Account_Labels(cB_Customer.Text.Substring(0, 6));
                    getData(cB_Customer.Text.Substring(0, 6),dP_period2Start.Value.Year,dP_periodEnd.Value.Year);
                    getLabelData(cB_Customer.Text.Substring(0, 6));
                    panel1.Hide();
                }

                checkBalance();
                reportViewer1.ProcessingMode = ProcessingMode.Remote;
                ServerReport serverReport = reportViewer1.ServerReport;
                System.Net.ICredentials credentials = new NetworkCredential("Administrateur", "F!so2013", "FISOGEST");
                ReportServerCredentials rsCredentials = serverReport.ReportServerCredentials;
                rsCredentials.NetworkCredentials = credentials;
                serverReport.ReportServerUrl = new Uri("http://srvsql/reportserver");
                //serverReport.ReportPath = "/Bilan 2016/" + cB_Bilan.Text.ToString();
                //serverReport.ReportPath = "/Bilan 2016/Bilan2016vConso";
                
                if (userName.Equals("FISOGEST\\abartholme"))
                {
                    serverReport.ReportPath = "/Bilan 2016/Bilan2016vFreelanders";
                }
                else
                {
                    serverReport.ReportPath = "/Bilan 2016/Bilan2016v4";
                }
                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("Customer_Code", cB_Customer.Text.Substring(0, 6)));
                //parameters.Add(new ReportParameter("Year", dP_periodStart.Value.Year.ToString()));
                parameters.Add(new ReportParameter("Period1Start", dP_periodStart.Value.Date.ToString()));
                parameters.Add(new ReportParameter("Period1End", dP_periodEnd.Value.Date.ToString()));
                parameters.Add(new ReportParameter("Period2Start", dP_period2Start.Value.Date.ToString()));
                parameters.Add(new ReportParameter("Period2End", dP_period2End.Value.Date.ToString()));
                /*
                if (cB_Bilan.Text.Contains("FR")) parameters.Add(new ReportParameter("Language", "FR"));
                if (cB_Bilan.Text.Contains("DE")) parameters.Add(new ReportParameter("Language", "DE"));
                if (cB_Bilan.Text.Contains("EN")) parameters.Add(new ReportParameter("Language", "EN"));
                */
                if (radioFR.Checked) parameters.Add(new ReportParameter("Language", "FR"));
                if (radioDE.Checked) parameters.Add(new ReportParameter("Language", "DE"));
                if (radioEN.Checked) parameters.Add(new ReportParameter("Language", "EN"));
                if (checkBoxSituationInt.Checked) {
                    parameters.Add(new ReportParameter("SituationIntermédiaire", "true"));
                } else
                {
                    parameters.Add(new ReportParameter("SituationIntermédiaire", "false"));
                }

                /*
                if (chkPeriode.Checked)
                {
                    parameters.Add(new ReportParameter("Max_Month", dP_periodEnd.Value.Month.ToString() ));
                } else
                {
                    parameters.Add(new ReportParameter("Max_Month", "12" ));
                }
                */
                reportViewer1.ServerReport.SetParameters(parameters);
                reportViewer1.ShowParameterPrompts = false;
                reportViewer1.ShowPromptAreaButton = false;
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                // Set the report parameters for the report  
                //reportViewer1.ServerReport.SetParameters(parameters);
                //    new ReportParameter[] { customerCode,periodStart,periodEnd });

                // Refresh the report  
                reportViewer1.Refresh();
                Cursor.Current = Cursors.AppStarting;
            } else
            {
                MessageBox.Show("Dossier non valide!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SendMail(ReportViewer reportViewer)
        {
            string email;

            email = ShowMyDialogBox();

            if (!email.Equals(""))
            {

                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = reportViewer.ServerReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                MemoryStream memoryStream = new MemoryStream(bytes);
                memoryStream.Seek(0, SeekOrigin.Begin);

                MailMessage message = new MailMessage();
                Attachment attachment = new Attachment(memoryStream, "Bilan.pdf");
                message.Attachments.Add(attachment);

                message.From = new MailAddress("info@fisogest.lu");

                message.To.Add(email);

                //message.CC.Add("jhoffmann@fisogest.lu");

                message.Subject = "Bilan";
                message.IsBodyHtml = true;

                message.Body = "Veuillez trouvez en annexe le bilan demandé.";


                SmtpClient smtp = new SmtpClient("192.168.5.225");
                smtp.Send(message);


                memoryStream.Close();
                memoryStream.Dispose();
                MessageBox.Show("Bilan envoyé!");
            } else
            {
                MessageBox.Show("Adresse Email non valide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.label4.Text = "Loading Book-In (30sec) ...";
            panel1.Show();
            panel1.Refresh();
            loadSSIS();
            System.Threading.Thread.Sleep(30000);
            panel1.Hide();
            Cursor.Current = Cursors.AppStarting;
        }

        private void checkBalance()
        {
            //SqlConnection sqlconn = new SqlConnection("Data Source=srvdwh;Initial Catalog=FisoDWH;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            SqlConnection sqlconn = new SqlConnection("Data Source=SRVSQL\\FISODWH;Initial Catalog=FisoDWH;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            sqlconn.Open();
            int period;
            period = dP_periodEnd.Value.Year * 100 + dP_periodEnd.Value.Month;
            SqlCommand sqlcmd = new SqlCommand("SELECT SUM(Amount) FROM [dbo].[Account_Balance] WHERE Customer_Code = '"+ cB_Customer.Text.Substring(0, 6) + "' AND Year*100+Month BETWEEN (ROUND("+period.ToString()+"/100, 0, 1)-1)*100 AND "+ period.ToString(), sqlconn);
            try
            {
                decimal balance = (decimal)sqlcmd.ExecuteScalar();
                if (balance.Equals(0) == false) MessageBox.Show("Balance :" + balance.ToString(), "Erreur balance!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch
            { }

        }

        private void Amortissement_Click(object sender, EventArgs e)
        {
            Bilan2016.Amortissements amort = new Bilan2016.Amortissements();
            amort.Show();

        }



        private void dP_periodStart_ValueChanged(object sender, EventArgs e)
        {
            this.dP_period2Start.Value = new System.DateTime(dP_periodStart.Value.Year - 1, dP_periodStart.Value.Month, dP_periodStart.Value.Day);
            
        }

        private void dP_periodEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dP_period2End.Value = new System.DateTime(dP_periodEnd.Value.Year - 1, dP_periodEnd.Value.Month, dP_periodEnd.Value.Day);
        }

        private void bookInFreelandersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.label4.Text = "Loading Book-In (30sec) ...";
            panel1.Show();
            panel1.Refresh();
            loadSSIS();
            System.Threading.Thread.Sleep(30000);
            panel1.Hide();
            Cursor.Current = Cursors.AppStarting;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Annexes_Legales_Click(object sender, EventArgs e)
        {
            Bilan2016.Annexes ann = new Bilan2016.Annexes(cB_Customer.Text, dP_periodEnd.Value.Year);
            ann.ShowDialog();
        }

        private void bookInDeCockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.label4.Text = "Loading Book-In (30sec) ...";
            panel1.Show();
            panel1.Refresh();
            loadSSIS_DEC002();
            System.Threading.Thread.Sleep(30000);
            panel1.Hide();
            Cursor.Current = Cursors.AppStarting;
        }

        private void comboKeyPressed()
        {
            cB_Customer.DroppedDown = true;

  
            object[] originalList = (object[])cB_Customer.Tag;
            if (originalList == null)
            {
                // backup original list
                originalList = new object[cB_Customer.Items.Count];
                cB_Customer.Items.CopyTo(originalList, 0);
                cB_Customer.Tag = originalList;
            }

            // prepare list of matching items
            string s = cB_Customer.Text.ToLower();
            IEnumerable<object> newList = originalList;
            if (s.Length > 0)
            {
                newList = originalList.Where(item => item.ToString().ToLower().Contains(s));
            }

            // clear list (loop through it, otherwise the cursor would move to the beginning of the textbox...)
            while (cB_Customer.Items.Count > 0)
            {
                cB_Customer.Items.RemoveAt(0);
            }

            // re-set list
            cB_Customer.Items.AddRange(newList.ToArray());
            
        }

        private void cB_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
                    
            if (e.KeyChar == (char)(13))
            {
                if (cB_Customer.SelectedIndex==-1 && cB_Customer.Items.Count > 0)
                {
                    cB_Customer.Text = cB_Customer.Items[0].ToString();
                } else
                {
                    cB_Customer.Text = cB_Customer.SelectedItem.ToString();
                }
            } else {
                comboKeyPressed();
            }
            
        }

        private void cB_Customer_TextChanged(object sender, EventArgs e)
        {
            if (cB_Customer.Text.Length == 0) comboKeyPressed();

        }

        private void versPressepapierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdsConnection adsconn = new AdsConnection("Data Source=\\\\192.168.5.5:6262\\bob50\\BOB50DATA\\" + cB_Customer.Text.Substring(0, 6) + ";ServerType=REMOTE;TableType=ADT;LockMode=PROPRIETARY;CharType=ADS_ANSI;SecurityMode=IGNORERIGHTS");
            AdsCommand adscmd;
            AdsDataReader adsreader;

            adsconn.Open();
            adscmd = adsconn.CreateCommand();
            //adscmd.CommandText = "SELECT HDOCDATE,CASE WHEN HID IN ('40110000') THEN 'C' WHEN HID IN ('44111000 ') THEN 'F' ELSE 'G' END AS Type, CASE WHEN HID IN ('40110000','44111000 ') THEN 'DIVERS' ELSE HID END AS HID, HAMOUNT * -1 AS HAMOUNT, 'Annulation '+RTRIM(HREM) AS HREM FROM ac_ahisto WHERE HDOCDATE BETWEEN '" + dP_periodStart.Value.Date.ToString("yyyy-MM-dd")  + "' AND '"+ dP_periodEnd.Value.Date.ToString("yyyy-MM-dd")+"'";
            adscmd.CommandText = "SELECT '31/12/'+CAST(YEAR(HDOCDATE) AS SQL_CHAR(4))+' 00:00:00' AS BOBDATE,CASE WHEN HID IN ('40110000') THEN 'C' WHEN HID IN ('44111000 ') THEN 'F' ELSE 'G' END AS TYPE, CASE WHEN HID IN ('40110000','44111000 ') THEN 'DIVERS' ELSE HID END AS ACCOUNT, SUM(HAMOUNT * -1) AS HAMOUNT, 'Annulation '+RTRIM(HREM) AS COMMENT FROM ac_ahisto WHERE HDOCDATE BETWEEN '" + dP_periodStart.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + dP_periodEnd.Value.Date.ToString("yyyy-MM-dd") + "' GROUP BY BOBDATE,Type,ACCOUNT,COMMENT";

            String clipbString;
            clipbString = "";
            adsreader = adscmd.ExecuteReader();
            while (adsreader.Read() )
            {
                clipbString += adsreader.GetValue(0) + "\t" + adsreader.GetValue(1) + "\t" + adsreader.GetValue(2) + "\t" + adsreader.GetValue(3) + "\t" + adsreader.GetValue(4) + "\n";
            }
            adsconn.Close();
            AdsConnection.FlushConnectionPool();
            SqlConnection sqlconn = new SqlConnection("Data Source=SRVSQL\\FISODWH;Initial Catalog=FisoDWH;User ID=dwh_writer;Password=GZXyJmTdKNfx7C4j;");
            sqlconn.Open();
            int periodEnd;
            int periodStart;
            periodStart = dP_periodStart.Value.Year * 100 + dP_periodStart.Value.Month;
            periodEnd = dP_periodEnd.Value.Year * 100 + dP_periodEnd.Value.Month;
            SqlCommand sqlcmd = new SqlCommand("SELECT DATEFROMPARTS(Year,12,31) AS Date, CASE WHEN Account IN ('40110000') THEN 'C' WHEN Account IN ('44111000 ') THEN 'F' ELSE 'G' END AS Type, CASE WHEN Account IN ('40110000','44111000 ') THEN 'DIVERS' ELSE Account END AS Account, SUM(Amount) AS Amount, 'Importation du '+ FORMAT(GETDATE(),'dd/MM/yyyy','fr-fr') AS Comment FROM [dbo].[Account_Balance] WHERE Customer_Code = '" + cB_Customer.Text.Substring(0, 6) + "' AND Year*100+Month BETWEEN " + periodStart.ToString() + " AND " + periodEnd.ToString() + "GROUP BY DATEFROMPARTS([Year],12, 31), Account ORDER BY Account", sqlconn);
            
            try
            {
                var reader = sqlcmd.ExecuteReader();
                while (reader.Read() )
                {
                    clipbString += reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3) + "\t" + reader.GetValue(4) + "\n";
                }
                Clipboard.SetText(clipbString.ToString());
            }
            catch
            { }
            sqlconn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SendMail(reportViewer1);
        }

        private void bookInIngeniumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.label4.Text = "Loading Book-In (30sec) ...";
            panel1.Show();
            panel1.Refresh();
            loadSSIS_ING001();
            System.Threading.Thread.Sleep(30000);
            panel1.Hide();
            Cursor.Current = Cursors.AppStarting;
        }
    }
}
