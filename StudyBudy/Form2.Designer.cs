namespace StudyBudy
{
    partial class frmQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiz));
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOptionOne = new System.Windows.Forms.Button();
            this.btnOptionTwo = new System.Windows.Forms.Button();
            this.btnOptionFour = new System.Windows.Forms.Button();
            this.btnOptionThree = new System.Windows.Forms.Button();
            this.lblQuestionsRight = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(12, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(57, 38);
            this.btnQuit.TabIndex = 18;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.White;
            this.lblQuestionNumber.Location = new System.Drawing.Point(335, 12);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(130, 38);
            this.lblQuestionNumber.TabIndex = 19;
            this.lblQuestionNumber.Text = "1";
            this.lblQuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestionNumber.Click += new System.EventHandler(this.lblQuestionNumber_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(12, 71);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(776, 100);
            this.lblQuestion.TabIndex = 20;
            this.lblQuestion.Text = "QUESTION";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOptionOne
            // 
            this.btnOptionOne.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptionOne.BackgroundImage")));
            this.btnOptionOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptionOne.FlatAppearance.BorderSize = 0;
            this.btnOptionOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionOne.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionOne.ForeColor = System.Drawing.Color.White;
            this.btnOptionOne.Location = new System.Drawing.Point(65, 202);
            this.btnOptionOne.Name = "btnOptionOne";
            this.btnOptionOne.Size = new System.Drawing.Size(291, 104);
            this.btnOptionOne.TabIndex = 21;
            this.btnOptionOne.Text = "OPTION ONE";
            this.btnOptionOne.UseVisualStyleBackColor = false;
            this.btnOptionOne.Click += new System.EventHandler(this.btnOptionOne_Click);
            // 
            // btnOptionTwo
            // 
            this.btnOptionTwo.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptionTwo.BackgroundImage")));
            this.btnOptionTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptionTwo.FlatAppearance.BorderSize = 0;
            this.btnOptionTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionTwo.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionTwo.ForeColor = System.Drawing.Color.White;
            this.btnOptionTwo.Location = new System.Drawing.Point(435, 202);
            this.btnOptionTwo.Name = "btnOptionTwo";
            this.btnOptionTwo.Size = new System.Drawing.Size(291, 104);
            this.btnOptionTwo.TabIndex = 22;
            this.btnOptionTwo.Text = "OPTION TWO";
            this.btnOptionTwo.UseVisualStyleBackColor = false;
            this.btnOptionTwo.Click += new System.EventHandler(this.btnOptionTwo_Click);
            // 
            // btnOptionFour
            // 
            this.btnOptionFour.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptionFour.BackgroundImage")));
            this.btnOptionFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptionFour.FlatAppearance.BorderSize = 0;
            this.btnOptionFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionFour.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionFour.ForeColor = System.Drawing.Color.White;
            this.btnOptionFour.Location = new System.Drawing.Point(435, 370);
            this.btnOptionFour.Name = "btnOptionFour";
            this.btnOptionFour.Size = new System.Drawing.Size(291, 104);
            this.btnOptionFour.TabIndex = 24;
            this.btnOptionFour.Text = "OPTION FOUR";
            this.btnOptionFour.UseVisualStyleBackColor = false;
            this.btnOptionFour.Click += new System.EventHandler(this.btnOptionFour_Click);
            // 
            // btnOptionThree
            // 
            this.btnOptionThree.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptionThree.BackgroundImage")));
            this.btnOptionThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptionThree.FlatAppearance.BorderSize = 0;
            this.btnOptionThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionThree.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionThree.ForeColor = System.Drawing.Color.White;
            this.btnOptionThree.Location = new System.Drawing.Point(65, 370);
            this.btnOptionThree.Name = "btnOptionThree";
            this.btnOptionThree.Size = new System.Drawing.Size(291, 104);
            this.btnOptionThree.TabIndex = 23;
            this.btnOptionThree.Text = "OPTION THREE";
            this.btnOptionThree.UseVisualStyleBackColor = false;
            this.btnOptionThree.Click += new System.EventHandler(this.btnOptionThree_Click);
            // 
            // lblQuestionsRight
            // 
            this.lblQuestionsRight.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionsRight.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionsRight.ForeColor = System.Drawing.Color.White;
            this.lblQuestionsRight.Location = new System.Drawing.Point(658, 12);
            this.lblQuestionsRight.Name = "lblQuestionsRight";
            this.lblQuestionsRight.Size = new System.Drawing.Size(130, 38);
            this.lblQuestionsRight.TabIndex = 25;
            this.lblQuestionsRight.Text = "1/1";
            this.lblQuestionsRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(19, 507);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(753, 42);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestionsRight);
            this.Controls.Add(this.btnOptionFour);
            this.Controls.Add(this.btnOptionThree);
            this.Controls.Add(this.btnOptionTwo);
            this.Controls.Add(this.btnOptionOne);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.btnQuit);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmQuiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnOptionOne;
        private System.Windows.Forms.Button btnOptionTwo;
        private System.Windows.Forms.Button btnOptionFour;
        private System.Windows.Forms.Button btnOptionThree;
        private System.Windows.Forms.Label lblQuestionsRight;
        private System.Windows.Forms.Button btnNext;
    }
}