namespace Imdb
{
    partial class Movies
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
            this.daMovies = new Npgsql.NpgsqlDataAdapter();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.movBtnRefresh = new System.Windows.Forms.Button();
            this.movBtnUpdate = new System.Windows.Forms.Button();
            this.movSearchByName = new System.Windows.Forms.Button();
            this.movSearchBox = new System.Windows.Forms.TextBox();
            this.dgvMoviesDirector = new System.Windows.Forms.DataGridView();
            this.movSearchDir = new System.Windows.Forms.Button();
            this.movSearchDIrect = new System.Windows.Forms.TextBox();
            this.movSearchAct = new System.Windows.Forms.Button();
            this.movSearchActBox = new System.Windows.Forms.TextBox();
            this.dgvMoviesActors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richPlotBox = new System.Windows.Forms.RichTextBox();
            this.movBtnPlot = new System.Windows.Forms.Button();
            this.plotBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoviesDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoviesActors)).BeginInit();
            this.SuspendLayout();
            // 
            // daMovies
            // 
            this.daMovies.DeleteCommand = null;
            this.daMovies.InsertCommand = null;
            this.daMovies.SelectCommand = null;
            this.daMovies.UpdateCommand = null;
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(22, 22);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.Size = new System.Drawing.Size(378, 129);
            this.dgvMovies.TabIndex = 0;
            // 
            // movBtnRefresh
            // 
            this.movBtnRefresh.Location = new System.Drawing.Point(22, 157);
            this.movBtnRefresh.Name = "movBtnRefresh";
            this.movBtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.movBtnRefresh.TabIndex = 1;
            this.movBtnRefresh.Text = "Refresh";
            this.movBtnRefresh.UseVisualStyleBackColor = true;
            this.movBtnRefresh.Click += new System.EventHandler(this.movBtnRefresh_Click);
            // 
            // movBtnUpdate
            // 
            this.movBtnUpdate.Location = new System.Drawing.Point(21, 187);
            this.movBtnUpdate.Name = "movBtnUpdate";
            this.movBtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.movBtnUpdate.TabIndex = 2;
            this.movBtnUpdate.Text = "Update";
            this.movBtnUpdate.UseVisualStyleBackColor = true;
            this.movBtnUpdate.Click += new System.EventHandler(this.movBtnUpdate_Click);
            // 
            // movSearchByName
            // 
            this.movSearchByName.Location = new System.Drawing.Point(21, 216);
            this.movSearchByName.Name = "movSearchByName";
            this.movSearchByName.Size = new System.Drawing.Size(75, 23);
            this.movSearchByName.TabIndex = 3;
            this.movSearchByName.Text = "Search";
            this.movSearchByName.UseVisualStyleBackColor = true;
            this.movSearchByName.Click += new System.EventHandler(this.movSearchByName_Click);
            // 
            // movSearchBox
            // 
            this.movSearchBox.Location = new System.Drawing.Point(102, 219);
            this.movSearchBox.Name = "movSearchBox";
            this.movSearchBox.Size = new System.Drawing.Size(120, 20);
            this.movSearchBox.TabIndex = 4;
            this.movSearchBox.Text = "Movie title here";
            // 
            // dgvMoviesDirector
            // 
            this.dgvMoviesDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoviesDirector.Location = new System.Drawing.Point(463, 22);
            this.dgvMoviesDirector.Name = "dgvMoviesDirector";
            this.dgvMoviesDirector.Size = new System.Drawing.Size(199, 129);
            this.dgvMoviesDirector.TabIndex = 5;
            // 
            // movSearchDir
            // 
            this.movSearchDir.Location = new System.Drawing.Point(463, 157);
            this.movSearchDir.Name = "movSearchDir";
            this.movSearchDir.Size = new System.Drawing.Size(73, 23);
            this.movSearchDir.TabIndex = 6;
            this.movSearchDir.Text = "Find director";
            this.movSearchDir.UseVisualStyleBackColor = true;
            this.movSearchDir.Click += new System.EventHandler(this.movSearchDir_Click);
            // 
            // movSearchDIrect
            // 
            this.movSearchDIrect.Location = new System.Drawing.Point(542, 160);
            this.movSearchDIrect.Name = "movSearchDIrect";
            this.movSearchDIrect.Size = new System.Drawing.Size(120, 20);
            this.movSearchDIrect.TabIndex = 7;
            this.movSearchDIrect.Text = "Movie title here";
            // 
            // movSearchAct
            // 
            this.movSearchAct.Location = new System.Drawing.Point(21, 436);
            this.movSearchAct.Name = "movSearchAct";
            this.movSearchAct.Size = new System.Drawing.Size(76, 23);
            this.movSearchAct.TabIndex = 8;
            this.movSearchAct.Text = "Find actors";
            this.movSearchAct.UseVisualStyleBackColor = true;
            this.movSearchAct.Click += new System.EventHandler(this.movSearchAct_Click);
            // 
            // movSearchActBox
            // 
            this.movSearchActBox.Location = new System.Drawing.Point(102, 436);
            this.movSearchActBox.Name = "movSearchActBox";
            this.movSearchActBox.Size = new System.Drawing.Size(120, 20);
            this.movSearchActBox.TabIndex = 9;
            this.movSearchActBox.Text = "Movie title here";
            // 
            // dgvMoviesActors
            // 
            this.dgvMoviesActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoviesActors.Location = new System.Drawing.Point(22, 279);
            this.dgvMoviesActors.Name = "dgvMoviesActors";
            this.dgvMoviesActors.Size = new System.Drawing.Size(378, 151);
            this.dgvMoviesActors.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Movies list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Directors list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Actors list";
            // 
            // richPlotBox
            // 
            this.richPlotBox.Location = new System.Drawing.Point(466, 279);
            this.richPlotBox.Name = "richPlotBox";
            this.richPlotBox.Size = new System.Drawing.Size(207, 151);
            this.richPlotBox.TabIndex = 14;
            this.richPlotBox.Text = "";
            // 
            // movBtnPlot
            // 
            this.movBtnPlot.Location = new System.Drawing.Point(463, 437);
            this.movBtnPlot.Name = "movBtnPlot";
            this.movBtnPlot.Size = new System.Drawing.Size(84, 38);
            this.movBtnPlot.TabIndex = 15;
            this.movBtnPlot.Text = "Get plot synopsis";
            this.movBtnPlot.UseVisualStyleBackColor = true;
            this.movBtnPlot.Click += new System.EventHandler(this.movBtnPlot_Click);
            // 
            // plotBox
            // 
            this.plotBox.Location = new System.Drawing.Point(553, 447);
            this.plotBox.Name = "plotBox";
            this.plotBox.Size = new System.Drawing.Size(120, 20);
            this.plotBox.TabIndex = 16;
            this.plotBox.Text = "Movie title here";
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 510);
            this.Controls.Add(this.plotBox);
            this.Controls.Add(this.movBtnPlot);
            this.Controls.Add(this.richPlotBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMoviesActors);
            this.Controls.Add(this.movSearchActBox);
            this.Controls.Add(this.movSearchAct);
            this.Controls.Add(this.movSearchDIrect);
            this.Controls.Add(this.movSearchDir);
            this.Controls.Add(this.dgvMoviesDirector);
            this.Controls.Add(this.movSearchBox);
            this.Controls.Add(this.movSearchByName);
            this.Controls.Add(this.movBtnUpdate);
            this.Controls.Add(this.movBtnRefresh);
            this.Controls.Add(this.dgvMovies);
            this.Name = "Movies";
            this.Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoviesDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoviesActors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Npgsql.NpgsqlDataAdapter daMovies;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button movBtnRefresh;
        private System.Windows.Forms.Button movBtnUpdate;
        private System.Windows.Forms.Button movSearchByName;
        private System.Windows.Forms.TextBox movSearchBox;
        private System.Windows.Forms.DataGridView dgvMoviesDirector;
        private System.Windows.Forms.Button movSearchDir;
        private System.Windows.Forms.TextBox movSearchDIrect;
        private System.Windows.Forms.Button movSearchAct;
        private System.Windows.Forms.TextBox movSearchActBox;
        private System.Windows.Forms.DataGridView dgvMoviesActors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richPlotBox;
        private System.Windows.Forms.Button movBtnPlot;
        private System.Windows.Forms.TextBox plotBox;
    }
}