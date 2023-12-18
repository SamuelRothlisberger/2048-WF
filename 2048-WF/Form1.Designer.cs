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
            this.board = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.board.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.board.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.board.GridColor = System.Drawing.SystemColors.Control;
            this.board.Location = new System.Drawing.Point(75, 116);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(300, 300);
            this.board.TabIndex = 0;
            this.board.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.board_CellContentClick);
            // 
            // col1
            // 
            this.col1.HeaderText = "col1";
            this.col1.Name = "col1";
            this.col1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col1.Width = 75;
            // 
            // col2
            // 
            this.col2.HeaderText = "col2";
            this.col2.Name = "col2";
            this.col2.Width = 75;
            // 
            // col3
            // 
            this.col3.HeaderText = "col3";
            this.col3.Name = "col3";
            this.col3.Width = 75;
            // 
            // col4
            // 
            this.col4.HeaderText = "col4";
            this.col4.Name = "col4";
            this.col4.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 495);
            this.Controls.Add(this.board);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView board;
        private System.Windows.Forms.DataGridViewComboBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
    }
}

