
namespace Alfa_Romeo_Garage
{
    partial class UserControlVehicules
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
            this.dataGridviewV = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModeleVehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNomProprietaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroImmatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDatePremiereImmatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDerniereImmatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroChassis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCouleurVehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateEnregistrement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelImmatriculation = new System.Windows.Forms.Label();
            this.labelDatePremiereImmatriculation = new System.Windows.Forms.Label();
            this.labelDerniereImmatriculation = new System.Windows.Forms.Label();
            this.textBoxImmatriculation = new System.Windows.Forms.TextBox();
            this.labelClasse = new System.Windows.Forms.Label();
            this.textBoxClasse = new System.Windows.Forms.TextBox();
            this.labelNumeroChassis = new System.Windows.Forms.Label();
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.labelCouleurVehicule = new System.Windows.Forms.Label();
            this.textBoxCouleurVehicule = new System.Windows.Forms.TextBox();
            this.buttonEditer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.labelProprietaire = new System.Windows.Forms.Label();
            this.labelModele = new System.Windows.Forms.Label();
            this.comboBoxProprietaire = new System.Windows.Forms.ComboBox();
            this.comboBoxModele = new System.Windows.Forms.ComboBox();
            this.DateTimePickerDerniereImmatriculation = new CustomControls.RJControls.RJDatePicker();
            this.dateTimePickerDatePremiereImmatriculation = new CustomControls.RJControls.RJDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewV)).BeginInit();
            this.panelBorder.SuspendLayout();
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
            this.cModeleVehicule,
            this.cNomProprietaire,
            this.cNumeroImmatriculation,
            this.cDatePremiereImmatriculation,
            this.cDateDerniereImmatriculation,
            this.cClasse,
            this.cNumeroChassis,
            this.cCouleurVehicule,
            this.cDateEnregistrement});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridviewV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridviewV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridviewV.GridColor = System.Drawing.Color.White;
            this.dataGridviewV.Location = new System.Drawing.Point(1, 1);
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
            this.dataGridviewV.Size = new System.Drawing.Size(690, 675);
            this.dataGridviewV.TabIndex = 48;
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
            // cModeleVehicule
            // 
            this.cModeleVehicule.DataPropertyName = "modeleVehicule";
            this.cModeleVehicule.HeaderText = "Modèle du véhicule";
            this.cModeleVehicule.MinimumWidth = 6;
            this.cModeleVehicule.Name = "cModeleVehicule";
            this.cModeleVehicule.ReadOnly = true;
            this.cModeleVehicule.Width = 125;
            // 
            // cNomProprietaire
            // 
            this.cNomProprietaire.DataPropertyName = "nomProprietaire";
            this.cNomProprietaire.HeaderText = "Nom du propriétaire";
            this.cNomProprietaire.MinimumWidth = 6;
            this.cNomProprietaire.Name = "cNomProprietaire";
            this.cNomProprietaire.ReadOnly = true;
            this.cNomProprietaire.Width = 125;
            // 
            // cNumeroImmatriculation
            // 
            this.cNumeroImmatriculation.DataPropertyName = "numeroImmatriculation";
            this.cNumeroImmatriculation.HeaderText = "Numéro d\'immatriculation";
            this.cNumeroImmatriculation.MinimumWidth = 6;
            this.cNumeroImmatriculation.Name = "cNumeroImmatriculation";
            this.cNumeroImmatriculation.ReadOnly = true;
            this.cNumeroImmatriculation.Width = 180;
            // 
            // cDatePremiereImmatriculation
            // 
            this.cDatePremiereImmatriculation.DataPropertyName = "datePremiereImmatriculation";
            this.cDatePremiereImmatriculation.HeaderText = "Date première immatriculation";
            this.cDatePremiereImmatriculation.MinimumWidth = 6;
            this.cDatePremiereImmatriculation.Name = "cDatePremiereImmatriculation";
            this.cDatePremiereImmatriculation.ReadOnly = true;
            this.cDatePremiereImmatriculation.Width = 150;
            // 
            // cDateDerniereImmatriculation
            // 
            this.cDateDerniereImmatriculation.DataPropertyName = "dateDerniereImmatriculation";
            this.cDateDerniereImmatriculation.HeaderText = "Date dernière immatriculation";
            this.cDateDerniereImmatriculation.MinimumWidth = 6;
            this.cDateDerniereImmatriculation.Name = "cDateDerniereImmatriculation";
            this.cDateDerniereImmatriculation.ReadOnly = true;
            this.cDateDerniereImmatriculation.Width = 150;
            // 
            // cClasse
            // 
            this.cClasse.DataPropertyName = "classe";
            this.cClasse.HeaderText = "Classe environnementale";
            this.cClasse.MinimumWidth = 6;
            this.cClasse.Name = "cClasse";
            this.cClasse.ReadOnly = true;
            this.cClasse.Width = 280;
            // 
            // cNumeroChassis
            // 
            this.cNumeroChassis.DataPropertyName = "numeroChassis";
            this.cNumeroChassis.HeaderText = "Numéro de chassis NIV";
            this.cNumeroChassis.MinimumWidth = 6;
            this.cNumeroChassis.Name = "cNumeroChassis";
            this.cNumeroChassis.ReadOnly = true;
            this.cNumeroChassis.Width = 190;
            // 
            // cCouleurVehicule
            // 
            this.cCouleurVehicule.DataPropertyName = "couleurVehicule";
            this.cCouleurVehicule.HeaderText = "Couleur du véhicule";
            this.cCouleurVehicule.MinimumWidth = 6;
            this.cCouleurVehicule.Name = "cCouleurVehicule";
            this.cCouleurVehicule.ReadOnly = true;
            this.cCouleurVehicule.Width = 150;
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
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Crimson;
            this.buttonAnnuler.FlatAppearance.BorderSize = 0;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(23, 684);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(471, 39);
            this.buttonAnnuler.TabIndex = 44;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.BackColor = System.Drawing.Color.Crimson;
            this.buttonConfirmer.FlatAppearance.BorderSize = 0;
            this.buttonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmer.Location = new System.Drawing.Point(23, 626);
            this.buttonConfirmer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(471, 39);
            this.buttonConfirmer.TabIndex = 43;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = false;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Crimson;
            this.buttonSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimer.Location = new System.Drawing.Point(23, 738);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(471, 39);
            this.buttonSupprimer.TabIndex = 42;
            this.buttonSupprimer.Text = "Supprimer un véhicule";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.Crimson;
            this.labelTitre.Location = new System.Drawing.Point(19, 25);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(296, 30);
            this.labelTitre.TabIndex = 41;
            this.labelTitre.Text = "GESTION DES VÉHICULES";
            // 
            // labelImmatriculation
            // 
            this.labelImmatriculation.AutoSize = true;
            this.labelImmatriculation.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImmatriculation.ForeColor = System.Drawing.Color.Crimson;
            this.labelImmatriculation.Location = new System.Drawing.Point(20, 204);
            this.labelImmatriculation.Name = "labelImmatriculation";
            this.labelImmatriculation.Size = new System.Drawing.Size(188, 19);
            this.labelImmatriculation.TabIndex = 50;
            this.labelImmatriculation.Text = "Numéro d\'immatriculation";
            // 
            // labelDatePremiereImmatriculation
            // 
            this.labelDatePremiereImmatriculation.AutoSize = true;
            this.labelDatePremiereImmatriculation.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatePremiereImmatriculation.ForeColor = System.Drawing.Color.Crimson;
            this.labelDatePremiereImmatriculation.Location = new System.Drawing.Point(20, 263);
            this.labelDatePremiereImmatriculation.Name = "labelDatePremiereImmatriculation";
            this.labelDatePremiereImmatriculation.Size = new System.Drawing.Size(220, 19);
            this.labelDatePremiereImmatriculation.TabIndex = 52;
            this.labelDatePremiereImmatriculation.Text = "Date première immatriculation";
            // 
            // labelDerniereImmatriculation
            // 
            this.labelDerniereImmatriculation.AutoSize = true;
            this.labelDerniereImmatriculation.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDerniereImmatriculation.ForeColor = System.Drawing.Color.Crimson;
            this.labelDerniereImmatriculation.Location = new System.Drawing.Point(20, 338);
            this.labelDerniereImmatriculation.Name = "labelDerniereImmatriculation";
            this.labelDerniereImmatriculation.Size = new System.Drawing.Size(216, 19);
            this.labelDerniereImmatriculation.TabIndex = 51;
            this.labelDerniereImmatriculation.Text = "Date dernière immatriculation";
            // 
            // textBoxImmatriculation
            // 
            this.textBoxImmatriculation.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxImmatriculation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxImmatriculation.ForeColor = System.Drawing.Color.White;
            this.textBoxImmatriculation.Location = new System.Drawing.Point(24, 228);
            this.textBoxImmatriculation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxImmatriculation.Name = "textBoxImmatriculation";
            this.textBoxImmatriculation.Size = new System.Drawing.Size(474, 22);
            this.textBoxImmatriculation.TabIndex = 49;
            // 
            // labelClasse
            // 
            this.labelClasse.AutoSize = true;
            this.labelClasse.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClasse.ForeColor = System.Drawing.Color.Crimson;
            this.labelClasse.Location = new System.Drawing.Point(20, 418);
            this.labelClasse.Name = "labelClasse";
            this.labelClasse.Size = new System.Drawing.Size(183, 19);
            this.labelClasse.TabIndex = 56;
            this.labelClasse.Text = "Classe environnementale";
            // 
            // textBoxClasse
            // 
            this.textBoxClasse.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxClasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClasse.ForeColor = System.Drawing.Color.White;
            this.textBoxClasse.Location = new System.Drawing.Point(24, 441);
            this.textBoxClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClasse.Name = "textBoxClasse";
            this.textBoxClasse.Size = new System.Drawing.Size(474, 22);
            this.textBoxClasse.TabIndex = 55;
            // 
            // labelNumeroChassis
            // 
            this.labelNumeroChassis.AutoSize = true;
            this.labelNumeroChassis.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroChassis.ForeColor = System.Drawing.Color.Crimson;
            this.labelNumeroChassis.Location = new System.Drawing.Point(20, 473);
            this.labelNumeroChassis.Name = "labelNumeroChassis";
            this.labelNumeroChassis.Size = new System.Drawing.Size(162, 19);
            this.labelNumeroChassis.TabIndex = 58;
            this.labelNumeroChassis.Text = "Numéro de chassis NIV";
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxNumeroChassis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumeroChassis.ForeColor = System.Drawing.Color.White;
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(24, 495);
            this.textBoxNumeroChassis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(474, 22);
            this.textBoxNumeroChassis.TabIndex = 57;
            // 
            // labelCouleurVehicule
            // 
            this.labelCouleurVehicule.AutoSize = true;
            this.labelCouleurVehicule.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCouleurVehicule.ForeColor = System.Drawing.Color.Crimson;
            this.labelCouleurVehicule.Location = new System.Drawing.Point(20, 527);
            this.labelCouleurVehicule.Name = "labelCouleurVehicule";
            this.labelCouleurVehicule.Size = new System.Drawing.Size(149, 19);
            this.labelCouleurVehicule.TabIndex = 60;
            this.labelCouleurVehicule.Text = "Couleur du véhicule";
            // 
            // textBoxCouleurVehicule
            // 
            this.textBoxCouleurVehicule.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCouleurVehicule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCouleurVehicule.ForeColor = System.Drawing.Color.White;
            this.textBoxCouleurVehicule.Location = new System.Drawing.Point(24, 549);
            this.textBoxCouleurVehicule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCouleurVehicule.Name = "textBoxCouleurVehicule";
            this.textBoxCouleurVehicule.Size = new System.Drawing.Size(474, 22);
            this.textBoxCouleurVehicule.TabIndex = 59;
            // 
            // buttonEditer
            // 
            this.buttonEditer.BackColor = System.Drawing.Color.Crimson;
            this.buttonEditer.FlatAppearance.BorderSize = 0;
            this.buttonEditer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditer.Location = new System.Drawing.Point(23, 626);
            this.buttonEditer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditer.Name = "buttonEditer";
            this.buttonEditer.Size = new System.Drawing.Size(471, 39);
            this.buttonEditer.TabIndex = 61;
            this.buttonEditer.Text = "Editer un véhicule";
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
            this.buttonAjouter.Location = new System.Drawing.Point(24, 684);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(471, 39);
            this.buttonAjouter.TabIndex = 62;
            this.buttonAjouter.Text = "Ajouter un véhicule";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.White;
            this.panelBorder.Controls.Add(this.dataGridviewV);
            this.panelBorder.Location = new System.Drawing.Point(516, 101);
            this.panelBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Padding = new System.Windows.Forms.Padding(1);
            this.panelBorder.Size = new System.Drawing.Size(692, 677);
            this.panelBorder.TabIndex = 63;
            // 
            // labelProprietaire
            // 
            this.labelProprietaire.AutoSize = true;
            this.labelProprietaire.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietaire.ForeColor = System.Drawing.Color.Crimson;
            this.labelProprietaire.Location = new System.Drawing.Point(20, 142);
            this.labelProprietaire.Name = "labelProprietaire";
            this.labelProprietaire.Size = new System.Drawing.Size(173, 19);
            this.labelProprietaire.TabIndex = 71;
            this.labelProprietaire.Text = "Propriétaire du véhicule";
            // 
            // labelModele
            // 
            this.labelModele.AutoSize = true;
            this.labelModele.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModele.ForeColor = System.Drawing.Color.Crimson;
            this.labelModele.Location = new System.Drawing.Point(20, 80);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(148, 19);
            this.labelModele.TabIndex = 70;
            this.labelModele.Text = "Modèle du véhicule";
            // 
            // comboBoxProprietaire
            // 
            this.comboBoxProprietaire.BackColor = System.Drawing.Color.Black;
            this.comboBoxProprietaire.ForeColor = System.Drawing.Color.White;
            this.comboBoxProprietaire.FormattingEnabled = true;
            this.comboBoxProprietaire.Location = new System.Drawing.Point(21, 165);
            this.comboBoxProprietaire.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProprietaire.Name = "comboBoxProprietaire";
            this.comboBoxProprietaire.Size = new System.Drawing.Size(473, 24);
            this.comboBoxProprietaire.TabIndex = 69;
            // 
            // comboBoxModele
            // 
            this.comboBoxModele.BackColor = System.Drawing.Color.Black;
            this.comboBoxModele.ForeColor = System.Drawing.Color.White;
            this.comboBoxModele.FormattingEnabled = true;
            this.comboBoxModele.Location = new System.Drawing.Point(21, 103);
            this.comboBoxModele.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxModele.Name = "comboBoxModele";
            this.comboBoxModele.Size = new System.Drawing.Size(473, 24);
            this.comboBoxModele.TabIndex = 68;
            // 
            // DateTimePickerDerniereImmatriculation
            // 
            this.DateTimePickerDerniereImmatriculation.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.DateTimePickerDerniereImmatriculation.BorderSize = 1;
            this.DateTimePickerDerniereImmatriculation.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDerniereImmatriculation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDerniereImmatriculation.Location = new System.Drawing.Point(24, 361);
            this.DateTimePickerDerniereImmatriculation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerDerniereImmatriculation.MinimumSize = new System.Drawing.Size(4, 35);
            this.DateTimePickerDerniereImmatriculation.Name = "DateTimePickerDerniereImmatriculation";
            this.DateTimePickerDerniereImmatriculation.Size = new System.Drawing.Size(473, 35);
            this.DateTimePickerDerniereImmatriculation.SkinColor = System.Drawing.Color.Black;
            this.DateTimePickerDerniereImmatriculation.TabIndex = 54;
            this.DateTimePickerDerniereImmatriculation.TextColor = System.Drawing.Color.White;
            // 
            // dateTimePickerDatePremiereImmatriculation
            // 
            this.dateTimePickerDatePremiereImmatriculation.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePickerDatePremiereImmatriculation.BorderSize = 1;
            this.dateTimePickerDatePremiereImmatriculation.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDatePremiereImmatriculation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDatePremiereImmatriculation.Location = new System.Drawing.Point(24, 286);
            this.dateTimePickerDatePremiereImmatriculation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDatePremiereImmatriculation.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePickerDatePremiereImmatriculation.Name = "dateTimePickerDatePremiereImmatriculation";
            this.dateTimePickerDatePremiereImmatriculation.Size = new System.Drawing.Size(473, 35);
            this.dateTimePickerDatePremiereImmatriculation.SkinColor = System.Drawing.Color.Black;
            this.dateTimePickerDatePremiereImmatriculation.TabIndex = 53;
            this.dateTimePickerDatePremiereImmatriculation.TextColor = System.Drawing.Color.White;
            // 
            // UserControlVehicules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.labelProprietaire);
            this.Controls.Add(this.labelModele);
            this.Controls.Add(this.comboBoxProprietaire);
            this.Controls.Add(this.comboBoxModele);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonEditer);
            this.Controls.Add(this.labelCouleurVehicule);
            this.Controls.Add(this.textBoxCouleurVehicule);
            this.Controls.Add(this.labelNumeroChassis);
            this.Controls.Add(this.textBoxNumeroChassis);
            this.Controls.Add(this.labelClasse);
            this.Controls.Add(this.textBoxClasse);
            this.Controls.Add(this.DateTimePickerDerniereImmatriculation);
            this.Controls.Add(this.dateTimePickerDatePremiereImmatriculation);
            this.Controls.Add(this.labelImmatriculation);
            this.Controls.Add(this.labelDatePremiereImmatriculation);
            this.Controls.Add(this.labelDerniereImmatriculation);
            this.Controls.Add(this.textBoxImmatriculation);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.labelTitre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlVehicules";
            this.Size = new System.Drawing.Size(1228, 842);
            this.Load += new System.EventHandler(this.UserControlVehicules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewV)).EndInit();
            this.panelBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridviewV;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label labelTitre;
        private CustomControls.RJControls.RJDatePicker DateTimePickerDerniereImmatriculation;
        private CustomControls.RJControls.RJDatePicker dateTimePickerDatePremiereImmatriculation;
        private System.Windows.Forms.Label labelImmatriculation;
        private System.Windows.Forms.Label labelDatePremiereImmatriculation;
        private System.Windows.Forms.Label labelDerniereImmatriculation;
        private System.Windows.Forms.TextBox textBoxImmatriculation;
        private System.Windows.Forms.Label labelClasse;
        private System.Windows.Forms.TextBox textBoxClasse;
        private System.Windows.Forms.Label labelNumeroChassis;
        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.Label labelCouleurVehicule;
        private System.Windows.Forms.TextBox textBoxCouleurVehicule;
        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label labelProprietaire;
        private System.Windows.Forms.Label labelModele;
        private System.Windows.Forms.ComboBox comboBoxProprietaire;
        private System.Windows.Forms.ComboBox comboBoxModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModeleVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNomProprietaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroImmatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDatePremiereImmatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDerniereImmatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroChassis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCouleurVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateEnregistrement;
    }
}
