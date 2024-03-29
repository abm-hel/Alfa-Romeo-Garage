﻿
namespace Alfa_Romeo_Garage
{
    partial class UserControlClients
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonEditer = new System.Windows.Forms.Button();
            this.buttonSupprimerClient = new System.Windows.Forms.Button();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelNumeroNational = new System.Windows.Forms.Label();
            this.textBoxNumeroNational = new System.Windows.Forms.TextBox();
            this.labelDateNaissance = new System.Windows.Forms.Label();
            this.labelRue = new System.Windows.Forms.Label();
            this.textBoxRue = new System.Windows.Forms.TextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelPays = new System.Windows.Forms.Label();
            this.textBoxPays = new System.Windows.Forms.TextBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.labelAdresseEmail = new System.Windows.Forms.Label();
            this.textBoxAdresseEmail = new System.Windows.Forms.TextBox();
            this.labelNumeroTelephone = new System.Windows.Forms.Label();
            this.textBoxNumeroTelephone = new System.Windows.Forms.TextBox();
            this.groupBoxInformationsPersonnelles = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateNaissance = new CustomControls.RJControls.RJDatePicker();
            this.groupBoxContact = new System.Windows.Forms.GroupBox();
            this.groupBoxAdresse = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNomPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroNational = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdresseEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateEnregistrement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInformationsPersonnelles.SuspendLayout();
            this.groupBoxContact.SuspendLayout();
            this.groupBoxAdresse.SuspendLayout();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.Crimson;
            this.labelTitre.Location = new System.Drawing.Point(18, 24);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(263, 30);
            this.labelTitre.TabIndex = 4;
            this.labelTitre.Text = "GESTION DES CLIENTS\r\n";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.Crimson;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouter.Location = new System.Drawing.Point(23, 628);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(471, 39);
            this.buttonAjouter.TabIndex = 7;
            this.buttonAjouter.Text = "Ajouter un client";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouterClient_Click);
            // 
            // buttonEditer
            // 
            this.buttonEditer.BackColor = System.Drawing.Color.Crimson;
            this.buttonEditer.FlatAppearance.BorderSize = 0;
            this.buttonEditer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditer.Location = new System.Drawing.Point(23, 682);
            this.buttonEditer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditer.Name = "buttonEditer";
            this.buttonEditer.Size = new System.Drawing.Size(471, 39);
            this.buttonEditer.TabIndex = 8;
            this.buttonEditer.Text = "Editer un client";
            this.buttonEditer.UseVisualStyleBackColor = false;
            this.buttonEditer.Click += new System.EventHandler(this.buttonEditerClient_Click);
            // 
            // buttonSupprimerClient
            // 
            this.buttonSupprimerClient.BackColor = System.Drawing.Color.Crimson;
            this.buttonSupprimerClient.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSupprimerClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerClient.Location = new System.Drawing.Point(23, 739);
            this.buttonSupprimerClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupprimerClient.Name = "buttonSupprimerClient";
            this.buttonSupprimerClient.Size = new System.Drawing.Size(471, 39);
            this.buttonSupprimerClient.TabIndex = 9;
            this.buttonSupprimerClient.Text = "Supprimer un client";
            this.buttonSupprimerClient.UseVisualStyleBackColor = false;
            this.buttonSupprimerClient.Click += new System.EventHandler(this.buttonSupprimerClient_Click);
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.BackColor = System.Drawing.Color.Crimson;
            this.buttonConfirmer.FlatAppearance.BorderSize = 0;
            this.buttonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmer.Location = new System.Drawing.Point(23, 628);
            this.buttonConfirmer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(471, 39);
            this.buttonConfirmer.TabIndex = 10;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = false;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmerClient_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Crimson;
            this.buttonAnnuler.FlatAppearance.BorderSize = 0;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(23, 682);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(471, 39);
            this.buttonAnnuler.TabIndex = 11;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnulerClient_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNom.ForeColor = System.Drawing.Color.White;
            this.textBoxNom.Location = new System.Drawing.Point(9, 47);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(218, 23);
            this.textBoxNom.TabIndex = 12;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.Crimson;
            this.labelNom.Location = new System.Drawing.Point(5, 25);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(41, 19);
            this.labelNom.TabIndex = 13;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.ForeColor = System.Drawing.Color.Crimson;
            this.labelPrenom.Location = new System.Drawing.Point(236, 25);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(61, 19);
            this.labelPrenom.TabIndex = 16;
            this.labelPrenom.Text = "Prénom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrenom.ForeColor = System.Drawing.Color.White;
            this.textBoxPrenom.Location = new System.Drawing.Point(240, 47);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(220, 23);
            this.textBoxPrenom.TabIndex = 15;
            // 
            // labelNumeroNational
            // 
            this.labelNumeroNational.AutoSize = true;
            this.labelNumeroNational.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroNational.ForeColor = System.Drawing.Color.Crimson;
            this.labelNumeroNational.Location = new System.Drawing.Point(6, 137);
            this.labelNumeroNational.Name = "labelNumeroNational";
            this.labelNumeroNational.Size = new System.Drawing.Size(200, 19);
            this.labelNumeroNational.TabIndex = 18;
            this.labelNumeroNational.Text = "Numéro de registre national";
            // 
            // textBoxNumeroNational
            // 
            this.textBoxNumeroNational.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxNumeroNational.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumeroNational.ForeColor = System.Drawing.Color.White;
            this.textBoxNumeroNational.Location = new System.Drawing.Point(10, 158);
            this.textBoxNumeroNational.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumeroNational.Name = "textBoxNumeroNational";
            this.textBoxNumeroNational.Size = new System.Drawing.Size(452, 23);
            this.textBoxNumeroNational.TabIndex = 17;
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateNaissance.ForeColor = System.Drawing.Color.Crimson;
            this.labelDateNaissance.Location = new System.Drawing.Point(6, 72);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(139, 19);
            this.labelDateNaissance.TabIndex = 20;
            this.labelDateNaissance.Text = "Date de naissance";
            // 
            // labelRue
            // 
            this.labelRue.AutoSize = true;
            this.labelRue.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRue.ForeColor = System.Drawing.Color.Crimson;
            this.labelRue.Location = new System.Drawing.Point(2, 26);
            this.labelRue.Name = "labelRue";
            this.labelRue.Size = new System.Drawing.Size(36, 19);
            this.labelRue.TabIndex = 23;
            this.labelRue.Text = "Rue";
            // 
            // textBoxRue
            // 
            this.textBoxRue.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxRue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRue.ForeColor = System.Drawing.Color.White;
            this.textBoxRue.Location = new System.Drawing.Point(8, 48);
            this.textBoxRue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRue.Name = "textBoxRue";
            this.textBoxRue.Size = new System.Drawing.Size(452, 23);
            this.textBoxRue.TabIndex = 22;
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodePostal.ForeColor = System.Drawing.Color.Crimson;
            this.labelCodePostal.Location = new System.Drawing.Point(225, 85);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(92, 19);
            this.labelCodePostal.TabIndex = 27;
            this.labelCodePostal.Text = "Code Postal";
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodePostal.ForeColor = System.Drawing.Color.White;
            this.textBoxCodePostal.Location = new System.Drawing.Point(229, 106);
            this.textBoxCodePostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(231, 23);
            this.textBoxCodePostal.TabIndex = 26;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.ForeColor = System.Drawing.Color.Crimson;
            this.labelNumero.Location = new System.Drawing.Point(2, 85);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(63, 19);
            this.labelNumero.TabIndex = 25;
            this.labelNumero.Text = "Numéro";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumero.ForeColor = System.Drawing.Color.White;
            this.textBoxNumero.Location = new System.Drawing.Point(5, 106);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(211, 23);
            this.textBoxNumero.TabIndex = 24;
            // 
            // labelPays
            // 
            this.labelPays.AutoSize = true;
            this.labelPays.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPays.ForeColor = System.Drawing.Color.Crimson;
            this.labelPays.Location = new System.Drawing.Point(225, 139);
            this.labelPays.Name = "labelPays";
            this.labelPays.Size = new System.Drawing.Size(40, 19);
            this.labelPays.TabIndex = 31;
            this.labelPays.Text = "Pays";
            // 
            // textBoxPays
            // 
            this.textBoxPays.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPays.ForeColor = System.Drawing.Color.White;
            this.textBoxPays.Location = new System.Drawing.Point(229, 160);
            this.textBoxPays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPays.Name = "textBoxPays";
            this.textBoxPays.Size = new System.Drawing.Size(231, 23);
            this.textBoxPays.TabIndex = 30;
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVille.ForeColor = System.Drawing.Color.Crimson;
            this.labelVille.Location = new System.Drawing.Point(4, 138);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(36, 19);
            this.labelVille.TabIndex = 29;
            this.labelVille.Text = "Ville";
            // 
            // textBoxVille
            // 
            this.textBoxVille.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVille.ForeColor = System.Drawing.Color.White;
            this.textBoxVille.Location = new System.Drawing.Point(8, 160);
            this.textBoxVille.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(208, 23);
            this.textBoxVille.TabIndex = 28;
            // 
            // labelAdresseEmail
            // 
            this.labelAdresseEmail.AutoSize = true;
            this.labelAdresseEmail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresseEmail.ForeColor = System.Drawing.Color.Crimson;
            this.labelAdresseEmail.Location = new System.Drawing.Point(4, 81);
            this.labelAdresseEmail.Name = "labelAdresseEmail";
            this.labelAdresseEmail.Size = new System.Drawing.Size(107, 19);
            this.labelAdresseEmail.TabIndex = 35;
            this.labelAdresseEmail.Text = "Adresse e-mail";
            // 
            // textBoxAdresseEmail
            // 
            this.textBoxAdresseEmail.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxAdresseEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAdresseEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxAdresseEmail.Location = new System.Drawing.Point(8, 103);
            this.textBoxAdresseEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAdresseEmail.Name = "textBoxAdresseEmail";
            this.textBoxAdresseEmail.Size = new System.Drawing.Size(450, 23);
            this.textBoxAdresseEmail.TabIndex = 34;
            // 
            // labelNumeroTelephone
            // 
            this.labelNumeroTelephone.AutoSize = true;
            this.labelNumeroTelephone.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroTelephone.ForeColor = System.Drawing.Color.Crimson;
            this.labelNumeroTelephone.Location = new System.Drawing.Point(4, 27);
            this.labelNumeroTelephone.Name = "labelNumeroTelephone";
            this.labelNumeroTelephone.Size = new System.Drawing.Size(162, 19);
            this.labelNumeroTelephone.TabIndex = 33;
            this.labelNumeroTelephone.Text = "Numéro de télephone";
            // 
            // textBoxNumeroTelephone
            // 
            this.textBoxNumeroTelephone.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxNumeroTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumeroTelephone.ForeColor = System.Drawing.Color.White;
            this.textBoxNumeroTelephone.Location = new System.Drawing.Point(8, 49);
            this.textBoxNumeroTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumeroTelephone.Name = "textBoxNumeroTelephone";
            this.textBoxNumeroTelephone.Size = new System.Drawing.Size(452, 23);
            this.textBoxNumeroTelephone.TabIndex = 32;
            // 
            // groupBoxInformationsPersonnelles
            // 
            this.groupBoxInformationsPersonnelles.Controls.Add(this.dateTimePickerDateNaissance);
            this.groupBoxInformationsPersonnelles.Controls.Add(this.labelNom);
            this.groupBoxInformationsPersonnelles.Controls.Add(this.labelDateNaissance);
            this.groupBoxInformationsPersonnelles.Controls.Add(this.labelNumeroNational);
            this.groupBoxInformationsPersonnelles.Controls.Add(this.textBoxNom);
            this.groupBoxInformationsPersonnelles.Controls.Add(this.textBoxPrenom);
            this.groupBoxInformationsPersonnelles.Controls.Add(this.labelPrenom);
            this.groupBoxInformationsPersonnelles.Controls.Add(this.textBoxNumeroNational);
            this.groupBoxInformationsPersonnelles.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformationsPersonnelles.ForeColor = System.Drawing.Color.White;
            this.groupBoxInformationsPersonnelles.Location = new System.Drawing.Point(23, 70);
            this.groupBoxInformationsPersonnelles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInformationsPersonnelles.Name = "groupBoxInformationsPersonnelles";
            this.groupBoxInformationsPersonnelles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInformationsPersonnelles.Size = new System.Drawing.Size(471, 199);
            this.groupBoxInformationsPersonnelles.TabIndex = 36;
            this.groupBoxInformationsPersonnelles.TabStop = false;
            this.groupBoxInformationsPersonnelles.Text = "Informations personnelles";
            // 
            // dateTimePickerDateNaissance
            // 
            this.dateTimePickerDateNaissance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePickerDateNaissance.BorderSize = 1;
            this.dateTimePickerDateNaissance.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateNaissance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateNaissance.Location = new System.Drawing.Point(10, 94);
            this.dateTimePickerDateNaissance.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePickerDateNaissance.Name = "dateTimePickerDateNaissance";
            this.dateTimePickerDateNaissance.Size = new System.Drawing.Size(452, 35);
            this.dateTimePickerDateNaissance.SkinColor = System.Drawing.Color.Black;
            this.dateTimePickerDateNaissance.TabIndex = 40;
            this.dateTimePickerDateNaissance.TextColor = System.Drawing.Color.White;
            // 
            // groupBoxContact
            // 
            this.groupBoxContact.Controls.Add(this.textBoxNumeroTelephone);
            this.groupBoxContact.Controls.Add(this.labelNumeroTelephone);
            this.groupBoxContact.Controls.Add(this.textBoxAdresseEmail);
            this.groupBoxContact.Controls.Add(this.labelAdresseEmail);
            this.groupBoxContact.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxContact.ForeColor = System.Drawing.Color.White;
            this.groupBoxContact.Location = new System.Drawing.Point(23, 469);
            this.groupBoxContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxContact.Name = "groupBoxContact";
            this.groupBoxContact.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxContact.Size = new System.Drawing.Size(471, 137);
            this.groupBoxContact.TabIndex = 37;
            this.groupBoxContact.TabStop = false;
            this.groupBoxContact.Text = "Coordonnées";
            // 
            // groupBoxAdresse
            // 
            this.groupBoxAdresse.Controls.Add(this.labelRue);
            this.groupBoxAdresse.Controls.Add(this.textBoxRue);
            this.groupBoxAdresse.Controls.Add(this.textBoxNumero);
            this.groupBoxAdresse.Controls.Add(this.labelNumero);
            this.groupBoxAdresse.Controls.Add(this.textBoxCodePostal);
            this.groupBoxAdresse.Controls.Add(this.labelCodePostal);
            this.groupBoxAdresse.Controls.Add(this.textBoxVille);
            this.groupBoxAdresse.Controls.Add(this.labelPays);
            this.groupBoxAdresse.Controls.Add(this.labelVille);
            this.groupBoxAdresse.Controls.Add(this.textBoxPays);
            this.groupBoxAdresse.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdresse.ForeColor = System.Drawing.Color.White;
            this.groupBoxAdresse.Location = new System.Drawing.Point(23, 273);
            this.groupBoxAdresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAdresse.Name = "groupBoxAdresse";
            this.groupBoxAdresse.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAdresse.Size = new System.Drawing.Size(471, 192);
            this.groupBoxAdresse.TabIndex = 37;
            this.groupBoxAdresse.TabStop = false;
            this.groupBoxAdresse.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.White;
            this.panelBorder.Controls.Add(this.dataGridViewClients);
            this.panelBorder.Location = new System.Drawing.Point(514, 70);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Padding = new System.Windows.Forms.Padding(1);
            this.panelBorder.Size = new System.Drawing.Size(680, 708);
            this.panelBorder.TabIndex = 39;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClients.ColumnHeadersHeight = 29;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNomPrenom,
            this.cDateNaissance,
            this.cNumeroNational,
            this.cAdresse,
            this.cAdresseEmail,
            this.cNumeroTelephone,
            this.cDateEnregistrement});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClients.GridColor = System.Drawing.Color.White;
            this.dataGridViewClients.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(678, 706);
            this.dataGridViewClients.TabIndex = 40;
            this.dataGridViewClients.VirtualMode = true;
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
            // cNomPrenom
            // 
            this.cNomPrenom.DataPropertyName = "nomPrenom";
            this.cNomPrenom.HeaderText = "Nom complet";
            this.cNomPrenom.MinimumWidth = 6;
            this.cNomPrenom.Name = "cNomPrenom";
            this.cNomPrenom.ReadOnly = true;
            this.cNomPrenom.Width = 180;
            // 
            // cDateNaissance
            // 
            this.cDateNaissance.DataPropertyName = "dateNaissance";
            this.cDateNaissance.HeaderText = "Date de naissance";
            this.cDateNaissance.MinimumWidth = 6;
            this.cDateNaissance.Name = "cDateNaissance";
            this.cDateNaissance.ReadOnly = true;
            this.cDateNaissance.Width = 150;
            // 
            // cNumeroNational
            // 
            this.cNumeroNational.DataPropertyName = "numeroNational";
            this.cNumeroNational.HeaderText = "Numéro du registre national";
            this.cNumeroNational.MinimumWidth = 6;
            this.cNumeroNational.Name = "cNumeroNational";
            this.cNumeroNational.ReadOnly = true;
            this.cNumeroNational.Width = 150;
            // 
            // cAdresse
            // 
            this.cAdresse.DataPropertyName = "adresse";
            this.cAdresse.HeaderText = "Adresse";
            this.cAdresse.MinimumWidth = 6;
            this.cAdresse.Name = "cAdresse";
            this.cAdresse.ReadOnly = true;
            this.cAdresse.Width = 280;
            // 
            // cAdresseEmail
            // 
            this.cAdresseEmail.DataPropertyName = "adresseEmail";
            this.cAdresseEmail.HeaderText = "Adresse e-mail";
            this.cAdresseEmail.MinimumWidth = 6;
            this.cAdresseEmail.Name = "cAdresseEmail";
            this.cAdresseEmail.ReadOnly = true;
            this.cAdresseEmail.Width = 190;
            // 
            // cNumeroTelephone
            // 
            this.cNumeroTelephone.DataPropertyName = "numeroTelephone";
            this.cNumeroTelephone.HeaderText = "Numéro de télephone";
            this.cNumeroTelephone.MinimumWidth = 6;
            this.cNumeroTelephone.Name = "cNumeroTelephone";
            this.cNumeroTelephone.ReadOnly = true;
            this.cNumeroTelephone.Width = 150;
            // 
            // cDateEnregistrement
            // 
            this.cDateEnregistrement.DataPropertyName = "dateEnregistrement";
            this.cDateEnregistrement.HeaderText = "Date de dernière modification";
            this.cDateEnregistrement.MinimumWidth = 6;
            this.cDateEnregistrement.Name = "cDateEnregistrement";
            this.cDateEnregistrement.ReadOnly = true;
            this.cDateEnregistrement.Width = 150;
            // 
            // UserControlClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.groupBoxContact);
            this.Controls.Add(this.groupBoxAdresse);
            this.Controls.Add(this.groupBoxInformationsPersonnelles);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSupprimerClient);
            this.Controls.Add(this.buttonEditer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelTitre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlClients";
            this.Size = new System.Drawing.Size(1211, 825);
            this.Load += new System.EventHandler(this.UserControlClients_Load);
            this.groupBoxInformationsPersonnelles.ResumeLayout(false);
            this.groupBoxInformationsPersonnelles.PerformLayout();
            this.groupBoxContact.ResumeLayout(false);
            this.groupBoxContact.PerformLayout();
            this.groupBoxAdresse.ResumeLayout(false);
            this.groupBoxAdresse.PerformLayout();
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.Button buttonSupprimerClient;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelNumeroNational;
        private System.Windows.Forms.TextBox textBoxNumeroNational;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelRue;
        private System.Windows.Forms.TextBox textBoxRue;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelPays;
        private System.Windows.Forms.TextBox textBoxPays;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Label labelAdresseEmail;
        private System.Windows.Forms.TextBox textBoxAdresseEmail;
        private System.Windows.Forms.Label labelNumeroTelephone;
        private System.Windows.Forms.TextBox textBoxNumeroTelephone;
        private System.Windows.Forms.GroupBox groupBoxInformationsPersonnelles;
        private System.Windows.Forms.GroupBox groupBoxContact;
        private System.Windows.Forms.GroupBox groupBoxAdresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBorder;
        private CustomControls.RJControls.RJDatePicker dateTimePickerDateNaissance;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNomPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroNational;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdresseEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateEnregistrement;
    }
}
