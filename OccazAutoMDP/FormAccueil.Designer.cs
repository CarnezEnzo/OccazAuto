namespace OccazAutoMDP
{
    partial class FormAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.listViewAffichage = new System.Windows.Forms.ListView();
            this.columnid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnnom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnprenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnadresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columncodepostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCritere = new System.Windows.Forms.Label();
            this.comboBoxCritere = new System.Windows.Forms.ComboBox();
            this.textBoxCritere = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textAdresse = new System.Windows.Forms.TextBox();
            this.panelModification = new System.Windows.Forms.Panel();
            this.buttonValider = new System.Windows.Forms.Button();
            this.textVille = new System.Windows.Forms.TextBox();
            this.textCodePostal = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.labelModif = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelMotDePasse = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonInscription = new System.Windows.Forms.Button();
            this.panelConnexion = new System.Windows.Forms.Panel();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.panelModification.SuspendLayout();
            this.panelConnexion.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAffichage
            // 
            this.listViewAffichage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnid,
            this.columnnom,
            this.columnprenom,
            this.columnadresse,
            this.columncodepostal,
            this.columnville});
            this.listViewAffichage.FullRowSelect = true;
            this.listViewAffichage.GridLines = true;
            this.listViewAffichage.Location = new System.Drawing.Point(15, 44);
            this.listViewAffichage.MultiSelect = false;
            this.listViewAffichage.Name = "listViewAffichage";
            this.listViewAffichage.Size = new System.Drawing.Size(464, 309);
            this.listViewAffichage.TabIndex = 0;
            this.listViewAffichage.UseCompatibleStateImageBehavior = false;
            this.listViewAffichage.View = System.Windows.Forms.View.Details;
            // 
            // columnid
            // 
            this.columnid.Text = "ID";
            this.columnid.Width = 80;
            // 
            // columnnom
            // 
            this.columnnom.Text = "Nom";
            this.columnnom.Width = 80;
            // 
            // columnprenom
            // 
            this.columnprenom.Text = "Prenom";
            // 
            // columnadresse
            // 
            this.columnadresse.Text = "Adresse";
            this.columnadresse.Width = 80;
            // 
            // columncodepostal
            // 
            this.columncodepostal.Text = "Code postal";
            this.columncodepostal.Width = 80;
            // 
            // columnville
            // 
            this.columnville.Text = "Ville";
            this.columnville.Width = 80;
            // 
            // labelCritere
            // 
            this.labelCritere.AutoSize = true;
            this.labelCritere.Location = new System.Drawing.Point(12, 28);
            this.labelCritere.Name = "labelCritere";
            this.labelCritere.Size = new System.Drawing.Size(102, 13);
            this.labelCritere.TabIndex = 1;
            this.labelCritere.Text = "Critères de selection";
            // 
            // comboBoxCritere
            // 
            this.comboBoxCritere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCritere.FormattingEnabled = true;
            this.comboBoxCritere.Items.AddRange(new object[] {
            "Ville",
            "Nom",
            "Code postal"});
            this.comboBoxCritere.Location = new System.Drawing.Point(120, 20);
            this.comboBoxCritere.Name = "comboBoxCritere";
            this.comboBoxCritere.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCritere.TabIndex = 2;
            // 
            // textBoxCritere
            // 
            this.textBoxCritere.Location = new System.Drawing.Point(266, 20);
            this.textBoxCritere.Name = "textBoxCritere";
            this.textBoxCritere.Size = new System.Drawing.Size(208, 20);
            this.textBoxCritere.TabIndex = 3;
            this.textBoxCritere.TextChanged += new System.EventHandler(this.textBoxCritere_TextChanged);
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(12, 65);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(100, 20);
            this.textPrenom.TabIndex = 5;
            // 
            // textAdresse
            // 
            this.textAdresse.Location = new System.Drawing.Point(12, 91);
            this.textAdresse.Name = "textAdresse";
            this.textAdresse.Size = new System.Drawing.Size(100, 20);
            this.textAdresse.TabIndex = 6;
            // 
            // panelModification
            // 
            this.panelModification.Controls.Add(this.buttonAnnuler);
            this.panelModification.Controls.Add(this.buttonValider);
            this.panelModification.Controls.Add(this.textVille);
            this.panelModification.Controls.Add(this.textCodePostal);
            this.panelModification.Controls.Add(this.textNom);
            this.panelModification.Controls.Add(this.labelModif);
            this.panelModification.Controls.Add(this.textPrenom);
            this.panelModification.Controls.Add(this.textAdresse);
            this.panelModification.Location = new System.Drawing.Point(15, 413);
            this.panelModification.Name = "panelModification";
            this.panelModification.Size = new System.Drawing.Size(443, 120);
            this.panelModification.TabIndex = 7;
            this.panelModification.Visible = false;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(348, 73);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 11;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // textVille
            // 
            this.textVille.Location = new System.Drawing.Point(154, 65);
            this.textVille.Name = "textVille";
            this.textVille.Size = new System.Drawing.Size(100, 20);
            this.textVille.TabIndex = 10;
            // 
            // textCodePostal
            // 
            this.textCodePostal.Location = new System.Drawing.Point(154, 39);
            this.textCodePostal.Name = "textCodePostal";
            this.textCodePostal.Size = new System.Drawing.Size(100, 20);
            this.textCodePostal.TabIndex = 9;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(12, 39);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 8;
            // 
            // labelModif
            // 
            this.labelModif.AutoSize = true;
            this.labelModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModif.Location = new System.Drawing.Point(9, 8);
            this.labelModif.Name = "labelModif";
            this.labelModif.Size = new System.Drawing.Size(110, 24);
            this.labelModif.TabIndex = 7;
            this.labelModif.Text = "Modification";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(15, 377);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(85, 30);
            this.buttonModifier.TabIndex = 8;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(298, 377);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(85, 30);
            this.buttonSupprimer.TabIndex = 9;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(389, 377);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(85, 30);
            this.buttonQuitter.TabIndex = 10;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdentifiant.Location = new System.Drawing.Point(112, 150);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(250, 29);
            this.textBoxIdentifiant.TabIndex = 11;
            // 
            // textBoxMotDePasse
            // 
            this.textBoxMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMotDePasse.Location = new System.Drawing.Point(112, 300);
            this.textBoxMotDePasse.Name = "textBoxMotDePasse";
            this.textBoxMotDePasse.PasswordChar = '*';
            this.textBoxMotDePasse.Size = new System.Drawing.Size(250, 29);
            this.textBoxMotDePasse.TabIndex = 12;
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifiant.Location = new System.Drawing.Point(199, 118);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(80, 20);
            this.labelIdentifiant.TabIndex = 13;
            this.labelIdentifiant.Text = "Identifiant";
            // 
            // labelMotDePasse
            // 
            this.labelMotDePasse.AutoSize = true;
            this.labelMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotDePasse.Location = new System.Drawing.Point(184, 268);
            this.labelMotDePasse.Name = "labelMotDePasse";
            this.labelMotDePasse.Size = new System.Drawing.Size(105, 20);
            this.labelMotDePasse.TabIndex = 14;
            this.labelMotDePasse.Text = "Mot de passe";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(112, 367);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(91, 37);
            this.buttonConnexion.TabIndex = 15;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonInscription
            // 
            this.buttonInscription.Location = new System.Drawing.Point(273, 367);
            this.buttonInscription.Name = "buttonInscription";
            this.buttonInscription.Size = new System.Drawing.Size(89, 37);
            this.buttonInscription.TabIndex = 16;
            this.buttonInscription.Text = "S\'inscrire";
            this.buttonInscription.UseVisualStyleBackColor = true;
            this.buttonInscription.Click += new System.EventHandler(this.buttonInscription_Click);
            // 
            // panelConnexion
            // 
            this.panelConnexion.Controls.Add(this.textBoxIdentifiant);
            this.panelConnexion.Controls.Add(this.buttonInscription);
            this.panelConnexion.Controls.Add(this.textBoxMotDePasse);
            this.panelConnexion.Controls.Add(this.buttonConnexion);
            this.panelConnexion.Controls.Add(this.labelIdentifiant);
            this.panelConnexion.Controls.Add(this.labelMotDePasse);
            this.panelConnexion.Location = new System.Drawing.Point(15, 0);
            this.panelConnexion.Name = "panelConnexion";
            this.panelConnexion.Size = new System.Drawing.Size(478, 418);
            this.panelConnexion.TabIndex = 17;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(106, 377);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(86, 30);
            this.buttonAjouter.TabIndex = 18;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(348, 39);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 12;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 536);
            this.Controls.Add(this.panelConnexion);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.panelModification);
            this.Controls.Add(this.textBoxCritere);
            this.Controls.Add(this.comboBoxCritere);
            this.Controls.Add(this.labelCritere);
            this.Controls.Add(this.listViewAffichage);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAccueil";
            this.Text = "Liste des concessionnaires";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panelModification.ResumeLayout(false);
            this.panelModification.PerformLayout();
            this.panelConnexion.ResumeLayout(false);
            this.panelConnexion.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAffichage;
        private System.Windows.Forms.Label labelCritere;
        private System.Windows.Forms.ComboBox comboBoxCritere;
        private System.Windows.Forms.TextBox textBoxCritere;
        private System.Windows.Forms.ColumnHeader columnid;
        private System.Windows.Forms.ColumnHeader columnnom;
        private System.Windows.Forms.ColumnHeader columnprenom;
        private System.Windows.Forms.ColumnHeader columnadresse;
        private System.Windows.Forms.ColumnHeader columncodepostal;
        private System.Windows.Forms.ColumnHeader columnville;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textAdresse;
        private System.Windows.Forms.Panel panelModification;
        private System.Windows.Forms.TextBox textVille;
        private System.Windows.Forms.TextBox textCodePostal;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label labelModif;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxMotDePasse;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelMotDePasse;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonInscription;
        private System.Windows.Forms.Panel panelConnexion;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}

