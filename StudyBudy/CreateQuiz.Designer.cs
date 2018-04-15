namespace StudyBudy
{
    partial class CreateQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuiz));
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.txtQuizName = new System.Windows.Forms.TextBox();
            this.btnSaveQuiz = new System.Windows.Forms.Button();
            this.txtQuestionName = new System.Windows.Forms.TextBox();
            this.txtChoice1 = new System.Windows.Forms.TextBox();
            this.btnCorrect1 = new System.Windows.Forms.Button();
            this.btnCorrect2 = new System.Windows.Forms.Button();
            this.txtChoice2 = new System.Windows.Forms.TextBox();
            this.btnCorrect3 = new System.Windows.Forms.Button();
            this.txtChoice3 = new System.Windows.Forms.TextBox();
            this.btnCorrect4 = new System.Windows.Forms.Button();
            this.txtChoice4 = new System.Windows.Forms.TextBox();
            this.btnBonusQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnLoadSelected = new System.Windows.Forms.Button();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveSelected.FlatAppearance.BorderSize = 0;
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.Location = new System.Drawing.Point(283, 489);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(225, 25);
            this.btnRemoveSelected.TabIndex = 0;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // lstQuestions
            // 
            this.lstQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(221)))), ((int)(((byte)(86)))));
            this.lstQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstQuestions.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQuestions.ForeColor = System.Drawing.Color.White;
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.ItemHeight = 23;
            this.lstQuestions.Location = new System.Drawing.Point(12, 295);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(760, 184);
            this.lstQuestions.TabIndex = 1;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            // 
            // txtQuizName
            // 
            this.txtQuizName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuizName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuizName.Location = new System.Drawing.Point(12, 526);
            this.txtQuizName.Name = "txtQuizName";
            this.txtQuizName.Size = new System.Drawing.Size(653, 19);
            this.txtQuizName.TabIndex = 2;
            // 
            // btnSaveQuiz
            // 
            this.btnSaveQuiz.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveQuiz.FlatAppearance.BorderSize = 0;
            this.btnSaveQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQuiz.ForeColor = System.Drawing.Color.White;
            this.btnSaveQuiz.Location = new System.Drawing.Point(671, 522);
            this.btnSaveQuiz.Name = "btnSaveQuiz";
            this.btnSaveQuiz.Size = new System.Drawing.Size(101, 27);
            this.btnSaveQuiz.TabIndex = 3;
            this.btnSaveQuiz.Text = "Save Quiz";
            this.btnSaveQuiz.UseVisualStyleBackColor = false;
            this.btnSaveQuiz.Click += new System.EventHandler(this.btnSaveQuiz_Click);
            // 
            // txtQuestionName
            // 
            this.txtQuestionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestionName.Location = new System.Drawing.Point(50, 19);
            this.txtQuestionName.Name = "txtQuestionName";
            this.txtQuestionName.Size = new System.Drawing.Size(722, 22);
            this.txtQuestionName.TabIndex = 4;
            this.txtQuestionName.Text = "QUESTION";
            this.txtQuestionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuestionName.TextChanged += new System.EventHandler(this.txtQuestionName_TextChanged);
            // 
            // txtChoice1
            // 
            this.txtChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtChoice1.Location = new System.Drawing.Point(44, 102);
            this.txtChoice1.Name = "txtChoice1";
            this.txtChoice1.Size = new System.Drawing.Size(728, 29);
            this.txtChoice1.TabIndex = 5;
            this.txtChoice1.Text = "ANSWER CHOICE 1";
            this.txtChoice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChoice1.TextChanged += new System.EventHandler(this.txtChoice1_TextChanged);
            // 
            // btnCorrect1
            // 
            this.btnCorrect1.BackColor = System.Drawing.Color.Green;
            this.btnCorrect1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorrect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect1.ForeColor = System.Drawing.Color.White;
            this.btnCorrect1.Location = new System.Drawing.Point(12, 107);
            this.btnCorrect1.Name = "btnCorrect1";
            this.btnCorrect1.Size = new System.Drawing.Size(26, 23);
            this.btnCorrect1.TabIndex = 6;
            this.btnCorrect1.UseVisualStyleBackColor = false;
            this.btnCorrect1.Click += new System.EventHandler(this.btnCorrect1_Click);
            // 
            // btnCorrect2
            // 
            this.btnCorrect2.BackColor = System.Drawing.Color.Red;
            this.btnCorrect2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorrect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect2.ForeColor = System.Drawing.Color.White;
            this.btnCorrect2.Location = new System.Drawing.Point(12, 141);
            this.btnCorrect2.Name = "btnCorrect2";
            this.btnCorrect2.Size = new System.Drawing.Size(26, 23);
            this.btnCorrect2.TabIndex = 8;
            this.btnCorrect2.UseVisualStyleBackColor = false;
            this.btnCorrect2.Click += new System.EventHandler(this.btnCorrect2_Click);
            // 
            // txtChoice2
            // 
            this.txtChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtChoice2.Location = new System.Drawing.Point(44, 136);
            this.txtChoice2.Name = "txtChoice2";
            this.txtChoice2.Size = new System.Drawing.Size(728, 29);
            this.txtChoice2.TabIndex = 7;
            this.txtChoice2.Text = "ANSWER CHOICE 2";
            this.txtChoice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCorrect3
            // 
            this.btnCorrect3.BackColor = System.Drawing.Color.Red;
            this.btnCorrect3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorrect3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect3.ForeColor = System.Drawing.Color.White;
            this.btnCorrect3.Location = new System.Drawing.Point(12, 175);
            this.btnCorrect3.Name = "btnCorrect3";
            this.btnCorrect3.Size = new System.Drawing.Size(26, 23);
            this.btnCorrect3.TabIndex = 10;
            this.btnCorrect3.UseVisualStyleBackColor = false;
            this.btnCorrect3.Click += new System.EventHandler(this.btnCorrect3_Click);
            // 
            // txtChoice3
            // 
            this.txtChoice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtChoice3.Location = new System.Drawing.Point(44, 170);
            this.txtChoice3.Name = "txtChoice3";
            this.txtChoice3.Size = new System.Drawing.Size(728, 29);
            this.txtChoice3.TabIndex = 9;
            this.txtChoice3.Text = "ANSWER CHOICE 3";
            this.txtChoice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCorrect4
            // 
            this.btnCorrect4.BackColor = System.Drawing.Color.Red;
            this.btnCorrect4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorrect4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect4.ForeColor = System.Drawing.Color.White;
            this.btnCorrect4.Location = new System.Drawing.Point(12, 209);
            this.btnCorrect4.Name = "btnCorrect4";
            this.btnCorrect4.Size = new System.Drawing.Size(26, 23);
            this.btnCorrect4.TabIndex = 12;
            this.btnCorrect4.UseVisualStyleBackColor = false;
            this.btnCorrect4.Click += new System.EventHandler(this.btnCorrect4_Click);
            // 
            // txtChoice4
            // 
            this.txtChoice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtChoice4.Location = new System.Drawing.Point(44, 204);
            this.txtChoice4.Name = "txtChoice4";
            this.txtChoice4.Size = new System.Drawing.Size(728, 29);
            this.txtChoice4.TabIndex = 11;
            this.txtChoice4.Text = "ANSWER CHOICE 4";
            this.txtChoice4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBonusQuestion
            // 
            this.btnBonusQuestion.BackColor = System.Drawing.Color.Gray;
            this.btnBonusQuestion.FlatAppearance.BorderSize = 0;
            this.btnBonusQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBonusQuestion.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBonusQuestion.ForeColor = System.Drawing.Color.White;
            this.btnBonusQuestion.Location = new System.Drawing.Point(12, 50);
            this.btnBonusQuestion.Name = "btnBonusQuestion";
            this.btnBonusQuestion.Size = new System.Drawing.Size(760, 46);
            this.btnBonusQuestion.TabIndex = 13;
            this.btnBonusQuestion.Text = "BONUS";
            this.btnBonusQuestion.UseVisualStyleBackColor = false;
            this.btnBonusQuestion.Click += new System.EventHandler(this.btnBonusQuestion_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(161)))), ((int)(((byte)(26)))));
            this.btnAddQuestion.FlatAppearance.BorderSize = 0;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestion.Location = new System.Drawing.Point(12, 238);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(760, 51);
            this.btnAddQuestion.TabIndex = 14;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnLoadSelected
            // 
            this.btnLoadSelected.BackColor = System.Drawing.Color.Blue;
            this.btnLoadSelected.FlatAppearance.BorderSize = 0;
            this.btnLoadSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSelected.ForeColor = System.Drawing.Color.White;
            this.btnLoadSelected.Location = new System.Drawing.Point(547, 489);
            this.btnLoadSelected.Name = "btnLoadSelected";
            this.btnLoadSelected.Size = new System.Drawing.Size(225, 25);
            this.btnLoadSelected.TabIndex = 15;
            this.btnLoadSelected.Text = "Load Selected";
            this.btnLoadSelected.UseVisualStyleBackColor = false;
            this.btnLoadSelected.Click += new System.EventHandler(this.btnLoadSelected_Click);
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.BackColor = System.Drawing.Color.Fuchsia;
            this.btnUpdateSelected.FlatAppearance.BorderSize = 0;
            this.btnUpdateSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSelected.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSelected.Location = new System.Drawing.Point(12, 489);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(225, 25);
            this.btnUpdateSelected.TabIndex = 16;
            this.btnUpdateSelected.Text = "Update Selected";
            this.btnUpdateSelected.UseVisualStyleBackColor = false;
            this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // CreateQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateSelected);
            this.Controls.Add(this.btnLoadSelected);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnBonusQuestion);
            this.Controls.Add(this.btnCorrect4);
            this.Controls.Add(this.txtChoice4);
            this.Controls.Add(this.btnCorrect3);
            this.Controls.Add(this.txtChoice3);
            this.Controls.Add(this.btnCorrect2);
            this.Controls.Add(this.txtChoice2);
            this.Controls.Add(this.btnCorrect1);
            this.Controls.Add(this.txtChoice1);
            this.Controls.Add(this.txtQuestionName);
            this.Controls.Add(this.btnSaveQuiz);
            this.Controls.Add(this.txtQuizName);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.btnRemoveSelected);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CreateQuiz";
            this.ShowIcon = false;
            this.Text = "CreateQuiz";
            this.Load += new System.EventHandler(this.CreateQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.TextBox txtQuizName;
        private System.Windows.Forms.Button btnSaveQuiz;
        private System.Windows.Forms.TextBox txtQuestionName;
        private System.Windows.Forms.TextBox txtChoice1;
        private System.Windows.Forms.Button btnCorrect1;
        private System.Windows.Forms.Button btnCorrect2;
        private System.Windows.Forms.TextBox txtChoice2;
        private System.Windows.Forms.Button btnCorrect3;
        private System.Windows.Forms.TextBox txtChoice3;
        private System.Windows.Forms.Button btnCorrect4;
        private System.Windows.Forms.TextBox txtChoice4;
        private System.Windows.Forms.Button btnBonusQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnLoadSelected;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Button btnExit;
    }
}