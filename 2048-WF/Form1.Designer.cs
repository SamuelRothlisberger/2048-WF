namespace _2048_WF
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
            this.lbl_2048 = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_ScorePerso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_2048
            // 
            this.lbl_2048.AutoSize = true;
            this.lbl_2048.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2048.Location = new System.Drawing.Point(61, 29);
            this.lbl_2048.Name = "lbl_2048";
            this.lbl_2048.Size = new System.Drawing.Size(308, 63);
            this.lbl_2048.TabIndex = 0;
            this.lbl_2048.Text = "2048 Game";
            this.lbl_2048.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(42, 579);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(148, 46);
            this.lbl_Score.TabIndex = 1;
            this.lbl_Score.Text = "Score :";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ScorePerso
            // 
            this.lbl_ScorePerso.AutoSize = true;
            this.lbl_ScorePerso.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_ScorePerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScorePerso.Location = new System.Drawing.Point(196, 579);
            this.lbl_ScorePerso.MinimumSize = new System.Drawing.Size(200, 50);
            this.lbl_ScorePerso.Name = "lbl_ScorePerso";
            this.lbl_ScorePerso.Size = new System.Drawing.Size(200, 50);
            this.lbl_ScorePerso.TabIndex = 2;
            this.lbl_ScorePerso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(431, 685);
            this.Controls.Add(this.lbl_ScorePerso);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_2048);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "2048 Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_2048;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_ScorePerso;
    }
}

