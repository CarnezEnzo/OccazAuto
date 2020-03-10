namespace OccazAutoMDP
{
    partial class FormAjouter
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
            this.textVille = new System.Windows.Forms.TextBox();
            this.textCodePostal = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textAdresse = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelConcess = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textVille
            // 
            this.textVille.Location = new System.Drawing.Point(185, 194);
            this.textVille.Name = "textVille";
            this.textVille.Size = new System.Drawing.Size(100, 20);
            this.textVille.TabIndex = 16;
            // 
            // textCodePostal
            // 
            this.textCodePostal.Location = new System.Drawing.Point(185, 168);
            this.textCodePostal.Name = "textCodePostal";
            this.textCodePostal.Size = new System.Drawing.Size(100, 20);
            this.textCodePostal.TabIndex = 15;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(185, 90);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 14;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(185, 116);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(100, 20);
            this.textPrenom.TabIndex = 11;
            // 
            // textAdresse
            // 
            this.textAdresse.Location = new System.Drawing.Point(185, 142);
            this.textAdresse.Name = "textAdresse";
            this.textAdresse.Size = new System.Drawing.Size(100, 20);
            this.textAdresse.TabIndex = 12;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(89, 254);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 17;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(210, 254);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Vider";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelConcess
            // 
            this.labelConcess.AutoSize = true;
            this.labelConcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConcess.Location = new System.Drawing.Point(21, 37);
            this.labelConcess.Name = "labelConcess";
            this.labelConcess.Size = new System.Drawing.Size(362, 25);
            this.labelConcess.TabIndex = 19;
            this.labelConcess.Text = "Ajouter un nouveau concessionnaire";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(91, 90);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 20);
            this.labelNom.TabIndex = 20;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(88, 116);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(64, 20);
            this.labelPrenom.TabIndex = 21;
            this.labelPrenom.Text = "Prenom";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.Location = new System.Drawing.Point(88, 142);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(68, 20);
            this.labelAdresse.TabIndex = 22;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodePostal.Location = new System.Drawing.Point(88, 168);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(94, 20);
            this.labelCodePostal.TabIndex = 23;
            this.labelCodePostal.Text = "Code postal";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVille.Location = new System.Drawing.Point(88, 194);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(38, 20);
            this.labelVille.TabIndex = 24;
            this.labelVille.Text = "Ville";
            // 
            // FormAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 312);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelConcess);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textVille);
            this.Controls.Add(this.textCodePostal);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textAdresse);
            this.Name = "FormAjouter";
            this.Text = "FormAjouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textVille;
        private System.Windows.Forms.TextBox textCodePostal;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textAdresse;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelConcess;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.Label labelVille;
    }
}