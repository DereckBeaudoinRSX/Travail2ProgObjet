namespace Travail
{
    partial class frmVoirProfile
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnAdministrateur = new System.Windows.Forms.Button();
            this.btnCanada = new System.Windows.Forms.Button();
            this.btnUSA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(13, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(95, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Nom de l\'utilisateur";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(128, 8);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(75, 23);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnAdministrateur
            // 
            this.btnAdministrateur.Location = new System.Drawing.Point(209, 8);
            this.btnAdministrateur.Name = "btnAdministrateur";
            this.btnAdministrateur.Size = new System.Drawing.Size(82, 23);
            this.btnAdministrateur.TabIndex = 2;
            this.btnAdministrateur.Text = "Administrateur";
            this.btnAdministrateur.UseVisualStyleBackColor = true;
            this.btnAdministrateur.Click += new System.EventHandler(this.btnAdministrateur_Click);
            // 
            // btnCanada
            // 
            this.btnCanada.Location = new System.Drawing.Point(16, 70);
            this.btnCanada.Name = "btnCanada";
            this.btnCanada.Size = new System.Drawing.Size(75, 23);
            this.btnCanada.TabIndex = 3;
            this.btnCanada.Text = "CAD";
            this.btnCanada.UseVisualStyleBackColor = true;
            this.btnCanada.Click += new System.EventHandler(this.btnCanada_Click);
            // 
            // btnUSA
            // 
            this.btnUSA.Location = new System.Drawing.Point(97, 70);
            this.btnUSA.Name = "btnUSA";
            this.btnUSA.Size = new System.Drawing.Size(75, 23);
            this.btnUSA.TabIndex = 4;
            this.btnUSA.Text = "USA";
            this.btnUSA.UseVisualStyleBackColor = true;
            this.btnUSA.Click += new System.EventHandler(this.btnUSA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Provenance";
            // 
            // frmVoirProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 114);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUSA);
            this.Controls.Add(this.btnCanada);
            this.Controls.Add(this.btnAdministrateur);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmVoirProfile";
            this.Text = "frmVoirProfile";
            this.Load += new System.EventHandler(this.frmVoirProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnAdministrateur;
        private System.Windows.Forms.Button btnCanada;
        private System.Windows.Forms.Button btnUSA;
        private System.Windows.Forms.Label label2;
    }
}