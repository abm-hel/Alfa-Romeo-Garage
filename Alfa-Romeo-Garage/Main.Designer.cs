﻿
namespace Alfa_Romeo_Garage
{
    partial class MainForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.panelButtonSelectionne = new System.Windows.Forms.Panel();
            this.buttonInterventions = new System.Windows.Forms.Button();
            this.buttonPieces = new System.Windows.Forms.Button();
            this.buttonVehicules = new System.Windows.Forms.Button();
            this.pictureBoxLogoAccueil = new System.Windows.Forms.PictureBox();
            this.buttonModeles = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.labelAccueil = new System.Windows.Forms.Label();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.userControlIntervetions1 = new Alfa_Romeo_Garage.UserControlIntervetions();
            this.userControlPieces1 = new Alfa_Romeo_Garage.UserControlPieces();
            this.userControlVehiculescs1 = new Alfa_Romeo_Garage.UserControlVehicules();
            this.userControlModeles1 = new Alfa_Romeo_Garage.UserControlModeles();
            this.userControlClients1 = new Alfa_Romeo_Garage.UserControlClients();
            this.userControlAccueil1 = new Alfa_Romeo_Garage.UserControlAccueil();
            this.userControleEntre1 = new Alfa_Romeo_Garage.Interfaces.UserControleEntre();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoAccueil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.buttonOptions);
            this.panelMenu.Controls.Add(this.panelButtonSelectionne);
            this.panelMenu.Controls.Add(this.buttonInterventions);
            this.panelMenu.Controls.Add(this.buttonPieces);
            this.panelMenu.Controls.Add(this.buttonVehicules);
            this.panelMenu.Controls.Add(this.pictureBoxLogoAccueil);
            this.panelMenu.Controls.Add(this.buttonModeles);
            this.panelMenu.Controls.Add(this.buttonClients);
            this.panelMenu.Controls.Add(this.labelAccueil);
            this.panelMenu.Controls.Add(this.buttonAccueil);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(311, 869);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonOptions
            // 
            this.buttonOptions.FlatAppearance.BorderSize = 0;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOptions.Image")));
            this.buttonOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOptions.Location = new System.Drawing.Point(31, 772);
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(253, 62);
            this.buttonOptions.TabIndex = 11;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // panelButtonSelectionne
            // 
            this.panelButtonSelectionne.BackColor = System.Drawing.Color.Crimson;
            this.panelButtonSelectionne.Location = new System.Drawing.Point(3, 196);
            this.panelButtonSelectionne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelButtonSelectionne.Name = "panelButtonSelectionne";
            this.panelButtonSelectionne.Size = new System.Drawing.Size(13, 62);
            this.panelButtonSelectionne.TabIndex = 10;
            // 
            // buttonInterventions
            // 
            this.buttonInterventions.FlatAppearance.BorderSize = 0;
            this.buttonInterventions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInterventions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInterventions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInterventions.Image = ((System.Drawing.Image)(resources.GetObject("buttonInterventions.Image")));
            this.buttonInterventions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInterventions.Location = new System.Drawing.Point(35, 678);
            this.buttonInterventions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInterventions.Name = "buttonInterventions";
            this.buttonInterventions.Size = new System.Drawing.Size(253, 62);
            this.buttonInterventions.TabIndex = 10;
            this.buttonInterventions.Text = "Interventions";
            this.buttonInterventions.UseVisualStyleBackColor = true;
            this.buttonInterventions.Click += new System.EventHandler(this.buttonInterventions_Click);
            // 
            // buttonPieces
            // 
            this.buttonPieces.FlatAppearance.BorderSize = 0;
            this.buttonPieces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPieces.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPieces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPieces.Image = ((System.Drawing.Image)(resources.GetObject("buttonPieces.Image")));
            this.buttonPieces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPieces.Location = new System.Drawing.Point(31, 587);
            this.buttonPieces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPieces.Name = "buttonPieces";
            this.buttonPieces.Size = new System.Drawing.Size(253, 62);
            this.buttonPieces.TabIndex = 8;
            this.buttonPieces.Text = "Pièces";
            this.buttonPieces.UseVisualStyleBackColor = true;
            this.buttonPieces.Click += new System.EventHandler(this.buttonPieces_Click);
            // 
            // buttonVehicules
            // 
            this.buttonVehicules.FlatAppearance.BorderSize = 0;
            this.buttonVehicules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicules.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicules.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVehicules.Image = ((System.Drawing.Image)(resources.GetObject("buttonVehicules.Image")));
            this.buttonVehicules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVehicules.Location = new System.Drawing.Point(27, 495);
            this.buttonVehicules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVehicules.Name = "buttonVehicules";
            this.buttonVehicules.Size = new System.Drawing.Size(257, 62);
            this.buttonVehicules.TabIndex = 7;
            this.buttonVehicules.Text = "Véhicules";
            this.buttonVehicules.UseVisualStyleBackColor = true;
            this.buttonVehicules.Click += new System.EventHandler(this.buttonVehicules_Click);
            // 
            // pictureBoxLogoAccueil
            // 
            this.pictureBoxLogoAccueil.Image = global::Alfa_Romeo_Garage.Properties.Resources.icons8_alfa_romeo_50__1_1;
            this.pictureBoxLogoAccueil.Location = new System.Drawing.Point(117, 25);
            this.pictureBoxLogoAccueil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogoAccueil.Name = "pictureBoxLogoAccueil";
            this.pictureBoxLogoAccueil.Size = new System.Drawing.Size(67, 59);
            this.pictureBoxLogoAccueil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoAccueil.TabIndex = 6;
            this.pictureBoxLogoAccueil.TabStop = false;
            // 
            // buttonModeles
            // 
            this.buttonModeles.FlatAppearance.BorderSize = 0;
            this.buttonModeles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModeles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModeles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModeles.Image = ((System.Drawing.Image)(resources.GetObject("buttonModeles.Image")));
            this.buttonModeles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModeles.Location = new System.Drawing.Point(27, 399);
            this.buttonModeles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModeles.Name = "buttonModeles";
            this.buttonModeles.Size = new System.Drawing.Size(253, 62);
            this.buttonModeles.TabIndex = 5;
            this.buttonModeles.Text = "Modèles\r\nAlfa Romeo";
            this.buttonModeles.UseVisualStyleBackColor = true;
            this.buttonModeles.Click += new System.EventHandler(this.buttonModeles_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.FlatAppearance.BorderSize = 0;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClients.Image = ((System.Drawing.Image)(resources.GetObject("buttonClients.Image")));
            this.buttonClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClients.Location = new System.Drawing.Point(27, 299);
            this.buttonClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(253, 62);
            this.buttonClients.TabIndex = 4;
            this.buttonClients.Text = "Clients";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // labelAccueil
            // 
            this.labelAccueil.AutoSize = true;
            this.labelAccueil.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccueil.ForeColor = System.Drawing.Color.Crimson;
            this.labelAccueil.Location = new System.Drawing.Point(77, 87);
            this.labelAccueil.Name = "labelAccueil";
            this.labelAccueil.Size = new System.Drawing.Size(145, 46);
            this.labelAccueil.TabIndex = 3;
            this.labelAccueil.Text = "ALFA ROMEO \r\n    GARAGE";
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.FlatAppearance.BorderSize = 0;
            this.buttonAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccueil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccueil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAccueil.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccueil.Image")));
            this.buttonAccueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccueil.Location = new System.Drawing.Point(35, 196);
            this.buttonAccueil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(253, 62);
            this.buttonAccueil.TabIndex = 1;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // userControlIntervetions1
            // 
            this.userControlIntervetions1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlIntervetions1.Location = new System.Drawing.Point(317, 10);
            this.userControlIntervetions1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlIntervetions1.Name = "userControlIntervetions1";
            this.userControlIntervetions1.Padding = new System.Windows.Forms.Padding(1);
            this.userControlIntervetions1.Size = new System.Drawing.Size(1211, 834);
            this.userControlIntervetions1.TabIndex = 15;
            // 
            // userControlPieces1
            // 
            this.userControlPieces1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlPieces1.Location = new System.Drawing.Point(317, 10);
            this.userControlPieces1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlPieces1.Name = "userControlPieces1";
            this.userControlPieces1.Size = new System.Drawing.Size(1211, 834);
            this.userControlPieces1.TabIndex = 14;
            // 
            // userControlVehiculescs1
            // 
            this.userControlVehiculescs1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlVehiculescs1.Location = new System.Drawing.Point(317, 10);
            this.userControlVehiculescs1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlVehiculescs1.Name = "userControlVehiculescs1";
            this.userControlVehiculescs1.Size = new System.Drawing.Size(1211, 834);
            this.userControlVehiculescs1.TabIndex = 13;
            // 
            // userControlModeles1
            // 
            this.userControlModeles1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlModeles1.Location = new System.Drawing.Point(317, 10);
            this.userControlModeles1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlModeles1.Name = "userControlModeles1";
            this.userControlModeles1.Padding = new System.Windows.Forms.Padding(1);
            this.userControlModeles1.Size = new System.Drawing.Size(1211, 834);
            this.userControlModeles1.TabIndex = 12;
            // 
            // userControlClients1
            // 
            this.userControlClients1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlClients1.Location = new System.Drawing.Point(317, 10);
            this.userControlClients1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlClients1.Name = "userControlClients1";
            this.userControlClients1.Size = new System.Drawing.Size(1211, 834);
            this.userControlClients1.TabIndex = 11;
            // 
            // userControlAccueil1
            // 
            this.userControlAccueil1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlAccueil1.Location = new System.Drawing.Point(317, 10);
            this.userControlAccueil1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlAccueil1.Name = "userControlAccueil1";
            this.userControlAccueil1.Size = new System.Drawing.Size(1211, 834);
            this.userControlAccueil1.TabIndex = 10;
            // 
            // userControleEntre1
            // 
            this.userControleEntre1.BackColor = System.Drawing.Color.Black;
            this.userControleEntre1.Location = new System.Drawing.Point(317, 10);
            this.userControleEntre1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControleEntre1.Name = "userControleEntre1";
            this.userControleEntre1.Size = new System.Drawing.Size(1211, 834);
            this.userControleEntre1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1540, 869);
            this.Controls.Add(this.userControleEntre1);
            this.Controls.Add(this.userControlIntervetions1);
            this.Controls.Add(this.userControlPieces1);
            this.Controls.Add(this.userControlVehiculescs1);
            this.Controls.Add(this.userControlModeles1);
            this.Controls.Add(this.userControlClients1);
            this.Controls.Add(this.userControlAccueil1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alfa Romeo Garage ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoAccueil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Button buttonModeles;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonPieces;
        private System.Windows.Forms.Button buttonVehicules;
        private System.Windows.Forms.PictureBox pictureBoxLogoAccueil;
        private System.Windows.Forms.Label labelAccueil;
        private System.Windows.Forms.Button buttonInterventions;
        private System.Windows.Forms.Panel panelButtonSelectionne;
        private UserControlAccueil userControlAccueil1;
        private UserControlClients userControlClients1;
        private UserControlModeles userControlModeles1;
        private UserControlVehicules userControlVehiculescs1;
        private UserControlPieces userControlPieces1;
        private UserControlIntervetions userControlIntervetions1;
        private Interfaces.UserControleEntre userControleEntre1;
        
        private System.Windows.Forms.Button buttonOptions;
    }
}

