
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
            this.panelButtonSelectionne = new System.Windows.Forms.Panel();
            this.buttonInterventions = new System.Windows.Forms.Button();
            this.buttonEntretiens = new System.Windows.Forms.Button();
            this.buttonPieces = new System.Windows.Forms.Button();
            this.buttonVehicules = new System.Windows.Forms.Button();
            this.pictureBoxLogoAccueil = new System.Windows.Forms.PictureBox();
            this.buttonModeles = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.labelAccueil = new System.Windows.Forms.Label();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.userControlEntretiens1 = new Alfa_Romeo_Garage.UserControlEntretiens();
            this.userControlIntervetions1 = new Alfa_Romeo_Garage.UserControlIntervetions();
            this.userControlPieces1 = new Alfa_Romeo_Garage.UserControlPieces();
            this.userControlVehiculescs1 = new Alfa_Romeo_Garage.UserControlVehicules();
            this.userControlModeles1 = new Alfa_Romeo_Garage.UserControlModeles();
            this.userControlClients1 = new Alfa_Romeo_Garage.UserControlClients();
            this.userControlAccueil1 = new Alfa_Romeo_Garage.UserControlAccueil();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoAccueil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.panelButtonSelectionne);
            this.panelMenu.Controls.Add(this.buttonInterventions);
            this.panelMenu.Controls.Add(this.buttonEntretiens);
            this.panelMenu.Controls.Add(this.buttonPieces);
            this.panelMenu.Controls.Add(this.buttonVehicules);
            this.panelMenu.Controls.Add(this.pictureBoxLogoAccueil);
            this.panelMenu.Controls.Add(this.buttonModeles);
            this.panelMenu.Controls.Add(this.buttonClients);
            this.panelMenu.Controls.Add(this.labelAccueil);
            this.panelMenu.Controls.Add(this.buttonAccueil);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(234, 814);
            this.panelMenu.TabIndex = 0;
            // 
            // panelButtonSelectionne
            // 
            this.panelButtonSelectionne.BackColor = System.Drawing.Color.Crimson;
            this.panelButtonSelectionne.Location = new System.Drawing.Point(2, 159);
            this.panelButtonSelectionne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelButtonSelectionne.Name = "panelButtonSelectionne";
            this.panelButtonSelectionne.Size = new System.Drawing.Size(10, 50);
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
            this.buttonInterventions.Location = new System.Drawing.Point(43, 539);
            this.buttonInterventions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInterventions.Name = "buttonInterventions";
            this.buttonInterventions.Size = new System.Drawing.Size(190, 50);
            this.buttonInterventions.TabIndex = 10;
            this.buttonInterventions.Text = "Interventions";
            this.buttonInterventions.UseVisualStyleBackColor = true;
            this.buttonInterventions.Click += new System.EventHandler(this.buttonInterventions_Click);
            // 
            // buttonEntretiens
            // 
            this.buttonEntretiens.FlatAppearance.BorderSize = 0;
            this.buttonEntretiens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntretiens.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntretiens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEntretiens.Image = ((System.Drawing.Image)(resources.GetObject("buttonEntretiens.Image")));
            this.buttonEntretiens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEntretiens.Location = new System.Drawing.Point(43, 623);
            this.buttonEntretiens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEntretiens.Name = "buttonEntretiens";
            this.buttonEntretiens.Size = new System.Drawing.Size(190, 50);
            this.buttonEntretiens.TabIndex = 9;
            this.buttonEntretiens.Text = "Entretiens";
            this.buttonEntretiens.UseVisualStyleBackColor = true;
            this.buttonEntretiens.Click += new System.EventHandler(this.buttonEntretiens_Click);
            // 
            // buttonPieces
            // 
            this.buttonPieces.FlatAppearance.BorderSize = 0;
            this.buttonPieces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPieces.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPieces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPieces.Image = ((System.Drawing.Image)(resources.GetObject("buttonPieces.Image")));
            this.buttonPieces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPieces.Location = new System.Drawing.Point(43, 462);
            this.buttonPieces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPieces.Name = "buttonPieces";
            this.buttonPieces.Size = new System.Drawing.Size(190, 50);
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
            this.buttonVehicules.Location = new System.Drawing.Point(40, 386);
            this.buttonVehicules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVehicules.Name = "buttonVehicules";
            this.buttonVehicules.Size = new System.Drawing.Size(193, 50);
            this.buttonVehicules.TabIndex = 7;
            this.buttonVehicules.Text = "Véhicules";
            this.buttonVehicules.UseVisualStyleBackColor = true;
            this.buttonVehicules.Click += new System.EventHandler(this.buttonVehicules_Click);
            // 
            // pictureBoxLogoAccueil
            // 
            this.pictureBoxLogoAccueil.Image = global::Alfa_Romeo_Garage.Properties.Resources.icons8_alfa_romeo_50__1_1;
            this.pictureBoxLogoAccueil.Location = new System.Drawing.Point(88, 20);
            this.pictureBoxLogoAccueil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLogoAccueil.Name = "pictureBoxLogoAccueil";
            this.pictureBoxLogoAccueil.Size = new System.Drawing.Size(50, 48);
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
            this.buttonModeles.Location = new System.Drawing.Point(43, 311);
            this.buttonModeles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModeles.Name = "buttonModeles";
            this.buttonModeles.Size = new System.Drawing.Size(190, 50);
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
            this.buttonClients.Location = new System.Drawing.Point(40, 235);
            this.buttonClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(190, 50);
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
            this.labelAccueil.Location = new System.Drawing.Point(58, 71);
            this.labelAccueil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccueil.Name = "labelAccueil";
            this.labelAccueil.Size = new System.Drawing.Size(114, 42);
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
            this.buttonAccueil.Location = new System.Drawing.Point(43, 159);
            this.buttonAccueil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(190, 50);
            this.buttonAccueil.TabIndex = 1;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // userControlEntretiens1
            // 
            this.userControlEntretiens1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlEntretiens1.Location = new System.Drawing.Point(235, 160);
            this.userControlEntretiens1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlEntretiens1.Name = "userControlEntretiens1";
            this.userControlEntretiens1.Size = new System.Drawing.Size(945, 654);
            this.userControlEntretiens1.TabIndex = 16;
            // 
            // userControlIntervetions1
            // 
            this.userControlIntervetions1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlIntervetions1.Location = new System.Drawing.Point(235, 160);
            this.userControlIntervetions1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlIntervetions1.Name = "userControlIntervetions1";
            this.userControlIntervetions1.Padding = new System.Windows.Forms.Padding(1);
            this.userControlIntervetions1.Size = new System.Drawing.Size(945, 654);
            this.userControlIntervetions1.TabIndex = 15;
            // 
            // userControlPieces1
            // 
            this.userControlPieces1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlPieces1.Location = new System.Drawing.Point(235, 160);
            this.userControlPieces1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlPieces1.Name = "userControlPieces1";
            this.userControlPieces1.Size = new System.Drawing.Size(945, 654);
            this.userControlPieces1.TabIndex = 14;
            // 
            // userControlVehiculescs1
            // 
            this.userControlVehiculescs1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlVehiculescs1.Location = new System.Drawing.Point(235, 160);
            this.userControlVehiculescs1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlVehiculescs1.Name = "userControlVehiculescs1";
            this.userControlVehiculescs1.Size = new System.Drawing.Size(945, 654);
            this.userControlVehiculescs1.TabIndex = 13;
            // 
            // userControlModeles1
            // 
            this.userControlModeles1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlModeles1.Location = new System.Drawing.Point(235, 157);
            this.userControlModeles1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlModeles1.Name = "userControlModeles1";
            this.userControlModeles1.Padding = new System.Windows.Forms.Padding(1);
            this.userControlModeles1.Size = new System.Drawing.Size(945, 654);
            this.userControlModeles1.TabIndex = 12;
            // 
            // userControlClients1
            // 
            this.userControlClients1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlClients1.Location = new System.Drawing.Point(235, 160);
            this.userControlClients1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlClients1.Name = "userControlClients1";
            this.userControlClients1.Size = new System.Drawing.Size(945, 654);
            this.userControlClients1.TabIndex = 11;
            // 
            // userControlAccueil1
            // 
            this.userControlAccueil1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlAccueil1.Location = new System.Drawing.Point(235, 164);
            this.userControlAccueil1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlAccueil1.Name = "userControlAccueil1";
            this.userControlAccueil1.Size = new System.Drawing.Size(945, 650);
            this.userControlAccueil1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1180, 814);
            this.Controls.Add(this.userControlEntretiens1);
            this.Controls.Add(this.userControlIntervetions1);
            this.Controls.Add(this.userControlPieces1);
            this.Controls.Add(this.userControlVehiculescs1);
            this.Controls.Add(this.userControlModeles1);
            this.Controls.Add(this.userControlClients1);
            this.Controls.Add(this.userControlAccueil1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.Button buttonEntretiens;
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
        private UserControlEntretiens userControlEntretiens1;
    }
}

