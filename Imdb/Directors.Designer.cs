namespace Imdb
{
    partial class Directors
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
            this.dgvDirectors = new System.Windows.Forms.DataGridView();
            this.dirBtnRefresh = new System.Windows.Forms.Button();
            this.daDirectors = new Npgsql.NpgsqlDataAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dirBtnDirected = new System.Windows.Forms.Button();
            this.dgvDirectorsMovies = new System.Windows.Forms.DataGridView();
            this.dirSearch = new System.Windows.Forms.Button();
            this.dirSeachBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectorsMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDirectors
            // 
            this.dgvDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectors.Location = new System.Drawing.Point(11, 11);
            this.dgvDirectors.Name = "dgvDirectors";
            this.dgvDirectors.Size = new System.Drawing.Size(363, 251);
            this.dgvDirectors.TabIndex = 0;
            // 
            // dirBtnRefresh
            // 
            this.dirBtnRefresh.Location = new System.Drawing.Point(11, 297);
            this.dirBtnRefresh.Name = "dirBtnRefresh";
            this.dirBtnRefresh.Size = new System.Drawing.Size(73, 20);
            this.dirBtnRefresh.TabIndex = 1;
            this.dirBtnRefresh.Text = "Refresh";
            this.dirBtnRefresh.UseVisualStyleBackColor = true;
            this.dirBtnRefresh.Click += new System.EventHandler(this.dirBtnRefresh_Click);
            // 
            // daDirectors
            // 
            this.daDirectors.DeleteCommand = null;
            this.daDirectors.InsertCommand = null;
            this.daDirectors.SelectCommand = null;
            this.daDirectors.UpdateCommand = null;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(11, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 20);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(622, 268);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(138, 20);
            this.searchBox.TabIndex = 7;
            this.searchBox.Text = "Director\'s surname here";
            // 
            // dirBtnDirected
            // 
            this.dirBtnDirected.Location = new System.Drawing.Point(496, 269);
            this.dirBtnDirected.Name = "dirBtnDirected";
            this.dirBtnDirected.Size = new System.Drawing.Size(120, 20);
            this.dirBtnDirected.TabIndex = 8;
            this.dirBtnDirected.Text = "Movies directed by";
            this.dirBtnDirected.UseVisualStyleBackColor = true;
            this.dirBtnDirected.Click += new System.EventHandler(this.dirBtnDirected_Click);
            // 
            // dgvDirectorsMovies
            // 
            this.dgvDirectorsMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectorsMovies.Location = new System.Drawing.Point(397, 11);
            this.dgvDirectorsMovies.Name = "dgvDirectorsMovies";
            this.dgvDirectorsMovies.Size = new System.Drawing.Size(363, 251);
            this.dgvDirectorsMovies.TabIndex = 10;
            // 
            // dirSearch
            // 
            this.dirSearch.Location = new System.Drawing.Point(157, 268);
            this.dirSearch.Name = "dirSearch";
            this.dirSearch.Size = new System.Drawing.Size(73, 20);
            this.dirSearch.TabIndex = 11;
            this.dirSearch.Text = "Search";
            this.dirSearch.UseVisualStyleBackColor = true;
            this.dirSearch.Click += new System.EventHandler(this.dirSearch_Click_1);
            // 
            // dirSeachBox
            // 
            this.dirSeachBox.Location = new System.Drawing.Point(236, 270);
            this.dirSeachBox.Name = "dirSeachBox";
            this.dirSeachBox.Size = new System.Drawing.Size(138, 20);
            this.dirSeachBox.TabIndex = 12;
            this.dirSeachBox.Text = "Director\'s surname here";
            // 
            // Directors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 330);
            this.Controls.Add(this.dirSeachBox);
            this.Controls.Add(this.dirSearch);
            this.Controls.Add(this.dgvDirectorsMovies);
            this.Controls.Add(this.dirBtnDirected);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dirBtnRefresh);
            this.Controls.Add(this.dgvDirectors);
            this.Name = "Directors";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectorsMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDirectors;
        private System.Windows.Forms.Button dirBtnRefresh;
        private Npgsql.NpgsqlDataAdapter daDirectors;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button dirBtnDirected;
        private System.Windows.Forms.DataGridView dgvDirectorsMovies;
        private System.Windows.Forms.Button dirSearch;
        private System.Windows.Forms.TextBox dirSeachBox;
    }
}