namespace StudyBudy
{
    partial class frmStudyBuddy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudyBuddy));
            this.btnNewQuiz = new System.Windows.Forms.Button();
            this.btnLoadQuiz = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewQuiz
            // 
            this.btnNewQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(211)))), ((int)(((byte)(59)))));
            this.btnNewQuiz.FlatAppearance.BorderSize = 0;
            this.btnNewQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewQuiz.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQuiz.ForeColor = System.Drawing.Color.White;
            this.btnNewQuiz.Location = new System.Drawing.Point(12, 230);
            this.btnNewQuiz.Name = "btnNewQuiz";
            this.btnNewQuiz.Size = new System.Drawing.Size(760, 47);
            this.btnNewQuiz.TabIndex = 0;
            this.btnNewQuiz.Text = "Create a new quiz";
            this.btnNewQuiz.UseVisualStyleBackColor = false;
            this.btnNewQuiz.Click += new System.EventHandler(this.btnNewQuiz_Click);
            // 
            // btnLoadQuiz
            // 
            this.btnLoadQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(211)))), ((int)(((byte)(59)))));
            this.btnLoadQuiz.FlatAppearance.BorderSize = 0;
            this.btnLoadQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadQuiz.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadQuiz.ForeColor = System.Drawing.Color.White;
            this.btnLoadQuiz.Location = new System.Drawing.Point(12, 364);
            this.btnLoadQuiz.Name = "btnLoadQuiz";
            this.btnLoadQuiz.Size = new System.Drawing.Size(760, 47);
            this.btnLoadQuiz.TabIndex = 1;
            this.btnLoadQuiz.Text = "Load a premade quiz";
            this.btnLoadQuiz.UseVisualStyleBackColor = false;
            this.btnLoadQuiz.Click += new System.EventHandler(this.btnLoadQuiz_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 200);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "StudyBuddy";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(211)))), ((int)(((byte)(59)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 502);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(760, 47);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStudyBuddy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLoadQuiz);
            this.Controls.Add(this.btnNewQuiz);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmStudyBuddy";
            this.ShowIcon = false;
            this.Text = "StudyBudy - Educational Version";
            this.Load += new System.EventHandler(this.frmStudyBuddy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewQuiz;
        private System.Windows.Forms.Button btnLoadQuiz;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
    }
}

