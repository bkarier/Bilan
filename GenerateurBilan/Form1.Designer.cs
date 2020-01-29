using System.Drawing;
using System.Windows.Forms;

namespace QuickBOBload
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dP_periodStart = new System.Windows.Forms.DateTimePicker();
            this.dP_periodEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_Customer = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dP_period2Start = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dP_period2End = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioEN = new System.Windows.Forms.RadioButton();
            this.radioDE = new System.Windows.Forms.RadioButton();
            this.radioFR = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInFreelandersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInDeCockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInIngeniumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versPressepapierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxSituationInt = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Location = new System.Drawing.Point(11, 130);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.Size = new System.Drawing.Size(1314, 442);
            this.reportViewer1.TabIndex = 5;
            // 
            // dP_periodStart
            // 
            this.dP_periodStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dP_periodStart.Location = new System.Drawing.Point(34, 21);
            this.dP_periodStart.Margin = new System.Windows.Forms.Padding(2);
            this.dP_periodStart.Name = "dP_periodStart";
            this.dP_periodStart.Size = new System.Drawing.Size(195, 20);
            this.dP_periodStart.TabIndex = 2;
            this.dP_periodStart.ValueChanged += new System.EventHandler(this.dP_periodStart_ValueChanged);
            // 
            // dP_periodEnd
            // 
            this.dP_periodEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dP_periodEnd.Location = new System.Drawing.Point(34, 49);
            this.dP_periodEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dP_periodEnd.Name = "dP_periodEnd";
            this.dP_periodEnd.Size = new System.Drawing.Size(195, 20);
            this.dP_periodEnd.TabIndex = 3;
            this.dP_periodEnd.ValueChanged += new System.EventHandler(this.dP_periodEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "du";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "au";
            // 
            // cB_Customer
            // 
            this.cB_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cB_Customer.Location = new System.Drawing.Point(6, 21);
            this.cB_Customer.Name = "cB_Customer";
            this.cB_Customer.Size = new System.Drawing.Size(373, 21);
            this.cB_Customer.TabIndex = 1;
            this.cB_Customer.TextChanged += new System.EventHandler(this.cB_Customer_TextChanged);
            this.cB_Customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cB_Customer_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(489, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 98);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loading BOB50 data ...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dP_periodStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dP_periodEnd);
            this.groupBox1.Location = new System.Drawing.Point(402, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 83);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Période N";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dP_period2Start);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dP_period2End);
            this.groupBox2.Location = new System.Drawing.Point(649, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 83);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Période N-1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "du";
            // 
            // dP_period2Start
            // 
            this.dP_period2Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dP_period2Start.Location = new System.Drawing.Point(34, 21);
            this.dP_period2Start.Margin = new System.Windows.Forms.Padding(2);
            this.dP_period2Start.Name = "dP_period2Start";
            this.dP_period2Start.Size = new System.Drawing.Size(195, 20);
            this.dP_period2Start.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "au";
            // 
            // dP_period2End
            // 
            this.dP_period2End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dP_period2End.Location = new System.Drawing.Point(34, 49);
            this.dP_period2End.Margin = new System.Windows.Forms.Padding(2);
            this.dP_period2End.Name = "dP_period2End";
            this.dP_period2End.Size = new System.Drawing.Size(195, 20);
            this.dP_period2End.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioEN);
            this.groupBox3.Controls.Add(this.radioDE);
            this.groupBox3.Controls.Add(this.radioFR);
            this.groupBox3.Location = new System.Drawing.Point(896, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 83);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Langue";
            // 
            // radioEN
            // 
            this.radioEN.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioEN.AutoSize = true;
            this.radioEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioEN.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioEN.Image = global::Bilan2016.Properties.Resources.EN;
            this.radioEN.Location = new System.Drawing.Point(118, 25);
            this.radioEN.Name = "radioEN";
            this.radioEN.Size = new System.Drawing.Size(56, 37);
            this.radioEN.TabIndex = 8;
            this.radioEN.TabStop = true;
            this.radioEN.UseVisualStyleBackColor = true;
            // 
            // radioDE
            // 
            this.radioDE.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioDE.AutoSize = true;
            this.radioDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioDE.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioDE.Image = global::Bilan2016.Properties.Resources.DE;
            this.radioDE.Location = new System.Drawing.Point(62, 25);
            this.radioDE.Name = "radioDE";
            this.radioDE.Size = new System.Drawing.Size(56, 37);
            this.radioDE.TabIndex = 7;
            this.radioDE.TabStop = true;
            this.radioDE.UseVisualStyleBackColor = true;
            // 
            // radioFR
            // 
            this.radioFR.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFR.AutoSize = true;
            this.radioFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioFR.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioFR.Image = global::Bilan2016.Properties.Resources.FR1;
            this.radioFR.Location = new System.Drawing.Point(6, 25);
            this.radioFR.Name = "radioFR";
            this.radioFR.Size = new System.Drawing.Size(56, 37);
            this.radioFR.TabIndex = 6;
            this.radioFR.TabStop = true;
            this.radioFR.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.importerToolStripMenuItem,
            this.exporterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1332, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookInFreelandersToolStripMenuItem,
            this.bookInDeCockToolStripMenuItem,
            this.bookInIngeniumToolStripMenuItem});
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.importerToolStripMenuItem.Text = "Importer";
            // 
            // bookInFreelandersToolStripMenuItem
            // 
            this.bookInFreelandersToolStripMenuItem.Name = "bookInFreelandersToolStripMenuItem";
            this.bookInFreelandersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookInFreelandersToolStripMenuItem.Text = "Book-In Freelanders";
            this.bookInFreelandersToolStripMenuItem.Click += new System.EventHandler(this.bookInFreelandersToolStripMenuItem_Click);
            // 
            // bookInDeCockToolStripMenuItem
            // 
            this.bookInDeCockToolStripMenuItem.Name = "bookInDeCockToolStripMenuItem";
            this.bookInDeCockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookInDeCockToolStripMenuItem.Text = "Book-In De Cock";
            this.bookInDeCockToolStripMenuItem.Click += new System.EventHandler(this.bookInDeCockToolStripMenuItem_Click);
            // 
            // bookInIngeniumToolStripMenuItem
            // 
            this.bookInIngeniumToolStripMenuItem.Name = "bookInIngeniumToolStripMenuItem";
            this.bookInIngeniumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookInIngeniumToolStripMenuItem.Text = "Book-In Ingenium";
            this.bookInIngeniumToolStripMenuItem.Click += new System.EventHandler(this.bookInIngeniumToolStripMenuItem_Click);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versPressepapierToolStripMenuItem});
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.exporterToolStripMenuItem.Text = "Exporter";
            // 
            // versPressepapierToolStripMenuItem
            // 
            this.versPressepapierToolStripMenuItem.Name = "versPressepapierToolStripMenuItem";
            this.versPressepapierToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.versPressepapierToolStripMenuItem.Text = "Vers presse-papiers Bob";
            this.versPressepapierToolStripMenuItem.Click += new System.EventHandler(this.versPressepapierToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxSituationInt);
            this.groupBox4.Controls.Add(this.cB_Customer);
            this.groupBox4.Location = new System.Drawing.Point(11, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 83);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dossier";
            // 
            // checkBoxSituationInt
            // 
            this.checkBoxSituationInt.AutoSize = true;
            this.checkBoxSituationInt.Location = new System.Drawing.Point(7, 53);
            this.checkBoxSituationInt.Name = "checkBoxSituationInt";
            this.checkBoxSituationInt.Size = new System.Drawing.Size(129, 17);
            this.checkBoxSituationInt.TabIndex = 2;
            this.checkBoxSituationInt.Text = "Situation intermédiaire";
            this.checkBoxSituationInt.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonReport);
            this.groupBox5.Location = new System.Drawing.Point(1082, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(81, 83);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exécuter";
            // 
            // buttonReport
            // 
            this.buttonReport.Image = global::Bilan2016.Properties.Resources.Run_48x;
            this.buttonReport.Location = new System.Drawing.Point(5, 18);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(68, 60);
            this.buttonReport.TabIndex = 9;
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(1169, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(81, 83);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "E-Mail";
            // 
            // button1
            // 
            this.button1.Image = global::Bilan2016.Properties.Resources.mail2;
            this.button1.Location = new System.Drawing.Point(5, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 60);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 587);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Bilan2016";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.DateTimePicker dP_periodStart;
        private System.Windows.Forms.DateTimePicker dP_periodEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_Customer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private DateTimePicker dP_period2Start;
        private Label label6;
        private DateTimePicker dP_period2End;
        private GroupBox groupBox3;
        private RadioButton radioFR;
        private RadioButton radioDE;
        private RadioButton radioEN;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem importerToolStripMenuItem;
        private ToolStripMenuItem bookInFreelandersToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private ToolStripMenuItem bookInDeCockToolStripMenuItem;
        private ToolStripMenuItem exporterToolStripMenuItem;
        private ToolStripMenuItem versPressepapierToolStripMenuItem;
        private Button button1;
        private GroupBox groupBox6;
        private ToolStripMenuItem bookInIngeniumToolStripMenuItem;
        private CheckBox checkBoxSituationInt;
    }
}

