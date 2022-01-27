
namespace Alfa_Romeo_Garage
{
    partial class Options
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
            this.buttonStock = new System.Windows.Forms.Button();
            this.labelReleve = new System.Windows.Forms.Label();
            this.dateTimePickerDateChiffreAffaires = new CustomControls.RJControls.RJDatePicker();
            this.labelChiffreAffaires = new System.Windows.Forms.Label();
            this.labelChiffre = new System.Windows.Forms.Label();
            this.buttonCalculerChiffreAffaires = new System.Windows.Forms.Button();
            this.labelDateChiffreAffaires = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelModele = new System.Windows.Forms.Label();
            this.comboBoxEntretienFacture = new System.Windows.Forms.ComboBox();
            this.buttonGenererHTML = new System.Windows.Forms.Button();
            this.webBrowserReleve = new System.Windows.Forms.WebBrowser();
            this.buttonGenererFacture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.Color.Crimson;
            this.buttonStock.FlatAppearance.BorderSize = 0;
            this.buttonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStock.Location = new System.Drawing.Point(17, 606);
            this.buttonStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(303, 74);
            this.buttonStock.TabIndex = 95;
            this.buttonStock.Text = "Relevé des pièces en rupture";
            this.buttonStock.UseVisualStyleBackColor = false;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // labelReleve
            // 
            this.labelReleve.AutoSize = true;
            this.labelReleve.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelReleve.Location = new System.Drawing.Point(339, 20);
            this.labelReleve.Name = "labelReleve";
            this.labelReleve.Size = new System.Drawing.Size(398, 30);
            this.labelReleve.TabIndex = 94;
            this.labelReleve.Text = "RELEVÉ DE LA SEMAINE ÉCOULÉE \r\n";
            // 
            // dateTimePickerDateChiffreAffaires
            // 
            this.dateTimePickerDateChiffreAffaires.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePickerDateChiffreAffaires.BorderSize = 1;
            this.dateTimePickerDateChiffreAffaires.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateChiffreAffaires.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateChiffreAffaires.Location = new System.Drawing.Point(17, 329);
            this.dateTimePickerDateChiffreAffaires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDateChiffreAffaires.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePickerDateChiffreAffaires.Name = "dateTimePickerDateChiffreAffaires";
            this.dateTimePickerDateChiffreAffaires.Size = new System.Drawing.Size(294, 35);
            this.dateTimePickerDateChiffreAffaires.SkinColor = System.Drawing.Color.Black;
            this.dateTimePickerDateChiffreAffaires.TabIndex = 92;
            this.dateTimePickerDateChiffreAffaires.TextColor = System.Drawing.Color.White;
            // 
            // labelChiffreAffaires
            // 
            this.labelChiffreAffaires.AutoSize = true;
            this.labelChiffreAffaires.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChiffreAffaires.ForeColor = System.Drawing.Color.White;
            this.labelChiffreAffaires.Location = new System.Drawing.Point(12, 491);
            this.labelChiffreAffaires.Name = "labelChiffreAffaires";
            this.labelChiffreAffaires.Size = new System.Drawing.Size(0, 37);
            this.labelChiffreAffaires.TabIndex = 91;
            // 
            // labelChiffre
            // 
            this.labelChiffre.AutoSize = true;
            this.labelChiffre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChiffre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelChiffre.Location = new System.Drawing.Point(12, 232);
            this.labelChiffre.Name = "labelChiffre";
            this.labelChiffre.Size = new System.Drawing.Size(241, 60);
            this.labelChiffre.TabIndex = 90;
            this.labelChiffre.Text = "CHIFFRE D\'AFFAIRES\r\nHÉBDOMMADAIRE\r\n";
            // 
            // buttonCalculerChiffreAffaires
            // 
            this.buttonCalculerChiffreAffaires.BackColor = System.Drawing.Color.Crimson;
            this.buttonCalculerChiffreAffaires.FlatAppearance.BorderSize = 0;
            this.buttonCalculerChiffreAffaires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculerChiffreAffaires.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculerChiffreAffaires.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalculerChiffreAffaires.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalculerChiffreAffaires.Location = new System.Drawing.Point(17, 386);
            this.buttonCalculerChiffreAffaires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalculerChiffreAffaires.Name = "buttonCalculerChiffreAffaires";
            this.buttonCalculerChiffreAffaires.Size = new System.Drawing.Size(294, 70);
            this.buttonCalculerChiffreAffaires.TabIndex = 89;
            this.buttonCalculerChiffreAffaires.Text = "Calculer le chiffre \r\nd\'affaires";
            this.buttonCalculerChiffreAffaires.UseVisualStyleBackColor = false;
            this.buttonCalculerChiffreAffaires.Click += new System.EventHandler(this.buttonCalculerChiffreAffaires_Click);
            // 
            // labelDateChiffreAffaires
            // 
            this.labelDateChiffreAffaires.AutoSize = true;
            this.labelDateChiffreAffaires.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateChiffreAffaires.ForeColor = System.Drawing.Color.Crimson;
            this.labelDateChiffreAffaires.Location = new System.Drawing.Point(13, 308);
            this.labelDateChiffreAffaires.Name = "labelDateChiffreAffaires";
            this.labelDateChiffreAffaires.Size = new System.Drawing.Size(215, 19);
            this.labelDateChiffreAffaires.TabIndex = 88;
            this.labelDateChiffreAffaires.Text = "Date du début de la semaine";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTitre.Location = new System.Drawing.Point(12, 27);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(286, 30);
            this.labelTitre.TabIndex = 87;
            this.labelTitre.Text = "GÉNERER UNE FACTURE";
            // 
            // labelModele
            // 
            this.labelModele.AutoSize = true;
            this.labelModele.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModele.ForeColor = System.Drawing.Color.Crimson;
            this.labelModele.Location = new System.Drawing.Point(10, 66);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(70, 19);
            this.labelModele.TabIndex = 86;
            this.labelModele.Text = "Entretien";
            // 
            // comboBoxEntretienFacture
            // 
            this.comboBoxEntretienFacture.BackColor = System.Drawing.Color.Black;
            this.comboBoxEntretienFacture.ForeColor = System.Drawing.Color.White;
            this.comboBoxEntretienFacture.FormattingEnabled = true;
            this.comboBoxEntretienFacture.Location = new System.Drawing.Point(14, 89);
            this.comboBoxEntretienFacture.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEntretienFacture.Name = "comboBoxEntretienFacture";
            this.comboBoxEntretienFacture.Size = new System.Drawing.Size(295, 24);
            this.comboBoxEntretienFacture.TabIndex = 85;
            // 
            // buttonGenererHTML
            // 
            this.buttonGenererHTML.BackColor = System.Drawing.Color.Crimson;
            this.buttonGenererHTML.FlatAppearance.BorderSize = 0;
            this.buttonGenererHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenererHTML.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenererHTML.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGenererHTML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenererHTML.Location = new System.Drawing.Point(1078, 16);
            this.buttonGenererHTML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenererHTML.Name = "buttonGenererHTML";
            this.buttonGenererHTML.Size = new System.Drawing.Size(152, 39);
            this.buttonGenererHTML.TabIndex = 96;
            this.buttonGenererHTML.Text = "Actualiser";
            this.buttonGenererHTML.UseVisualStyleBackColor = false;
            this.buttonGenererHTML.Click += new System.EventHandler(this.buttonGenererHTML_Click);
            // 
            // webBrowserReleve
            // 
            this.webBrowserReleve.Location = new System.Drawing.Point(344, 86);
            this.webBrowserReleve.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserReleve.Name = "webBrowserReleve";
            this.webBrowserReleve.Size = new System.Drawing.Size(886, 594);
            this.webBrowserReleve.TabIndex = 97;
            // 
            // buttonGenererFacture
            // 
            this.buttonGenererFacture.BackColor = System.Drawing.Color.Crimson;
            this.buttonGenererFacture.FlatAppearance.BorderSize = 0;
            this.buttonGenererFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenererFacture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenererFacture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGenererFacture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenererFacture.Location = new System.Drawing.Point(14, 130);
            this.buttonGenererFacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenererFacture.Name = "buttonGenererFacture";
            this.buttonGenererFacture.Size = new System.Drawing.Size(295, 39);
            this.buttonGenererFacture.TabIndex = 98;
            this.buttonGenererFacture.Text = "Génerer une facture";
            this.buttonGenererFacture.UseVisualStyleBackColor = false;
            this.buttonGenererFacture.Click += new System.EventHandler(this.buttonGenererFacture_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1252, 707);
            this.Controls.Add(this.buttonGenererFacture);
            this.Controls.Add(this.webBrowserReleve);
            this.Controls.Add(this.buttonGenererHTML);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.labelReleve);
            this.Controls.Add(this.dateTimePickerDateChiffreAffaires);
            this.Controls.Add(this.labelChiffreAffaires);
            this.Controls.Add(this.labelChiffre);
            this.Controls.Add(this.buttonCalculerChiffreAffaires);
            this.Controls.Add(this.labelDateChiffreAffaires);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.labelModele);
            this.Controls.Add(this.comboBoxEntretienFacture);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Label labelReleve;
        private CustomControls.RJControls.RJDatePicker dateTimePickerDateChiffreAffaires;
        private System.Windows.Forms.Label labelChiffreAffaires;
        private System.Windows.Forms.Label labelChiffre;
        private System.Windows.Forms.Button buttonCalculerChiffreAffaires;
        private System.Windows.Forms.Label labelDateChiffreAffaires;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelModele;
        private System.Windows.Forms.ComboBox comboBoxEntretienFacture;
        private System.Windows.Forms.Button buttonGenererHTML;
        private System.Windows.Forms.WebBrowser webBrowserReleve;
        private System.Windows.Forms.Button buttonGenererFacture;
    }
}