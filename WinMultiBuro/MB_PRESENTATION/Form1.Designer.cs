
namespace MB_PRESENTATION
{
    partial class Form1
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
            this.enTete = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.libelle = new System.Windows.Forms.Label();
            this.typeRessource = new System.Windows.Forms.Label();
            this.nbPlace = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.nbPlacee = new System.Windows.Forms.NumericUpDown();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.texteEtat = new System.Windows.Forms.Label();
            this.txtEtat = new System.Windows.Forms.ComboBox();
            this.num_serie = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbPlacee)).BeginInit();
            this.SuspendLayout();
            // 
            // enTete
            // 
            this.enTete.AutoSize = true;
            this.enTete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enTete.Location = new System.Drawing.Point(12, 9);
            this.enTete.Name = "enTete";
            this.enTete.Size = new System.Drawing.Size(316, 31);
            this.enTete.TabIndex = 0;
            this.enTete.Text = "Création d\'une ressource";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(109, 73);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(106, 25);
            this.id.TabIndex = 1;
            this.id.Text = "Identifiant :";
            // 
            // libelle
            // 
            this.libelle.AutoSize = true;
            this.libelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libelle.Location = new System.Drawing.Point(109, 134);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(79, 25);
            this.libelle.TabIndex = 2;
            this.libelle.Text = "Libellé :";
            // 
            // typeRessource
            // 
            this.typeRessource.AutoSize = true;
            this.typeRessource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeRessource.Location = new System.Drawing.Point(109, 201);
            this.typeRessource.Name = "typeRessource";
            this.typeRessource.Size = new System.Drawing.Size(68, 25);
            this.typeRessource.TabIndex = 3;
            this.typeRessource.Text = "Type :";
            // 
            // nbPlace
            // 
            this.nbPlace.AutoSize = true;
            this.nbPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPlace.Location = new System.Drawing.Point(109, 277);
            this.nbPlace.Name = "nbPlace";
            this.nbPlace.Size = new System.Drawing.Size(96, 25);
            this.nbPlace.TabIndex = 4;
            this.nbPlace.Text = "Place(s) :";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(674, 343);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(114, 95);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(527, 343);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(114, 95);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // nbPlacee
            // 
            this.nbPlacee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPlacee.Location = new System.Drawing.Point(221, 275);
            this.nbPlacee.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbPlacee.Name = "nbPlacee";
            this.nbPlacee.Size = new System.Drawing.Size(120, 30);
            this.nbPlacee.TabIndex = 7;
            this.nbPlacee.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(221, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(257, 20);
            this.txtId.TabIndex = 8;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(221, 139);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(257, 20);
            this.txtLibelle.TabIndex = 9;
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "BI",
            "SR",
            "OS",
            "PC"});
            this.txtType.Location = new System.Drawing.Point(221, 207);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(257, 21);
            this.txtType.TabIndex = 10;
            this.txtType.SelectedIndexChanged += new System.EventHandler(this.txtType_SelectedIndexChanged);
            // 
            // texteEtat
            // 
            this.texteEtat.AutoSize = true;
            this.texteEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texteEtat.Location = new System.Drawing.Point(561, 79);
            this.texteEtat.Name = "texteEtat";
            this.texteEtat.Size = new System.Drawing.Size(57, 25);
            this.texteEtat.TabIndex = 11;
            this.texteEtat.Text = "Etat :";
            // 
            // txtEtat
            // 
            this.txtEtat.FormattingEnabled = true;
            this.txtEtat.Items.AddRange(new object[] {
            "Correct",
            "Neuf",
            "Mauvais"});
            this.txtEtat.Location = new System.Drawing.Point(531, 107);
            this.txtEtat.Name = "txtEtat";
            this.txtEtat.Size = new System.Drawing.Size(257, 21);
            this.txtEtat.TabIndex = 12;
            // 
            // num_serie
            // 
            this.num_serie.AutoSize = true;
            this.num_serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_serie.Location = new System.Drawing.Point(561, 139);
            this.num_serie.Name = "num_serie";
            this.num_serie.Size = new System.Drawing.Size(143, 25);
            this.num_serie.TabIndex = 13;
            this.num_serie.Text = "Numero Serie :";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(531, 167);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(257, 20);
            this.txtNumSerie.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.num_serie);
            this.Controls.Add(this.txtEtat);
            this.Controls.Add(this.texteEtat);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.nbPlacee);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.nbPlace);
            this.Controls.Add(this.typeRessource);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.id);
            this.Controls.Add(this.enTete);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nbPlacee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enTete;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label libelle;
        private System.Windows.Forms.Label typeRessource;
        private System.Windows.Forms.Label nbPlace;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.NumericUpDown nbPlacee;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Label texteEtat;
        private System.Windows.Forms.ComboBox txtEtat;
        private System.Windows.Forms.Label num_serie;
        private System.Windows.Forms.TextBox txtNumSerie;
    }
}

