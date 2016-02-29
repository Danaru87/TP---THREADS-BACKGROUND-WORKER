namespace Visual_Background_Worker
{
    partial class TriBulle
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
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lstValeursNonTriees = new System.Windows.Forms.ListView();
            this.lstValeursTriees = new System.Windows.Forms.ListView();
            this.bntInitialiser = new System.Windows.Forms.Button();
            this.btnTrier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(487, 13);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(100, 20);
            this.txtTaille.TabIndex = 0;
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(396, 16);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(85, 13);
            this.lblTaille.TabIndex = 1;
            this.lblTaille.Text = "Taille du tableau";
            // 
            // lstValeursNonTriees
            // 
            this.lstValeursNonTriees.Location = new System.Drawing.Point(12, 64);
            this.lstValeursNonTriees.Name = "lstValeursNonTriees";
            this.lstValeursNonTriees.Size = new System.Drawing.Size(189, 514);
            this.lstValeursNonTriees.TabIndex = 3;
            this.lstValeursNonTriees.UseCompatibleStateImageBehavior = false;
            this.lstValeursNonTriees.View = System.Windows.Forms.View.List;
            // 
            // lstValeursTriees
            // 
            this.lstValeursTriees.Location = new System.Drawing.Point(418, 64);
            this.lstValeursTriees.Name = "lstValeursTriees";
            this.lstValeursTriees.Size = new System.Drawing.Size(169, 514);
            this.lstValeursTriees.TabIndex = 4;
            this.lstValeursTriees.UseCompatibleStateImageBehavior = false;
            this.lstValeursTriees.View = System.Windows.Forms.View.List;
            // 
            // bntInitialiser
            // 
            this.bntInitialiser.Location = new System.Drawing.Point(208, 64);
            this.bntInitialiser.Name = "bntInitialiser";
            this.bntInitialiser.Size = new System.Drawing.Size(204, 35);
            this.bntInitialiser.TabIndex = 5;
            this.bntInitialiser.Text = "Initialiser";
            this.bntInitialiser.UseVisualStyleBackColor = true;
            this.bntInitialiser.Click += new System.EventHandler(this.bntInitialiser_Click);
            // 
            // btnTrier
            // 
            this.btnTrier.Location = new System.Drawing.Point(208, 152);
            this.btnTrier.Name = "btnTrier";
            this.btnTrier.Size = new System.Drawing.Size(204, 35);
            this.btnTrier.TabIndex = 6;
            this.btnTrier.Text = "Trier";
            this.btnTrier.UseVisualStyleBackColor = true;
            this.btnTrier.Click += new System.EventHandler(this.btnTrier_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(208, 543);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(204, 35);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // TriBulle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 590);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnTrier);
            this.Controls.Add(this.bntInitialiser);
            this.Controls.Add(this.lstValeursTriees);
            this.Controls.Add(this.lstValeursNonTriees);
            this.Controls.Add(this.lblTaille);
            this.Controls.Add(this.txtTaille);
            this.Name = "TriBulle";
            this.Text = "TriBulle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.ListView lstValeursNonTriees;
        private System.Windows.Forms.ListView lstValeursTriees;
        private System.Windows.Forms.Button bntInitialiser;
        private System.Windows.Forms.Button btnTrier;
        private System.Windows.Forms.Button btnQuitter;
    }
}

