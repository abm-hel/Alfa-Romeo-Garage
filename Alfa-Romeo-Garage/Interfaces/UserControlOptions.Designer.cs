
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
            this.SuspendLayout();
            // 
            // labelModele
            // 
            this.labelModele.AutoSize = true;
            this.labelModele.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModele.ForeColor = System.Drawing.Color.Crimson;
            this.labelModele.Location = new System.Drawing.Point(358, 360);
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
            this.comboBoxEntretienFacture.Location = new System.Drawing.Point(362, 383);
            this.comboBoxEntretienFacture.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEntretienFacture.Name = "comboBoxEntretienFacture";
            this.comboBoxEntretienFacture.Size = new System.Drawing.Size(473, 24);
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
            this.buttonGenererFacture.Location = new System.Drawing.Point(362, 432);
            this.buttonGenererFacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenererFacture.Name = "buttonGenererFacture";
            this.buttonGenererFacture.Size = new System.Drawing.Size(471, 39);
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
            this.labelTitre.Location = new System.Drawing.Point(449, 306);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(286, 30);
            this.labelTitre.TabIndex = 74;
            this.labelTitre.Text = "GÉNERER UNE FACTURE";
            // 
            // UserControlOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
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
    }
}
