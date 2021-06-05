
namespace Alfa_Romeo_Garage
{
    partial class UserControlModeles
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
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonEditer = new System.Windows.Forms.Button();
            this.labelPuissanceMaximale = new System.Windows.Forms.Label();
            this.textBoxPuissanceMaximale = new System.Windows.Forms.TextBox();
            this.labelCylindree = new System.Windows.Forms.Label();
            this.textBoxCylindree = new System.Windows.Forms.TextBox();
            this.labelCarburant = new System.Windows.Forms.Label();
            this.textBoxCarburant = new System.Windows.Forms.TextBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelMotorisation = new System.Windows.Forms.Label();
            this.textBoxMotorisation = new System.Windows.Forms.TextBox();
            this.labelModele = new System.Windows.Forms.Label();
            this.textBoxModele = new System.Windows.Forms.TextBox();
            this.labelCoupleMaximal = new System.Windows.Forms.Label();
            this.textBoxCoupleMaximal = new System.Windows.Forms.TextBox();
            this.labelVitesseMaximale = new System.Windows.Forms.Label();
            this.textBoxVitesseMaximale = new System.Windows.Forms.TextBox();
            this.labelConsommation = new System.Windows.Forms.Label();
            this.textBoxConsommation = new System.Windows.Forms.TextBox();
            this.labelMasse = new System.Windows.Forms.Label();
            this.textBoxMasse = new System.Windows.Forms.TextBox();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMotorisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCarburant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCylindree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPuissanceMaximale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCoupleMaximal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVitesseMaximale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cConsommation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBorder = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.panelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.Crimson;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouter.Location = new System.Drawing.Point(21, 640);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(452, 39);
            this.buttonAjouter.TabIndex = 78;
            this.buttonAjouter.Text = "Ajouter un modèle";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonEditer
            // 
            this.buttonEditer.BackColor = System.Drawing.Color.Crimson;
            this.buttonEditer.FlatAppearance.BorderSize = 0;
            this.buttonEditer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditer.Location = new System.Drawing.Point(21, 693);
            this.buttonEditer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditer.Name = "buttonEditer";
            this.buttonEditer.Size = new System.Drawing.Size(452, 39);
            this.buttonEditer.TabIndex = 77;
            this.buttonEditer.Text = "Editer un modèle";
            this.buttonEditer.UseVisualStyleBackColor = false;
            this.buttonEditer.Click += new System.EventHandler(this.buttonEditer_Click);
            // 
            // labelPuissanceMaximale
            // 
            this.labelPuissanceMaximale.AutoSize = true;
            this.labelPuissanceMaximale.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuissanceMaximale.ForeColor = System.Drawing.Color.Crimson;
            this.labelPuissanceMaximale.Location = new System.Drawing.Point(19, 282);
            this.labelPuissanceMaximale.Name = "labelPuissanceMaximale";
            this.labelPuissanceMaximale.Size = new System.Drawing.Size(216, 19);
            this.labelPuissanceMaximale.TabIndex = 76;
            this.labelPuissanceMaximale.Text = "Puissance maximale (kW / ch)";
            // 
            // textBoxPuissanceMaximale
            // 
            this.textBoxPuissanceMaximale.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxPuissanceMaximale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPuissanceMaximale.ForeColor = System.Drawing.Color.White;
            this.textBoxPuissanceMaximale.Location = new System.Drawing.Point(22, 303);
            this.textBoxPuissanceMaximale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPuissanceMaximale.Name = "textBoxPuissanceMaximale";
            this.textBoxPuissanceMaximale.Size = new System.Drawing.Size(452, 22);
            this.textBoxPuissanceMaximale.TabIndex = 75;
            // 
            // labelCylindree
            // 
            this.labelCylindree.AutoSize = true;
            this.labelCylindree.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCylindree.ForeColor = System.Drawing.Color.Crimson;
            this.labelCylindree.Location = new System.Drawing.Point(19, 232);
            this.labelCylindree.Name = "labelCylindree";
            this.labelCylindree.Size = new System.Drawing.Size(119, 19);
            this.labelCylindree.TabIndex = 74;
            this.labelCylindree.Text = "Cylindrée (cm3)";
            // 
            // textBoxCylindree
            // 
            this.textBoxCylindree.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCylindree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCylindree.ForeColor = System.Drawing.Color.White;
            this.textBoxCylindree.Location = new System.Drawing.Point(22, 253);
            this.textBoxCylindree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCylindree.Name = "textBoxCylindree";
            this.textBoxCylindree.Size = new System.Drawing.Size(452, 22);
            this.textBoxCylindree.TabIndex = 73;
            // 
            // labelCarburant
            // 
            this.labelCarburant.AutoSize = true;
            this.labelCarburant.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarburant.ForeColor = System.Drawing.Color.Crimson;
            this.labelCarburant.Location = new System.Drawing.Point(19, 177);
            this.labelCarburant.Name = "labelCarburant";
            this.labelCarburant.Size = new System.Drawing.Size(81, 19);
            this.labelCarburant.TabIndex = 72;
            this.labelCarburant.Text = "Carburant";
            // 
            // textBoxCarburant
            // 
            this.textBoxCarburant.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCarburant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCarburant.ForeColor = System.Drawing.Color.White;
            this.textBoxCarburant.Location = new System.Drawing.Point(22, 198);
            this.textBoxCarburant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCarburant.Name = "textBoxCarburant";
            this.textBoxCarburant.Size = new System.Drawing.Size(452, 22);
            this.textBoxCarburant.TabIndex = 71;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Crimson;
            this.buttonSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimer.Location = new System.Drawing.Point(21, 747);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(452, 39);
            this.buttonSupprimer.TabIndex = 64;
            this.buttonSupprimer.Text = "Supprimer un modèle";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.Crimson;
            this.labelTitre.Location = new System.Drawing.Point(16, 26);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(283, 30);
            this.labelTitre.TabIndex = 63;
            this.labelTitre.Text = "GESTION DES MODÈLES";
            // 
            // labelMotorisation
            // 
            this.labelMotorisation.AutoSize = true;
            this.labelMotorisation.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotorisation.ForeColor = System.Drawing.Color.Crimson;
            this.labelMotorisation.Location = new System.Drawing.Point(19, 123);
            this.labelMotorisation.Name = "labelMotorisation";
            this.labelMotorisation.Size = new System.Drawing.Size(93, 19);
            this.labelMotorisation.TabIndex = 82;
            this.labelMotorisation.Text = "Motorisation";
            // 
            // textBoxMotorisation
            // 
            this.textBoxMotorisation.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxMotorisation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMotorisation.ForeColor = System.Drawing.Color.White;
            this.textBoxMotorisation.Location = new System.Drawing.Point(22, 144);
            this.textBoxMotorisation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMotorisation.Name = "textBoxMotorisation";
            this.textBoxMotorisation.Size = new System.Drawing.Size(452, 22);
            this.textBoxMotorisation.TabIndex = 81;
            // 
            // labelModele
            // 
            this.labelModele.AutoSize = true;
            this.labelModele.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModele.ForeColor = System.Drawing.Color.Crimson;
            this.labelModele.Location = new System.Drawing.Point(19, 70);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(62, 19);
            this.labelModele.TabIndex = 80;
            this.labelModele.Text = "Modèle";
            // 
            // textBoxModele
            // 
            this.textBoxModele.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxModele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModele.ForeColor = System.Drawing.Color.White;
            this.textBoxModele.Location = new System.Drawing.Point(22, 91);
            this.textBoxModele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxModele.Name = "textBoxModele";
            this.textBoxModele.Size = new System.Drawing.Size(452, 22);
            this.textBoxModele.TabIndex = 79;
            // 
            // labelCoupleMaximal
            // 
            this.labelCoupleMaximal.AutoSize = true;
            this.labelCoupleMaximal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoupleMaximal.ForeColor = System.Drawing.Color.Crimson;
            this.labelCoupleMaximal.Location = new System.Drawing.Point(19, 333);
            this.labelCoupleMaximal.Name = "labelCoupleMaximal";
            this.labelCoupleMaximal.Size = new System.Drawing.Size(164, 19);
            this.labelCoupleMaximal.TabIndex = 84;
            this.labelCoupleMaximal.Text = "Couple maximal (N m)";
            // 
            // textBoxCoupleMaximal
            // 
            this.textBoxCoupleMaximal.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCoupleMaximal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCoupleMaximal.ForeColor = System.Drawing.Color.White;
            this.textBoxCoupleMaximal.Location = new System.Drawing.Point(22, 354);
            this.textBoxCoupleMaximal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCoupleMaximal.Name = "textBoxCoupleMaximal";
            this.textBoxCoupleMaximal.Size = new System.Drawing.Size(452, 22);
            this.textBoxCoupleMaximal.TabIndex = 83;
            // 
            // labelVitesseMaximale
            // 
            this.labelVitesseMaximale.AutoSize = true;
            this.labelVitesseMaximale.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVitesseMaximale.ForeColor = System.Drawing.Color.Crimson;
            this.labelVitesseMaximale.Location = new System.Drawing.Point(19, 387);
            this.labelVitesseMaximale.Name = "labelVitesseMaximale";
            this.labelVitesseMaximale.Size = new System.Drawing.Size(183, 19);
            this.labelVitesseMaximale.TabIndex = 86;
            this.labelVitesseMaximale.Text = "Vitesse maximale (km / h)";
            // 
            // textBoxVitesseMaximale
            // 
            this.textBoxVitesseMaximale.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxVitesseMaximale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVitesseMaximale.ForeColor = System.Drawing.Color.White;
            this.textBoxVitesseMaximale.Location = new System.Drawing.Point(22, 408);
            this.textBoxVitesseMaximale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVitesseMaximale.Name = "textBoxVitesseMaximale";
            this.textBoxVitesseMaximale.Size = new System.Drawing.Size(452, 22);
            this.textBoxVitesseMaximale.TabIndex = 85;
            // 
            // labelConsommation
            // 
            this.labelConsommation.AutoSize = true;
            this.labelConsommation.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsommation.ForeColor = System.Drawing.Color.Crimson;
            this.labelConsommation.Location = new System.Drawing.Point(19, 443);
            this.labelConsommation.Name = "labelConsommation";
            this.labelConsommation.Size = new System.Drawing.Size(196, 19);
            this.labelConsommation.TabIndex = 88;
            this.labelConsommation.Text = "Consommation (L / 100 km)";
            // 
            // textBoxConsommation
            // 
            this.textBoxConsommation.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxConsommation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConsommation.ForeColor = System.Drawing.Color.White;
            this.textBoxConsommation.Location = new System.Drawing.Point(22, 464);
            this.textBoxConsommation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsommation.Name = "textBoxConsommation";
            this.textBoxConsommation.Size = new System.Drawing.Size(452, 22);
            this.textBoxConsommation.TabIndex = 87;
            // 
            // labelMasse
            // 
            this.labelMasse.AutoSize = true;
            this.labelMasse.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasse.ForeColor = System.Drawing.Color.Crimson;
            this.labelMasse.Location = new System.Drawing.Point(19, 493);
            this.labelMasse.Name = "labelMasse";
            this.labelMasse.Size = new System.Drawing.Size(81, 19);
            this.labelMasse.TabIndex = 90;
            this.labelMasse.Text = "Masse (kg)";
            // 
            // textBoxMasse
            // 
            this.textBoxMasse.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxMasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMasse.ForeColor = System.Drawing.Color.White;
            this.textBoxMasse.Location = new System.Drawing.Point(22, 514);
            this.textBoxMasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMasse.Name = "textBoxMasse";
            this.textBoxMasse.Size = new System.Drawing.Size(452, 22);
            this.textBoxMasse.TabIndex = 89;
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.BackColor = System.Drawing.Color.Crimson;
            this.buttonConfirmer.FlatAppearance.BorderSize = 0;
            this.buttonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmer.Location = new System.Drawing.Point(20, 640);
            this.buttonConfirmer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(452, 39);
            this.buttonConfirmer.TabIndex = 80;
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
            this.buttonAnnuler.Location = new System.Drawing.Point(21, 693);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(452, 39);
            this.buttonAnnuler.TabIndex = 79;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClients.ColumnHeadersHeight = 29;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cModele,
            this.cMotorisation,
            this.cCarburant,
            this.cCylindree,
            this.cPuissanceMaximale,
            this.cCoupleMaximal,
            this.cVitesseMaximale,
            this.cConsommation,
            this.cMasse});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClients.GridColor = System.Drawing.Color.White;
            this.dataGridViewClients.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(742, 693);
            this.dataGridViewClients.TabIndex = 92;
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
            // cModele
            // 
            this.cModele.DataPropertyName = "modele";
            this.cModele.HeaderText = "Modèle";
            this.cModele.MinimumWidth = 6;
            this.cModele.Name = "cModele";
            this.cModele.ReadOnly = true;
            this.cModele.Width = 125;
            // 
            // cMotorisation
            // 
            this.cMotorisation.DataPropertyName = "motorisation";
            this.cMotorisation.HeaderText = "Motorisation";
            this.cMotorisation.MinimumWidth = 6;
            this.cMotorisation.Name = "cMotorisation";
            this.cMotorisation.ReadOnly = true;
            this.cMotorisation.Width = 180;
            // 
            // cCarburant
            // 
            this.cCarburant.DataPropertyName = "carburant";
            this.cCarburant.HeaderText = "Carburant";
            this.cCarburant.MinimumWidth = 6;
            this.cCarburant.Name = "cCarburant";
            this.cCarburant.ReadOnly = true;
            this.cCarburant.Width = 150;
            // 
            // cCylindree
            // 
            this.cCylindree.DataPropertyName = "cylindree";
            this.cCylindree.HeaderText = "Cylindrée";
            this.cCylindree.MinimumWidth = 6;
            this.cCylindree.Name = "cCylindree";
            this.cCylindree.ReadOnly = true;
            this.cCylindree.Width = 150;
            // 
            // cPuissanceMaximale
            // 
            this.cPuissanceMaximale.DataPropertyName = "puissanceMaximale";
            this.cPuissanceMaximale.HeaderText = "Puissance maximale";
            this.cPuissanceMaximale.MinimumWidth = 6;
            this.cPuissanceMaximale.Name = "cPuissanceMaximale";
            this.cPuissanceMaximale.ReadOnly = true;
            this.cPuissanceMaximale.Width = 280;
            // 
            // cCoupleMaximal
            // 
            this.cCoupleMaximal.DataPropertyName = "coupleMaximal";
            this.cCoupleMaximal.HeaderText = "Couple maximal";
            this.cCoupleMaximal.MinimumWidth = 6;
            this.cCoupleMaximal.Name = "cCoupleMaximal";
            this.cCoupleMaximal.ReadOnly = true;
            this.cCoupleMaximal.Width = 190;
            // 
            // cVitesseMaximale
            // 
            this.cVitesseMaximale.DataPropertyName = "vitesseMaximale";
            this.cVitesseMaximale.HeaderText = "Vitesse maximale";
            this.cVitesseMaximale.MinimumWidth = 6;
            this.cVitesseMaximale.Name = "cVitesseMaximale";
            this.cVitesseMaximale.ReadOnly = true;
            this.cVitesseMaximale.Width = 150;
            // 
            // cConsommation
            // 
            this.cConsommation.DataPropertyName = "consommation";
            this.cConsommation.HeaderText = "Consommation";
            this.cConsommation.MinimumWidth = 6;
            this.cConsommation.Name = "cConsommation";
            this.cConsommation.ReadOnly = true;
            this.cConsommation.Width = 150;
            // 
            // cMasse
            // 
            this.cMasse.DataPropertyName = "masse";
            this.cMasse.HeaderText = "Masse";
            this.cMasse.MinimumWidth = 6;
            this.cMasse.Name = "cMasse";
            this.cMasse.ReadOnly = true;
            this.cMasse.Width = 125;
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.White;
            this.panelBorder.Controls.Add(this.dataGridViewClients);
            this.panelBorder.Location = new System.Drawing.Point(495, 91);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Padding = new System.Windows.Forms.Padding(1);
            this.panelBorder.Size = new System.Drawing.Size(744, 695);
            this.panelBorder.TabIndex = 93;
            // 
            // UserControlModeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelMasse);
            this.Controls.Add(this.textBoxMasse);
            this.Controls.Add(this.labelConsommation);
            this.Controls.Add(this.textBoxConsommation);
            this.Controls.Add(this.labelVitesseMaximale);
            this.Controls.Add(this.textBoxVitesseMaximale);
            this.Controls.Add(this.labelCoupleMaximal);
            this.Controls.Add(this.textBoxCoupleMaximal);
            this.Controls.Add(this.labelMotorisation);
            this.Controls.Add(this.textBoxMotorisation);
            this.Controls.Add(this.labelModele);
            this.Controls.Add(this.textBoxModele);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonEditer);
            this.Controls.Add(this.labelPuissanceMaximale);
            this.Controls.Add(this.textBoxPuissanceMaximale);
            this.Controls.Add(this.labelCylindree);
            this.Controls.Add(this.textBoxCylindree);
            this.Controls.Add(this.labelCarburant);
            this.Controls.Add(this.textBoxCarburant);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.labelTitre);
            this.Name = "UserControlModeles";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(1260, 805);
            this.Load += new System.EventHandler(this.UserControlModeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.panelBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.Label labelPuissanceMaximale;
        private System.Windows.Forms.TextBox textBoxPuissanceMaximale;
        private System.Windows.Forms.Label labelCylindree;
        private System.Windows.Forms.TextBox textBoxCylindree;
        private System.Windows.Forms.Label labelCarburant;
        private System.Windows.Forms.TextBox textBoxCarburant;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelMotorisation;
        private System.Windows.Forms.TextBox textBoxMotorisation;
        private System.Windows.Forms.Label labelModele;
        private System.Windows.Forms.TextBox textBoxModele;
        private System.Windows.Forms.Label labelCoupleMaximal;
        private System.Windows.Forms.TextBox textBoxCoupleMaximal;
        private System.Windows.Forms.Label labelVitesseMaximale;
        private System.Windows.Forms.TextBox textBoxVitesseMaximale;
        private System.Windows.Forms.Label labelConsommation;
        private System.Windows.Forms.TextBox textBoxConsommation;
        private System.Windows.Forms.Label labelMasse;
        private System.Windows.Forms.TextBox textBoxMasse;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMotorisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCarburant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCylindree;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPuissanceMaximale;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCoupleMaximal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVitesseMaximale;
        private System.Windows.Forms.DataGridViewTextBoxColumn cConsommation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMasse;
        private System.Windows.Forms.Panel panelBorder;
    }
}
