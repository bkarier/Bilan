namespace Bilan2016
{
    partial class Amortissements
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VNCdebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acquisitions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ventes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amortissement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VNCfin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btPaste = new System.Windows.Forms.Button();
            this.btRecalc = new System.Windows.Forms.Button();
            this.tBdossier = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataTableAmortLevel1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fisoDWHDataSet2 = new Bilan2016.FisoDWHDataSet();
            this.annualAccountsLabelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataTableAmortLevel2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fisoDWHDataSet = new Bilan2016.FisoDWHDataSet();
            this.dataTableAmortLevel1TableAdapter = new Bilan2016.FisoDWHDataSetTableAdapters.DataTableAmortLevel1TableAdapter();
            this.dataTableAmortLevel2TableAdapter = new Bilan2016.FisoDWHDataSetTableAdapters.DataTableAmortLevel2TableAdapter();
            this.tBYear = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fisoDWHDataSet1 = new Bilan2016.FisoDWHDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAmortLevel1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisoDWHDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualAccountsLabelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAmortLevel2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisoDWHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisoDWHDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Designation,
            this.Date,
            this.Valeur,
            this.Taux,
            this.VNCdebut,
            this.Acquisitions,
            this.Ventes,
            this.Amortissement,
            this.VNCfin});
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1180, 315);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Désignation du bien";
            this.Designation.Name = "Designation";
            this.Designation.Width = 300;
            // 
            // Date
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.HeaderText = "Date acquisition";
            this.Date.Name = "Date";
            // 
            // Valeur
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valeur.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valeur.HeaderText = "Valeur à amortir";
            this.Valeur.Name = "Valeur";
            // 
            // Taux
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Taux.DefaultCellStyle = dataGridViewCellStyle3;
            this.Taux.HeaderText = "Taux";
            this.Taux.Name = "Taux";
            // 
            // VNCdebut
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.VNCdebut.DefaultCellStyle = dataGridViewCellStyle4;
            this.VNCdebut.HeaderText = "V.N.C. début";
            this.VNCdebut.Name = "VNCdebut";
            // 
            // Acquisitions
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Acquisitions.DefaultCellStyle = dataGridViewCellStyle5;
            this.Acquisitions.HeaderText = "Acquisitions";
            this.Acquisitions.Name = "Acquisitions";
            // 
            // Ventes
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Ventes.DefaultCellStyle = dataGridViewCellStyle6;
            this.Ventes.HeaderText = "Ventes";
            this.Ventes.Name = "Ventes";
            // 
            // Amortissement
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Amortissement.DefaultCellStyle = dataGridViewCellStyle7;
            this.Amortissement.HeaderText = "Amortissement";
            this.Amortissement.Name = "Amortissement";
            // 
            // VNCfin
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.VNCfin.DefaultCellStyle = dataGridViewCellStyle8;
            this.VNCfin.HeaderText = "V.N.C. fin";
            this.VNCfin.Name = "VNCfin";
            // 
            // btPaste
            // 
            this.btPaste.Location = new System.Drawing.Point(13, 104);
            this.btPaste.Name = "btPaste";
            this.btPaste.Size = new System.Drawing.Size(126, 23);
            this.btPaste.TabIndex = 1;
            this.btPaste.Text = "Paste from Excel";
            this.btPaste.UseVisualStyleBackColor = true;
            this.btPaste.Click += new System.EventHandler(this.btPaste_Click);
            // 
            // btRecalc
            // 
            this.btRecalc.Location = new System.Drawing.Point(146, 104);
            this.btRecalc.Name = "btRecalc";
            this.btRecalc.Size = new System.Drawing.Size(109, 23);
            this.btRecalc.TabIndex = 2;
            this.btRecalc.Text = "Recalculer";
            this.btRecalc.UseVisualStyleBackColor = true;
            this.btRecalc.Click += new System.EventHandler(this.btRecalc_Click);
            // 
            // tBdossier
            // 
            this.tBdossier.Location = new System.Drawing.Point(13, 13);
            this.tBdossier.Name = "tBdossier";
            this.tBdossier.Size = new System.Drawing.Size(100, 20);
            this.tBdossier.TabIndex = 3;
            this.tBdossier.Text = "ANT001";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataTableAmortLevel1BindingSource;
            this.comboBox1.DisplayMember = "Label";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Code";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Combo_Level1_Change);
            // 
            // dataTableAmortLevel1BindingSource
            // 
            this.dataTableAmortLevel1BindingSource.DataMember = "DataTableAmortLevel1";
            this.dataTableAmortLevel1BindingSource.DataSource = this.fisoDWHDataSet2;
            // 
            // fisoDWHDataSet2
            // 
            this.fisoDWHDataSet2.DataSetName = "FisoDWHDataSet";
            this.fisoDWHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // annualAccountsLabelsBindingSource
            // 
            this.annualAccountsLabelsBindingSource.DataMember = "Annual_Accounts_Labels";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.DataSource = this.dataTableAmortLevel2BindingSource;
            this.comboBox2.DisplayMember = "Label";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(364, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(335, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "Code";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.Combo_Level2_Change);
            // 
            // dataTableAmortLevel2BindingSource
            // 
            this.dataTableAmortLevel2BindingSource.DataMember = "DataTableAmortLevel2";
            this.dataTableAmortLevel2BindingSource.DataSource = this.fisoDWHDataSet2;
            // 
            // fisoDWHDataSet
            // 
            this.fisoDWHDataSet.DataSetName = "FisoDWHDataSet";
            this.fisoDWHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableAmortLevel1TableAdapter
            // 
            this.dataTableAmortLevel1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTableAmortLevel2TableAdapter
            // 
            this.dataTableAmortLevel2TableAdapter.ClearBeforeFill = true;
            // 
            // tBYear
            // 
            this.tBYear.Location = new System.Drawing.Point(120, 13);
            this.tBYear.Name = "tBYear";
            this.tBYear.Size = new System.Drawing.Size(100, 20);
            this.tBYear.TabIndex = 6;
            this.tBYear.Text = "2015";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 463);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Sauvegarder";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fisoDWHDataSet1
            // 
            this.fisoDWHDataSet1.DataSetName = "FisoDWHDataSet";
            this.fisoDWHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Amortissements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tBYear);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tBdossier);
            this.Controls.Add(this.btRecalc);
            this.Controls.Add(this.btPaste);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Amortissements";
            this.Text = "Amortissements";
            this.Load += new System.EventHandler(this.Amortissements_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAmortLevel1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisoDWHDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualAccountsLabelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAmortLevel2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisoDWHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisoDWHDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btPaste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taux;
        private System.Windows.Forms.DataGridViewTextBoxColumn VNCdebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acquisitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ventes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amortissement;
        private System.Windows.Forms.DataGridViewTextBoxColumn VNCfin;
        private System.Windows.Forms.Button btRecalc;
        private System.Windows.Forms.TextBox tBdossier;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private FisoDWHDataSet fisoDWHDataSet;
        private System.Windows.Forms.BindingSource annualAccountsLabelsBindingSource;
        private FisoDWHDataSet fisoDWHDataSet2;
        private System.Windows.Forms.BindingSource dataTableAmortLevel1BindingSource;
        private FisoDWHDataSetTableAdapters.DataTableAmortLevel1TableAdapter dataTableAmortLevel1TableAdapter;
        private System.Windows.Forms.BindingSource dataTableAmortLevel2BindingSource;
        private FisoDWHDataSetTableAdapters.DataTableAmortLevel2TableAdapter dataTableAmortLevel2TableAdapter;
        private System.Windows.Forms.TextBox tBYear;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button button1;
        private FisoDWHDataSet fisoDWHDataSet1;
    }
}