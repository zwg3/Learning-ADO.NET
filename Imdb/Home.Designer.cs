namespace Imdb
{
    partial class Home
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
            this.btnActors = new System.Windows.Forms.Button();
            this.btnDirectors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMovies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActors
            // 
            this.btnActors.Location = new System.Drawing.Point(84, 42);
            this.btnActors.Name = "btnActors";
            this.btnActors.Size = new System.Drawing.Size(75, 23);
            this.btnActors.TabIndex = 0;
            this.btnActors.Text = "Actors";
            this.btnActors.UseVisualStyleBackColor = true;
            this.btnActors.Click += new System.EventHandler(this.btnActors_Click);
            // 
            // btnDirectors
            // 
            this.btnDirectors.Location = new System.Drawing.Point(84, 71);
            this.btnDirectors.Name = "btnDirectors";
            this.btnDirectors.Size = new System.Drawing.Size(75, 23);
            this.btnDirectors.TabIndex = 1;
            this.btnDirectors.Text = "Directors";
            this.btnDirectors.UseVisualStyleBackColor = true;
            this.btnDirectors.Click += new System.EventHandler(this.btnDirectors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the subject you are interested in";
            // 
            // btnMovies
            // 
            this.btnMovies.Location = new System.Drawing.Point(84, 100);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(75, 23);
            this.btnMovies.TabIndex = 3;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 145);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDirectors);
            this.Controls.Add(this.btnActors);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActors;
        private System.Windows.Forms.Button btnDirectors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMovies;
    }
}