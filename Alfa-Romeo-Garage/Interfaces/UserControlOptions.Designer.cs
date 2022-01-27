
namespace Alfa_Romeo_Garage.Interfaces
{
    partial class UserControlOptions
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
            this.labelModele = new System.Windows.Forms.Label();
            this.comboBoxEntretienFacture = new System.Windows.Forms.ComboBox();
            this.buttonGenererFacture = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonCalculerChiffreAffaires = new System.Windows.Forms.Button();
            this.labelDateChiffreAffaires = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChiffreAffaires = new System.Windows.Forms.Label();
            this.dateTimePickerDateChiffreAffaires = new CustomControls.RJControls.RJDatePicker();
            this.SuspendLayout();
            // 
            // labelModele
            // 
            this.labelModele.AutoSize = true;
            this.labelModele.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModele.ForeColor = System.Drawing.Color.Crimson;
            this.labelModele.Location = new System.Drawing.Point(69, 181);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(70, 19);
            this.labelModele.TabIndex = 73;
            this.labelModele.Text = "Entretien";
            // 
            // comboBoxEntretienFacture
            // 
            this.comboBoxEntretienFacture.BackColor = System.Drawing.Color.Black;
            this.comboBoxEntretienFacture.ForeColor = System.Drawing.Color.White;
            this.comboBoxEntretienFacture.FormattingEnabled = true;
            this.comboBoxEntretienFacture.Location = new System.Drawing.Point(73, 204);
            this.comboBoxEntretienFacture.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEntretienFacture.Name = "comboBoxEntretienFacture";
            this.comboBoxEntretienFacture.Size = new System.Drawing.Size(401, 24);
            this.comboBoxEntretienFacture.TabIndex = 72;
            // 
            // buttonGenererFacture
            // 
            this.buttonGenererFacture.BackColor = System.Drawing.Color.Crimson;
            this.buttonGenererFacture.FlatAppearance.BorderSize = 0;
            this.buttonGenererFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenererFacture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenererFacture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGenererFacture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenererFacture.Location = new System.Drawing.Point(73, 253);
            this.buttonGenererFacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenererFacture.Name = "buttonGenererFacture";
            this.buttonGenererFacture.Size = new System.Drawing.Size(399, 39);
            this.buttonGenererFacture.TabIndex = 71;
            this.buttonGenererFacture.Text = "Génerer une facture";
            this.buttonGenererFacture.UseVisualStyleBackColor = false;
            this.buttonGenererFacture.Click += new System.EventHandler(this.buttonGenererFacture_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTitre.Location = new System.Drawing.Point(134, 96);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(286, 30);
            this.labelTitre.TabIndex = 74;
            this.labelTitre.Text = "GÉNERER UNE FACTURE";
            // 
            // buttonCalculerChiffreAffaires
            // 
            this.buttonCalculerChiffreAffaires.BackColor = System.Drawing.Color.Crimson;
            this.buttonCalculerChiffreAffaires.FlatAppearance.BorderSize = 0;
            this.buttonCalculerChiffreAffaires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculerChiffreAffaires.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculerChiffreAffaires.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalculerChiffreAffaires.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalculerChiffreAffaires.Location = new System.Drawing.Point(655, 261);
            this.buttonCalculerChiffreAffaires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalculerChiffreAffaires.Name = "buttonCalculerChiffreAffaires";
            this.buttonCalculerChiffreAffaires.Size = new System.Drawing.Size(400, 39);
            this.buttonCalculerChiffreAffaires.TabIndex = 77;
            this.buttonCalculerChiffreAffaires.Text = "Calculer le chiffre d\'affaires";
            this.buttonCalculerChiffreAffaires.UseVisualStyleBackColor = false;
            this.buttonCalculerChiffreAffaires.Click += new System.EventHandler(this.buttonCalculerChiffreAffaires_Click);
            // 
            // labelDateChiffreAffaires
            // 
            this.labelDateChiffreAffaires.AutoSize = true;
            this.labelDateChiffreAffaires.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateChiffreAffaires.ForeColor = System.Drawing.Color.Crimson;
            this.labelDateChiffreAffaires.Location = new System.Drawing.Point(651, 162);
            this.labelDateChiffreAffaires.Name = "labelDateChiffreAffaires";
            this.labelDateChiffreAffaires.Size = new System.Drawing.Size(216, 19);
            this.labelDateChiffreAffaires.TabIndex = 75;
            this.labelDateChiffreAffaires.Text = "Date dernière immatriculation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(729, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 60);
            this.label1.TabIndex = 78;
            this.label1.Text = "CHIFFRE D\'AFFAIRES\r\nHÉBDOMMADAIRE\r\n";
            // 
            // labelChiffreAffaires
            // 
            this.labelChiffreAffaires.AutoSize = true;
            this.labelChiffreAffaires.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChiffreAffaires.ForeColor = System.Drawing.Color.White;
            this.labelChiffreAffaires.Location = new System.Drawing.Point(758, 335);
            this.labelChiffreAffaires.Name = "labelChiffreAffaires";
            this.labelChiffreAffaires.Size = new System.Drawing.Size(0, 37);
            this.labelChiffreAffaires.TabIndex = 79;
            // 
            // dateTimePickerDateChiffreAffaires
            // 
            this.dateTimePickerDateChiffreAffaires.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePickerDateChiffreAffaires.BorderSize = 1;
            this.dateTimePickerDateChiffreAffaires.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateChiffreAffaires.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateChiffreAffaires.Location = new System.Drawing.Point(655, 204);
            this.dateTimePickerDateChiffreAffaires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDateChiffreAffaires.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePickerDateChiffreAffaires.Name = "dateTimePickerDateChiffreAffaires";
            this.dateTimePickerDateChiffreAffaires.Size = new System.Drawing.Size(400, 35);
            this.dateTimePickerDateChiffreAffaires.SkinColor = System.Drawing.Color.Black;
            this.dateTimePickerDateChiffreAffaires.TabIndex = 80;
            this.dateTimePickerDateChiffreAffaires.TextColor = System.Drawing.Color.White;
            // 
            // UserControlOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dateTimePickerDateChiffreAffaires);
            this.Controls.Add(this.labelChiffreAffaires);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculerChiffreAffaires);
            this.Controls.Add(this.labelDateChiffreAffaires);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.labelModele);
            this.Controls.Add(this.comboBoxEntretienFacture);
            this.Controls.Add(this.buttonGenererFacture);
            this.Name = "UserControlOptions";
            this.Size = new System.Drawing.Size(1228, 842);
            this.Load += new System.EventHandler(this.UserControlOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModele;
        private System.Windows.Forms.ComboBox comboBoxEntretienFacture;
        private System.Windows.Forms.Button buttonGenererFacture;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button buttonCalculerChiffreAffaires;
        private System.Windows.Forms.Label labelDateChiffreAffaires;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChiffreAffaires;
        private CustomControls.RJControls.RJDatePicker dateTimePickerDateChiffreAffaires;
    }
}
