﻿namespace WinForms.Dvorane
{
    partial class uctDodajDvorana
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTeatar = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cmbTeatar = new System.Windows.Forms.ComboBox();
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dgvTipSjedista = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipSjedistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipSjedista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipSjedistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeatar
            // 
            this.lblTeatar.AutoSize = true;
            this.lblTeatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeatar.ForeColor = System.Drawing.Color.White;
            this.lblTeatar.Location = new System.Drawing.Point(278, 91);
            this.lblTeatar.Name = "lblTeatar";
            this.lblTeatar.Size = new System.Drawing.Size(38, 18);
            this.lblTeatar.TabIndex = 47;
            this.lblTeatar.Text = "Spol";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSacuvaj.Location = new System.Drawing.Point(66, 480);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(191, 38);
            this.btnSacuvaj.TabIndex = 46;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // cmbTeatar
            // 
            this.cmbTeatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeatar.FormattingEnabled = true;
            this.cmbTeatar.Location = new System.Drawing.Point(281, 112);
            this.cmbTeatar.Name = "cmbTeatar";
            this.cmbTeatar.Size = new System.Drawing.Size(298, 26);
            this.cmbTeatar.TabIndex = 45;
            this.cmbTeatar.Validating += new System.ComponentModel.CancelEventHandler(this.CmbTeatar_Validating);
            // 
            // txbNaziv
            // 
            this.txbNaziv.BackColor = System.Drawing.Color.White;
            this.txbNaziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNaziv.Location = new System.Drawing.Point(66, 112);
            this.txbNaziv.MaxLength = 100;
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(191, 24);
            this.txbNaziv.TabIndex = 43;
            this.txbNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TxbNaziv_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Dodavanje dvorane";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.White;
            this.lblNaziv.Location = new System.Drawing.Point(63, 91);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(45, 18);
            this.lblNaziv.TabIndex = 44;
            this.lblNaziv.Text = "Naziv";
            // 
            // dgvTipSjedista
            // 
            this.dgvTipSjedista.AllowUserToAddRows = false;
            this.dgvTipSjedista.AllowUserToDeleteRows = false;
            this.dgvTipSjedista.AutoGenerateColumns = false;
            this.dgvTipSjedista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipSjedista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.BrojSjedista});
            this.dgvTipSjedista.DataSource = this.tipSjedistaBindingSource;
            this.dgvTipSjedista.Location = new System.Drawing.Point(72, 173);
            this.dgvTipSjedista.Name = "dgvTipSjedista";
            this.dgvTipSjedista.Size = new System.Drawing.Size(244, 264);
            this.dgvTipSjedista.TabIndex = 48;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Tip sjedista";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BrojSjedista
            // 
            this.BrojSjedista.HeaderText = "Broj sjedista";
            this.BrojSjedista.Name = "BrojSjedista";
            // 
            // tipSjedistaBindingSource
            // 
            this.tipSjedistaBindingSource.DataSource = typeof(DataTransferObjects.TipSjedista);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uctDodajDvorana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTipSjedista);
            this.Controls.Add(this.lblTeatar);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbTeatar);
            this.Controls.Add(this.txbNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaziv);
            this.Name = "uctDodajDvorana";
            this.Size = new System.Drawing.Size(1070, 562);
            this.Load += new System.EventHandler(this.UctDodajDvorana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipSjedista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipSjedistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeatar;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbTeatar;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DataGridView dgvTipSjedista;
        private System.Windows.Forms.BindingSource tipSjedistaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedista;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}