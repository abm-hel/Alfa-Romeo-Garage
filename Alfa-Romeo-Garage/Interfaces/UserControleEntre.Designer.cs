
namespace Alfa_Romeo_Garage.Interfaces
{
    partial class UserControleEntre
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonEditer = new System.Windows.Forms.Button();
            this.dataGridViewE = new System.Windows.Forms.DataGridView();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelVehicule = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxVehicule = new System.Windows.Forms.ComboBox();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerDateEntretien = new CustomControls.RJControls.RJDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewE)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditer
            // 
            this.buttonEditer.BackColor = System.Drawing.Color.Crimson;
            this.buttonEditer.FlatAppearance.BorderSize = 0;
            this.buttonEditer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditer.Location = new System.Drawing.Point(20, 687);
            this.buttonEditer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditer.Name = "buttonEditer";
            this.buttonEditer.Size = new System.Drawing.Size(452, 39);
            this.buttonEditer.TabIndex = 109;
            this.buttonEditer.Text = "Editer un entretien";
            this.buttonEditer.UseVisualStyleBackColor = false;
            this.buttonEditer.Click += new System.EventHandler(this.buttonEditer_Click);
            // 
            // dataGridViewE
            // 
            this.dataGridViewE.AllowUserToAddRows = false;
            this.dataGridViewE.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewE.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewE.ColumnHeadersHeight = 29;
            this.dataGridViewE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cVehicule,
            this.cDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewE.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewE.GridColor = System.Drawing.Color.White;
            this.dataGridViewE.Location = new System.Drawing.Point(503, 115);
            this.dataGridViewE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewE.Name = "dataGridViewE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewE.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewE.RowHeadersVisible = false;
            this.dataGridViewE.RowHeadersWidth = 51;
            this.dataGridViewE.RowTemplate.Height = 24;
            this.dataGridViewE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewE.Size = new System.Drawing.Size(360, 665);
            this.dataGridViewE.TabIndex = 110;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.Crimson;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouter.Location = new System.Drawing.Point(20, 634);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(452, 39);
            this.buttonAjouter.TabIndex = 108;
            this.buttonAjouter.Text = "Ajouter un entretien";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.BackColor = System.Drawing.Color.Crimson;
            this.buttonConfirmer.FlatAppearance.BorderSize = 0;
            this.buttonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmer.Location = new System.Drawing.Point(20, 634);
            this.buttonConfirmer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(452, 39);
            this.buttonConfirmer.TabIndex = 105;
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
            this.buttonAnnuler.Location = new System.Drawing.Point(21, 687);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(452, 39);
            this.buttonAnnuler.TabIndex = 104;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Crimson;
            this.labelDate.Location = new System.Drawing.Point(28, 146);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(122, 19);
            this.labelDate.TabIndex = 107;
            this.labelDate.Text = "Date d\'entretien";
            // 
            // labelVehicule
            // 
            this.labelVehicule.AutoSize = true;
            this.labelVehicule.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicule.ForeColor = System.Drawing.Color.Crimson;
            this.labelVehicule.Location = new System.Drawing.Point(28, 93);
            this.labelVehicule.Name = "labelVehicule";
            this.labelVehicule.Size = new System.Drawing.Size(70, 19);
            this.labelVehicule.TabIndex = 106;
            this.labelVehicule.Text = "Entretien";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Crimson;
            this.buttonSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimer.Location = new System.Drawing.Point(23, 741);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(452, 39);
            this.buttonSupprimer.TabIndex = 103;
            this.buttonSupprimer.Text = "Supprimer un entretien";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Crimson;
            this.labelTitle.Location = new System.Drawing.Point(16, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(250, 30);
            this.labelTitle.TabIndex = 102;
            this.labelTitle.Text = "GESTION DES PIÈCES";
            // 
            // comboBoxVehicule
            // 
            this.comboBoxVehicule.BackColor = System.Drawing.Color.Black;
            this.comboBoxVehicule.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVehicule.ForeColor = System.Drawing.Color.White;
            this.comboBoxVehicule.FormattingEnabled = true;
            this.comboBoxVehicule.Location = new System.Drawing.Point(32, 115);
            this.comboBoxVehicule.Name = "comboBoxVehicule";
            this.comboBoxVehicule.Size = new System.Drawing.Size(452, 25);
            this.comboBoxVehicule.TabIndex = 113;
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
            // cVehicule
            // 
            this.cVehicule.DataPropertyName = "vehicule";
            this.cVehicule.HeaderText = "Véhicule";
            this.cVehicule.MinimumWidth = 6;
            this.cVehicule.Name = "cVehicule";
            this.cVehicule.ReadOnly = true;
            this.cVehicule.Width = 180;
            // 
            // cDate
            // 
            this.cDate.DataPropertyName = "date";
            this.cDate.HeaderText = "Date d\'entretien";
            this.cDate.MinimumWidth = 6;
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 125;
            // 
            // dateTimePickerDateEntretien
            // 
            this.dateTimePickerDateEntretien.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePickerDateEntretien.BorderSize = 1;
            this.dateTimePickerDateEntretien.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateEntretien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateEntretien.Location = new System.Drawing.Point(32, 168);
            this.dateTimePickerDateEntretien.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePickerDateEntretien.Name = "dateTimePickerDateEntretien";
            this.dateTimePickerDateEntretien.Size = new System.Drawing.Size(452, 35);
            this.dateTimePickerDateEntretien.SkinColor = System.Drawing.Color.Black;
            this.dateTimePickerDateEntretien.TabIndex = 111;
            this.dateTimePickerDateEntretien.TextColor = System.Drawing.Color.White;
            // 
            // UserControleEntre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.comboBoxVehicule);
            this.Controls.Add(this.dateTimePickerDateEntretien);
            this.Controls.Add(this.buttonEditer);
            this.Controls.Add(this.dataGridViewE);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelVehicule);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.labelTitle);
            this.Name = "UserControleEntre";
            this.Size = new System.Drawing.Size(1260, 805);
            this.Load += new System.EventHandler(this.UserControleEntre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.DataGridView dataGridViewE;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelVehicule;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label labelTitle;
        private CustomControls.RJControls.RJDatePicker dateTimePickerDateEntretien;
        private System.Windows.Forms.ComboBox comboBoxVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
    }
}
