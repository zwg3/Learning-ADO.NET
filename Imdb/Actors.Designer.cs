namespace Imdb
{
    partial class Actors
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
            this.sortBox = new System.Windows.Forms.TextBox();
            this.actBtnGetById = new System.Windows.Forms.Button();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.actBtnUpdate = new System.Windows.Forms.Button();
            this.daActors = new Npgsql.NpgsqlDataAdapter();
            this.actBtnRefresh = new System.Windows.Forms.Button();
            this.dgvActorsMovies = new System.Windows.Forms.DataGridView();
            this.actBtnStarred = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActorsMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // sortBox
            // 
            this.sortBox.Location = new System.Drawing.Point(252, 275);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(123, 20);
            this.sortBox.TabIndex = 1;
            this.sortBox.Text = "Actor\'s surname here";
            // 
            // actBtnGetById
            // 
            this.actBtnGetById.Location = new System.Drawing.Point(126, 275);
            this.actBtnGetById.Name = "actBtnGetById";
            this.actBtnGetById.Size = new System.Drawing.Size(120, 20);
            this.actBtnGetById.TabIndex = 3;
            this.actBtnGetById.Text = "Serach by surname";
            this.actBtnGetById.UseVisualStyleBackColor = true;
            this.actBtnGetById.Click += new System.EventHandler(this.actBtnGetById_Click);
            // 
            // dgvActors
            // 
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Location = new System.Drawing.Point(12, 17);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(363, 251);
            this.dgvActors.TabIndex = 6;
            // 
            // actBtnUpdate
            // 
            this.actBtnUpdate.Location = new System.Drawing.Point(12, 275);
            this.actBtnUpdate.Name = "actBtnUpdate";
            this.actBtnUpdate.Size = new System.Drawing.Size(73, 20);
            this.actBtnUpdate.TabIndex = 7;
            this.actBtnUpdate.Text = "Update";
            this.actBtnUpdate.UseVisualStyleBackColor = true;
            this.actBtnUpdate.Click += new System.EventHandler(this.actBtnUpdate_Click);
            // 
            // daActors
            // 
            this.daActors.DeleteCommand = null;
            this.daActors.InsertCommand = null;
            this.daActors.SelectCommand = null;
            this.daActors.UpdateCommand = null;
            // 
            // actBtnRefresh
            // 
            this.actBtnRefresh.Location = new System.Drawing.Point(12, 304);
            this.actBtnRefresh.Name = "actBtnRefresh";
            this.actBtnRefresh.Size = new System.Drawing.Size(73, 20);
            this.actBtnRefresh.TabIndex = 8;
            this.actBtnRefresh.Text = "Refresh";
            this.actBtnRefresh.UseVisualStyleBackColor = true;
            this.actBtnRefresh.Click += new System.EventHandler(this.actBtnRefresh_Click);
            // 
            // dgvActorsMovies
            // 
            this.dgvActorsMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActorsMovies.Location = new System.Drawing.Point(396, 17);
            this.dgvActorsMovies.Name = "dgvActorsMovies";
            this.dgvActorsMovies.Size = new System.Drawing.Size(363, 251);
            this.dgvActorsMovies.TabIndex = 9;
            // 
            // actBtnStarred
            // 
            this.actBtnStarred.Location = new System.Drawing.Point(513, 273);
            this.actBtnStarred.Name = "actBtnStarred";
            this.actBtnStarred.Size = new System.Drawing.Size(120, 24);
            this.actBtnStarred.TabIndex = 10;
            this.actBtnStarred.Text = "Movies starred in";
            this.actBtnStarred.UseVisualStyleBackColor = true;
            this.actBtnStarred.Click += new System.EventHandler(this.actBtnStarred_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(639, 276);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(120, 20);
            this.searchBox.TabIndex = 11;
            this.searchBox.Text = "Actor\'s surname here";
            // 
            // Actors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 330);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.actBtnStarred);
            this.Controls.Add(this.dgvActorsMovies);
            this.Controls.Add(this.actBtnRefresh);
            this.Controls.Add(this.actBtnUpdate);
            this.Controls.Add(this.dgvActors);
            this.Controls.Add(this.actBtnGetById);
            this.Controls.Add(this.sortBox);
            this.Name = "Actors";
            this.Text = "Actors";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActorsMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sortBox;
        private System.Windows.Forms.Button actBtnGetById;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.Button actBtnUpdate;
        private Npgsql.NpgsqlDataAdapter daActors;
        private System.Windows.Forms.Button actBtnRefresh;
        private System.Windows.Forms.DataGridView dgvActorsMovies;
        private System.Windows.Forms.Button actBtnStarred;
        private System.Windows.Forms.TextBox searchBox;
    }
}

