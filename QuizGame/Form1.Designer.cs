namespace QuizGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PnlStartPage = new Panel();
            LblExit = new Label();
            LblStartQuiz = new Label();
            PnlQuiz = new Panel();
            PicBoxBgMusic = new PictureBox();
            customProgressBar = new CustomProgressBar();
            LblScore = new Label();
            LblQuestionNum = new Label();
            BtnCheckAnswer = new Button();
            PnlOptionA = new Panel();
            LblAnswerA = new Label();
            LblOptionA = new Label();
            PnlOptionB = new Panel();
            LblAnswerB = new Label();
            LblOptionB = new Label();
            PnlOptionC = new Panel();
            LblOptionC = new Label();
            LblAnswerC = new Label();
            PnlOptionD = new Panel();
            LblAnswerD = new Label();
            LblOptionD = new Label();
            LblQuestion = new Label();
            TimerQuestion = new System.Windows.Forms.Timer(components);
            PnlQuizResult = new Panel();
            LblExit2 = new Label();
            LblRetakeQuiz = new Label();
            LblViewQuizSheet = new Label();
            LblShowFinalScore = new Label();
            PnlQuizSheet = new Panel();
            PnlHeader = new Panel();
            label1 = new Label();
            LblClose = new Label();
            PnlStartPage.SuspendLayout();
            PnlQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxBgMusic).BeginInit();
            PnlOptionA.SuspendLayout();
            PnlOptionB.SuspendLayout();
            PnlOptionC.SuspendLayout();
            PnlOptionD.SuspendLayout();
            PnlQuizResult.SuspendLayout();
            PnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PnlStartPage
            // 
            PnlStartPage.BackColor = Color.FromArgb(1, 3, 38);
            PnlStartPage.BackgroundImage = Properties.Resources.Start_panel_bg;
            PnlStartPage.BackgroundImageLayout = ImageLayout.Stretch;
            PnlStartPage.Controls.Add(LblExit);
            PnlStartPage.Controls.Add(LblStartQuiz);
            PnlStartPage.Location = new Point(0, 25);
            PnlStartPage.Name = "PnlStartPage";
            PnlStartPage.Size = new Size(600, 475);
            PnlStartPage.TabIndex = 0;
            // 
            // LblExit
            // 
            LblExit.AutoSize = true;
            LblExit.BackColor = Color.Transparent;
            LblExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblExit.ForeColor = Color.FromArgb(60, 116, 166);
            LblExit.Location = new Point(272, 325);
            LblExit.Name = "LblExit";
            LblExit.Size = new Size(57, 30);
            LblExit.TabIndex = 3;
            LblExit.Text = "EXIT";
            LblExit.Click += LblExit_Click;
            LblExit.MouseLeave += LblExit_MouseLeave;
            LblExit.MouseHover += LblExit_MouseHover;
            // 
            // LblStartQuiz
            // 
            LblStartQuiz.AutoSize = true;
            LblStartQuiz.BackColor = Color.Transparent;
            LblStartQuiz.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStartQuiz.ForeColor = Color.FromArgb(60, 116, 166);
            LblStartQuiz.Location = new Point(233, 245);
            LblStartQuiz.Name = "LblStartQuiz";
            LblStartQuiz.Size = new Size(134, 30);
            LblStartQuiz.TabIndex = 2;
            LblStartQuiz.Text = "START QUIZ";
            LblStartQuiz.Click += LblStartQuiz_Click;
            LblStartQuiz.MouseLeave += LblStartQuiz_MouseLeave;
            LblStartQuiz.MouseHover += LblStartQuiz_MouseHover;
            // 
            // PnlQuiz
            // 
            PnlQuiz.BackColor = Color.FromArgb(1, 3, 38);
            PnlQuiz.BackgroundImage = Properties.Resources.Quiz_panel_bg;
            PnlQuiz.BackgroundImageLayout = ImageLayout.Stretch;
            PnlQuiz.Controls.Add(PicBoxBgMusic);
            PnlQuiz.Controls.Add(customProgressBar);
            PnlQuiz.Controls.Add(LblScore);
            PnlQuiz.Controls.Add(LblQuestionNum);
            PnlQuiz.Controls.Add(BtnCheckAnswer);
            PnlQuiz.Controls.Add(PnlOptionA);
            PnlQuiz.Controls.Add(PnlOptionB);
            PnlQuiz.Controls.Add(PnlOptionC);
            PnlQuiz.Controls.Add(PnlOptionD);
            PnlQuiz.Controls.Add(LblQuestion);
            PnlQuiz.Location = new Point(0, 25);
            PnlQuiz.Name = "PnlQuiz";
            PnlQuiz.Size = new Size(600, 475);
            PnlQuiz.TabIndex = 2;
            PnlQuiz.Visible = false;
            // 
            // PicBoxBgMusic
            // 
            PicBoxBgMusic.BackgroundImage = Properties.Resources.volume_mute;
            PicBoxBgMusic.BackgroundImageLayout = ImageLayout.Stretch;
            PicBoxBgMusic.Location = new Point(560, 20);
            PicBoxBgMusic.Name = "PicBoxBgMusic";
            PicBoxBgMusic.Size = new Size(25, 25);
            PicBoxBgMusic.TabIndex = 8;
            PicBoxBgMusic.TabStop = false;
            PicBoxBgMusic.Click += PicBoxBgMusic_Click;
            // 
            // customProgressBar
            // 
            customProgressBar.BackColor = Color.FromArgb(60, 116, 166);
            customProgressBar.Blue = 173;
            customProgressBar.ForeColor = Color.FromArgb(90, 191, 173);
            customProgressBar.Green = 191;
            customProgressBar.Location = new Point(0, 0);
            customProgressBar.Maximum = 30;
            customProgressBar.Name = "customProgressBar";
            customProgressBar.Red = 90;
            customProgressBar.Size = new Size(600, 15);
            customProgressBar.Style = ProgressBarStyle.Continuous;
            customProgressBar.TabIndex = 0;
            // 
            // LblScore
            // 
            LblScore.AutoSize = true;
            LblScore.BackColor = Color.Transparent;
            LblScore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblScore.ForeColor = Color.White;
            LblScore.Location = new Point(480, 49);
            LblScore.Name = "LblScore";
            LblScore.Size = new Size(83, 25);
            LblScore.TabIndex = 7;
            LblScore.Text = "Score: 0";
            // 
            // LblQuestionNum
            // 
            LblQuestionNum.AutoSize = true;
            LblQuestionNum.BackColor = Color.Transparent;
            LblQuestionNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblQuestionNum.ForeColor = Color.White;
            LblQuestionNum.Location = new Point(35, 49);
            LblQuestionNum.Name = "LblQuestionNum";
            LblQuestionNum.Size = new Size(92, 25);
            LblQuestionNum.TabIndex = 6;
            LblQuestionNum.Text = "Question";
            // 
            // BtnCheckAnswer
            // 
            BtnCheckAnswer.BackColor = Color.FromArgb(90, 191, 173);
            BtnCheckAnswer.FlatAppearance.BorderColor = Color.FromArgb(25, 41, 89);
            BtnCheckAnswer.FlatStyle = FlatStyle.Flat;
            BtnCheckAnswer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCheckAnswer.Location = new Point(225, 390);
            BtnCheckAnswer.Name = "BtnCheckAnswer";
            BtnCheckAnswer.Size = new Size(150, 50);
            BtnCheckAnswer.TabIndex = 5;
            BtnCheckAnswer.Text = "Check Answer";
            BtnCheckAnswer.UseVisualStyleBackColor = false;
            BtnCheckAnswer.Click += BtnCheckAnswer_Click;
            // 
            // PnlOptionA
            // 
            PnlOptionA.BackColor = Color.FromArgb(25, 41, 89);
            PnlOptionA.Controls.Add(LblAnswerA);
            PnlOptionA.Controls.Add(LblOptionA);
            PnlOptionA.Location = new Point(36, 229);
            PnlOptionA.Name = "PnlOptionA";
            PnlOptionA.Size = new Size(250, 50);
            PnlOptionA.TabIndex = 3;
            PnlOptionA.Click += PnlOptionA_Click;
            // 
            // LblAnswerA
            // 
            LblAnswerA.AutoSize = true;
            LblAnswerA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAnswerA.ForeColor = Color.White;
            LblAnswerA.Location = new Point(34, 14);
            LblAnswerA.Name = "LblAnswerA";
            LblAnswerA.Size = new Size(100, 21);
            LblAnswerA.TabIndex = 2;
            LblAnswerA.Text = "LblAnswerA";
            LblAnswerA.Click += LblAnswerA_Click;
            // 
            // LblOptionA
            // 
            LblOptionA.AutoSize = true;
            LblOptionA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblOptionA.ForeColor = Color.White;
            LblOptionA.Location = new Point(3, 14);
            LblOptionA.Name = "LblOptionA";
            LblOptionA.Size = new Size(25, 21);
            LblOptionA.TabIndex = 0;
            LblOptionA.Text = "A.";
            LblOptionA.Click += LblOptionA_Click;
            // 
            // PnlOptionB
            // 
            PnlOptionB.BackColor = Color.FromArgb(25, 41, 89);
            PnlOptionB.Controls.Add(LblAnswerB);
            PnlOptionB.Controls.Add(LblOptionB);
            PnlOptionB.Location = new Point(36, 307);
            PnlOptionB.Name = "PnlOptionB";
            PnlOptionB.Size = new Size(250, 50);
            PnlOptionB.TabIndex = 1;
            PnlOptionB.Click += PnlOptionB_Click;
            // 
            // LblAnswerB
            // 
            LblAnswerB.AutoSize = true;
            LblAnswerB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAnswerB.ForeColor = Color.White;
            LblAnswerB.Location = new Point(34, 14);
            LblAnswerB.Name = "LblAnswerB";
            LblAnswerB.Size = new Size(57, 21);
            LblAnswerB.TabIndex = 3;
            LblAnswerB.Text = "label2";
            LblAnswerB.Click += LblAnswerB_Click;
            // 
            // LblOptionB
            // 
            LblOptionB.AutoSize = true;
            LblOptionB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblOptionB.ForeColor = Color.White;
            LblOptionB.Location = new Point(3, 14);
            LblOptionB.Name = "LblOptionB";
            LblOptionB.Size = new Size(24, 21);
            LblOptionB.TabIndex = 1;
            LblOptionB.Text = "B.";
            LblOptionB.Click += LblOptionB_Click;
            // 
            // PnlOptionC
            // 
            PnlOptionC.BackColor = Color.FromArgb(25, 41, 89);
            PnlOptionC.Controls.Add(LblOptionC);
            PnlOptionC.Controls.Add(LblAnswerC);
            PnlOptionC.Location = new Point(314, 229);
            PnlOptionC.Name = "PnlOptionC";
            PnlOptionC.Size = new Size(250, 50);
            PnlOptionC.TabIndex = 2;
            PnlOptionC.Click += PnlOptionC_Click;
            // 
            // LblOptionC
            // 
            LblOptionC.AutoSize = true;
            LblOptionC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblOptionC.ForeColor = Color.White;
            LblOptionC.Location = new Point(4, 14);
            LblOptionC.Name = "LblOptionC";
            LblOptionC.Size = new Size(24, 21);
            LblOptionC.TabIndex = 1;
            LblOptionC.Text = "C.";
            LblOptionC.Click += LblOptionC_Click;
            // 
            // LblAnswerC
            // 
            LblAnswerC.AutoSize = true;
            LblAnswerC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAnswerC.ForeColor = Color.White;
            LblAnswerC.Location = new Point(34, 14);
            LblAnswerC.Name = "LblAnswerC";
            LblAnswerC.Size = new Size(57, 21);
            LblAnswerC.TabIndex = 3;
            LblAnswerC.Text = "label3";
            LblAnswerC.Click += LblAnswerC_Click;
            // 
            // PnlOptionD
            // 
            PnlOptionD.BackColor = Color.FromArgb(25, 41, 89);
            PnlOptionD.Controls.Add(LblAnswerD);
            PnlOptionD.Controls.Add(LblOptionD);
            PnlOptionD.Location = new Point(314, 307);
            PnlOptionD.Name = "PnlOptionD";
            PnlOptionD.Size = new Size(250, 50);
            PnlOptionD.TabIndex = 0;
            PnlOptionD.Click += PnlOptionD_Click;
            // 
            // LblAnswerD
            // 
            LblAnswerD.AutoSize = true;
            LblAnswerD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAnswerD.ForeColor = Color.White;
            LblAnswerD.Location = new Point(34, 14);
            LblAnswerD.Name = "LblAnswerD";
            LblAnswerD.Size = new Size(57, 21);
            LblAnswerD.TabIndex = 4;
            LblAnswerD.Text = "label4";
            LblAnswerD.Click += LblAnswerD_Click;
            // 
            // LblOptionD
            // 
            LblOptionD.AutoSize = true;
            LblOptionD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblOptionD.ForeColor = Color.White;
            LblOptionD.Location = new Point(4, 14);
            LblOptionD.Name = "LblOptionD";
            LblOptionD.Size = new Size(25, 21);
            LblOptionD.TabIndex = 2;
            LblOptionD.Text = "D.";
            LblOptionD.Click += LblOptionD_Click;
            // 
            // LblQuestion
            // 
            LblQuestion.BackColor = Color.Transparent;
            LblQuestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblQuestion.ForeColor = Color.White;
            LblQuestion.Location = new Point(36, 100);
            LblQuestion.Name = "LblQuestion";
            LblQuestion.Size = new Size(528, 100);
            LblQuestion.TabIndex = 0;
            LblQuestion.Text = "label1";
            // 
            // TimerQuestion
            // 
            TimerQuestion.Tick += TimerQuestion_Tick;
            // 
            // PnlQuizResult
            // 
            PnlQuizResult.BackColor = Color.FromArgb(1, 3, 38);
            PnlQuizResult.BackgroundImage = Properties.Resources.Result_panel_bg;
            PnlQuizResult.BackgroundImageLayout = ImageLayout.Stretch;
            PnlQuizResult.Controls.Add(LblExit2);
            PnlQuizResult.Controls.Add(LblRetakeQuiz);
            PnlQuizResult.Controls.Add(LblViewQuizSheet);
            PnlQuizResult.Controls.Add(LblShowFinalScore);
            PnlQuizResult.Location = new Point(0, 25);
            PnlQuizResult.Name = "PnlQuizResult";
            PnlQuizResult.Size = new Size(600, 475);
            PnlQuizResult.TabIndex = 4;
            PnlQuizResult.Visible = false;
            // 
            // LblExit2
            // 
            LblExit2.AutoSize = true;
            LblExit2.BackColor = Color.Transparent;
            LblExit2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LblExit2.ForeColor = Color.FromArgb(60, 116, 166);
            LblExit2.Location = new Point(272, 365);
            LblExit2.Name = "LblExit2";
            LblExit2.Size = new Size(57, 30);
            LblExit2.TabIndex = 3;
            LblExit2.Text = "EXIT";
            LblExit2.Click += LblExit2_Click;
            LblExit2.MouseLeave += LblExit2_MouseLeave;
            LblExit2.MouseHover += LblExit2_MouseHover;
            // 
            // LblRetakeQuiz
            // 
            LblRetakeQuiz.AutoSize = true;
            LblRetakeQuiz.BackColor = Color.Transparent;
            LblRetakeQuiz.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LblRetakeQuiz.ForeColor = Color.FromArgb(60, 116, 166);
            LblRetakeQuiz.Location = new Point(227, 299);
            LblRetakeQuiz.Name = "LblRetakeQuiz";
            LblRetakeQuiz.Size = new Size(146, 30);
            LblRetakeQuiz.TabIndex = 2;
            LblRetakeQuiz.Text = "RETAKE QUIZ";
            LblRetakeQuiz.Click += LblRetakeQuiz_Click;
            LblRetakeQuiz.MouseLeave += LblRetakeQuiz_MouseLeave;
            LblRetakeQuiz.MouseHover += LblRetakeQuiz_MouseHover;
            // 
            // LblViewQuizSheet
            // 
            LblViewQuizSheet.AutoSize = true;
            LblViewQuizSheet.BackColor = Color.Transparent;
            LblViewQuizSheet.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LblViewQuizSheet.ForeColor = Color.FromArgb(60, 116, 166);
            LblViewQuizSheet.Location = new Point(205, 233);
            LblViewQuizSheet.Name = "LblViewQuizSheet";
            LblViewQuizSheet.Size = new Size(191, 30);
            LblViewQuizSheet.TabIndex = 1;
            LblViewQuizSheet.Text = "VIEW QUIZ SHEET";
            LblViewQuizSheet.Click += LblViewQuizSheet_Click;
            LblViewQuizSheet.MouseLeave += LblViewQuizSheet_MouseLeave;
            LblViewQuizSheet.MouseHover += LblViewQuizSheet_MouseHover;
            // 
            // LblShowFinalScore
            // 
            LblShowFinalScore.AutoSize = true;
            LblShowFinalScore.BackColor = Color.Transparent;
            LblShowFinalScore.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblShowFinalScore.ForeColor = Color.FromArgb(90, 191, 173);
            LblShowFinalScore.Location = new Point(127, 80);
            LblShowFinalScore.Name = "LblShowFinalScore";
            LblShowFinalScore.Size = new Size(347, 34);
            LblShowFinalScore.TabIndex = 0;
            LblShowFinalScore.Text = "Your Final Score is 5/5";
            // 
            // PnlQuizSheet
            // 
            PnlQuizSheet.AutoScroll = true;
            PnlQuizSheet.AutoScrollMargin = new Size(0, 30);
            PnlQuizSheet.Location = new Point(0, 25);
            PnlQuizSheet.Name = "PnlQuizSheet";
            PnlQuizSheet.Size = new Size(600, 475);
            PnlQuizSheet.TabIndex = 4;
            PnlQuizSheet.Visible = false;
            // 
            // PnlHeader
            // 
            PnlHeader.BackColor = Color.Gainsboro;
            PnlHeader.Controls.Add(label1);
            PnlHeader.Controls.Add(LblClose);
            PnlHeader.Dock = DockStyle.Top;
            PnlHeader.Location = new Point(0, 0);
            PnlHeader.Name = "PnlHeader";
            PnlHeader.Size = new Size(600, 25);
            PnlHeader.TabIndex = 4;
            PnlHeader.MouseDown += PnlHeader_MouseDown;
            PnlHeader.MouseMove += PnlHeader_MouseMove;
            PnlHeader.MouseUp += PnlHeader_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 2);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Quizzerium";
            // 
            // LblClose
            // 
            LblClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblClose.ForeColor = Color.Black;
            LblClose.Location = new Point(560, 0);
            LblClose.Name = "LblClose";
            LblClose.Size = new Size(40, 25);
            LblClose.TabIndex = 0;
            LblClose.Text = "X";
            LblClose.TextAlign = ContentAlignment.MiddleCenter;
            LblClose.Click += LblClose_Click;
            LblClose.MouseLeave += LblClose_MouseLeave;
            LblClose.MouseHover += LblClose_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 500);
            Controls.Add(PnlHeader);
            Controls.Add(PnlStartPage);
            Controls.Add(PnlQuiz);
            Controls.Add(PnlQuizResult);
            Controls.Add(PnlQuizSheet);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PnlStartPage.ResumeLayout(false);
            PnlStartPage.PerformLayout();
            PnlQuiz.ResumeLayout(false);
            PnlQuiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxBgMusic).EndInit();
            PnlOptionA.ResumeLayout(false);
            PnlOptionA.PerformLayout();
            PnlOptionB.ResumeLayout(false);
            PnlOptionB.PerformLayout();
            PnlOptionC.ResumeLayout(false);
            PnlOptionC.PerformLayout();
            PnlOptionD.ResumeLayout(false);
            PnlOptionD.PerformLayout();
            PnlQuizResult.ResumeLayout(false);
            PnlQuizResult.PerformLayout();
            PnlHeader.ResumeLayout(false);
            PnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlStartPage;
        private Panel PnlQuiz;
        private Label LblQuestion;
        private Panel PnlOptionD;
        private Panel PnlOptionB;
        private Panel PnlOptionC;
        private Panel PnlOptionA;
        private Label LblOptionC;
        private Label LblOptionB;
        private Label LblOptionA;
        private Label LblOptionD;
        private Label LblAnswerC;
        private Label LblAnswerB;
        private Label LblAnswerA;
        private Label LblAnswerD;
        private Button BtnCheckAnswer;
        private Label LblQuestionNum;
        private System.Windows.Forms.Timer TimerQuestion;
        private Label LblExit;
        private Label LblStartQuiz;
        private CustomProgressBar customProgressBar;
        private Label LblScore;
        private Panel PnlQuizResult;
        private Label LblViewQuizSheet;
        private Label LblShowFinalScore;
        private Label LblRetakeQuiz;
        private Label LblExit2;
        private Panel PnlQuizSheet;
        private Panel PnlHeader;
        private Label LblClose;
        private PictureBox PicBoxBgMusic;
        private Label label1;
    }
}
