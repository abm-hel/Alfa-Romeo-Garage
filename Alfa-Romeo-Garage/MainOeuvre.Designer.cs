
namespace Alfa_Romeo_Garage
{
    partial class FormMainOeuvre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridviewV = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entretien = new System.Windows.Forms.Label();
            this.labelIntervention = new System.Windows.Forms.Label();
            this.comboBoxEntretien = new System.Windows.Forms.ComboBox();
            this.comboBoxIntervention = new System.Windows.Forms.ComboBox();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonEditer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridviewV
            // 
            this.dataGridviewV.AllowUserToAddRows = false;
            this.dataGridviewV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridviewV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridviewV.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridviewV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridviewV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridviewV.ColumnHeadersHeight = 29;
            this.dataGridviewV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cDescription,
            this.cVehicule,
            this.cDate,
            this.cPrix,
            this.tva});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridviewV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridviewV.GridColor = System.Drawing.Color.White;
            this.dataGridviewV.Location = new System.Drawing.Point(540, 45);
            this.dataGridviewV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridviewV.Name = "dataGridviewV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridviewV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridviewV.RowHeadersVisible = false;
            this.dataGridviewV.RowHeadersWidth = 51;
            this.dataGridviewV.RowTemplate.Height = 24;
            this.dataGridviewV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridviewV.Size = new System.Drawing.Size(644, 690);
            this.dataGridviewV.TabIndex = 49;
            this.dataGridviewV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridviewV_CellContentClick);
            // 
            // cID
            // 
            this.cID.DataPropertyName = "id";
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 50;
            // 
            // cDescription
            // 
            this.cDescription.DataPropertyName = "description";
            this.cDescription.HeaderText = "Description";
            this.cDescription.MinimumWidth = 6;
            this.cDescription.Name = "cDescription";
            this.cDescription.ReadOnly = true;
            this.cDescription.Width = 125;
            // 
            // cVehicule
            // 
            this.cVehicule.DataPropertyName = "vehicule";
            this.cVehicule.HeaderText = "Vehicule";
            this.cVehicule.MinimumWidth = 6;
            this.cVehicule.Name = "cVehicule";
            this.cVehicule.ReadOnly = true;
            this.cVehicule.Width = 125;
            // 
            // cDate
            // 
            this.cDate.DataPropertyName = "date";
            this.cDate.HeaderText = "Date";
            this.cDate.MinimumWidth = 6;
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 150;
            // 
            // cPrix
            // 
            this.cPrix.DataPropertyName = "prix";
            this.cPrix.HeaderText = "Prix";
            this.cPrix.MinimumWidth = 6;
            this.cPrix.Name = "cPrix";
            this.cPrix.ReadOnly = true;
            this.cPrix.Width = 180;
            // 
            // tva
            // 
            this.tva.DataPropertyName = "tva";
            this.tva.HeaderText = "TVA";
            this.tva.MinimumWidth = 6;
            this.tva.Name = "tva";
            this.tva.ReadOnly = true;
            this.tva.Width = 125;
            // 
            // Entretien
            // 
            this.Entretien.AutoSize = true;
            this.Entretien.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entretien.ForeColor = System.Drawing.Color.Crimson;
            this.Entretien.Location = new System.Drawing.Point(27, 84);
            this.Entretien.Name = "Entretien";
            this.Entretien.Size = new System.Drawing.Size(70, 19);
            this.Entretien.TabIndex = 77;
            this.Entretien.Text = "Entretien";
            this.Entretien.Click += new System.EventHandler(this.Entretien_Click);
            // 
            // labelIntervention
            // 
            this.labelIntervention.AutoSize = true;
            this.labelIntervention.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntervention.ForeColor = System.Drawing.Color.Crimson;
            this.labelIntervention.Location = new System.Drawing.Point(27, 22);
            this.labelIntervention.Name = "labelIntervention";
            this.labelIntervention.Size = new System.Drawing.Size(91, 19);
            this.labelIntervention.TabIndex = 76;
            this.labelIntervention.Text = "Intervention";
            this.labelIntervention.Click += new System.EventHandler(this.labelIntervention_Click);
            // 
            // comboBoxEntretien
            // 
            this.comboBoxEntretien.BackColor = System.Drawing.Color.Black;
            this.comboBoxEntretien.ForeColor = System.Drawing.Color.White;
            this.comboBoxEntretien.FormattingEnabled = true;
            this.comboBoxEntretien.Location = new System.Drawing.Point(28, 107);
            this.comboBoxEntretien.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEntretien.Name = "comboBoxEntretien";
            this.comboBoxEntretien.Size = new System.Drawing.Size(473, 24);
            this.comboBoxEntretien.TabIndex = 75;
            this.comboBoxEntretien.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntretien_SelectedIndexChanged);
            // 
            // comboBoxIntervention
            // 
            this.comboBoxIntervention.BackColor = System.Drawing.Color.Black;
            this.comboBoxIntervention.ForeColor = System.Drawing.Color.White;
            this.comboBoxIntervention.FormattingEnabled = true;
            this.comboBoxIntervention.Location = new System.Drawing.Point(28, 45);
            this.comboBoxIntervention.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIntervention.Name = "comboBoxIntervention";
            this.comboBoxIntervention.Size = new System.Drawing.Size(473, 24);
            this.comboBoxIntervention.TabIndex = 74;
            this.comboBoxIntervention.SelectedIndexChanged += new System.EventHandler(this.comboBoxIntervention_SelectedIndexChanged);
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.BackColor = System.Drawing.Color.Crimson;
            this.buttonConfirmer.FlatAppearance.BorderSize = 0;
            this.buttonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmer.Location = new System.Drawing.Point(28, 536);
            this.buttonConfirmer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(452, 39);
            this.buttonConfirmer.TabIndex = 117;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = false;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Crimson;
            this.buttonAnnuler.FlatAppearance.BorderSize = 0;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(28, 481);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(452, 39);
            this.buttonAnnuler.TabIndex = 116;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonEditer
            // 
            this.buttonEditer.BackColor = System.Drawing.Color.Crimson;
            this.buttonEditer.FlatAppearance.BorderSize = 0;
            this.buttonEditer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditer.Location = new System.Drawing.Point(29, 643);
            this.buttonEditer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditer.Name = "buttonEditer";
            this.buttonEditer.Size = new System.Drawing.Size(452, 39);
            this.buttonEditer.TabIndex = 115;
            this.buttonEditer.Text = "Editer une pièce";
            this.buttonEditer.UseVisualStyleBackColor = false;
            this.buttonEditer.Click += new System.EventHandler(this.buttonEditer_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.Crimson;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouter.Location = new System.Drawing.Point(29, 590);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(452, 39);
            this.buttonAjouter.TabIndex = 114;
            this.buttonAjouter.Text = "Ajouter une pièce";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Crimson;
            this.buttonSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimer.Location = new System.Drawing.Point(29, 697);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(452, 39);
            this.buttonSupprimer.TabIndex = 113;
            this.buttonSupprimer.Text = "Supprimer un modèle";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // FormMainOeuvre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1210, 795);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonEditer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.Entretien);
            this.Controls.Add(this.labelIntervention);
            this.Controls.Add(this.comboBoxEntretien);
            this.Controls.Add(this.comboBoxIntervention);
            this.Controls.Add(this.dataGridviewV);
            this.Name = "FormMainOeuvre";
            this.Text = "MainOeuvre";
            this.Load += new System.EventHandler(this.FormMainOeuvre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridviewV;
        private System.Windows.Forms.Label Entretien;
        private System.Windows.Forms.Label labelIntervention;
        private System.Windows.Forms.ComboBox comboBoxEntretien;
        private System.Windows.Forms.ComboBox comboBoxIntervention;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn tva;
    }
}