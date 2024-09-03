using WMPLib;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        struct Quiz(string question, string option1, string option2, string option3, string option4, string correctAnswer)
        {
            public string question = question;
            public string option1 = option1;
            public string option2 = option2;
            public string option3 = option3;
            public string option4 = option4;
            public string correctAnswer = correctAnswer;
        }

        struct QuizSheet(string question, string option1, string option2, string option3, string option4, string correctAnswer, string userAnswer, int duration)
        {
            public string question = question;
            public string option1 = option1;
            public string option2 = option2;
            public string option3 = option3;
            public string option4 = option4;
            public string correctAnswer = correctAnswer;
            public string userAnswer = userAnswer;
            public int duration = duration;
        }

        int selectQuestion, score = 0, questionNum = 0, quizSheetCtr = 0;
        string selectedAnswer = "";
        static Quiz[] myQuiz = new Quiz[5];
        QuizSheet[] quizSheet = new QuizSheet[5];
        int numQuizItems = myQuiz.Length;
        int tempNumQuizItems = myQuiz.Length;

        private WindowsMediaPlayer bgMusic;
        bool playBgMusic = true;

        private bool dragHeader = false;
        private Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            CustomStyles();                 // Fucntion call to apply custom styling for panels
            TimerQuestion.Interval = 1000;  // Set the interval of the timer control into 1 sec

            bgMusic = new WindowsMediaPlayer();
            bgMusic.URL = @"C:\Users\Mark Daniel\Downloads\quiz-countdown-194417.mp3";
            bgMusic.controls.stop();    // Stop background music
        }

        private void LblStartQuiz_Click(object sender, EventArgs e)
        {
            QuestionLists();    // Function call to initialize the questions in the myQuiz array
            LoadQuestion();     // Function call to display the question text and choices

            bgMusic.controls.play();

            // Change panel
            PnlStartPage.Visible = false;
            PnlQuiz.Visible = true;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            this.Close();   // Clos the program
        }

        private void PicBoxBgMusic_Click(object sender, EventArgs e)
        {
            // Changes the background image of the BGM button either enabled or disabled
            playBgMusic = !playBgMusic;

            if (playBgMusic)
            {
                PicBoxBgMusic.BackgroundImage = Properties.Resources.volume_mute;
                bgMusic.controls.play();
            }
            else
            {
                PicBoxBgMusic.BackgroundImage = Properties.Resources.volume_up;
                bgMusic.controls.pause();   // Pause background music
            }
        }

        private void LoadQuestion()
        {
            if (questionNum < myQuiz.Length)
            {
                TimerQuestion.Start();      // Start the timer

                selectQuestion = ShuffleQuestion();     // Select the random number for randomly displaying the questions

                // Displayes the choices in the following labels
                LblQuestion.Text = myQuiz[selectQuestion].question;
                LblAnswerA.Text = myQuiz[selectQuestion].option1;
                LblAnswerB.Text = myQuiz[selectQuestion].option2;
                LblAnswerC.Text = myQuiz[selectQuestion].option3;
                LblAnswerD.Text = myQuiz[selectQuestion].option4;

                questionNum++;

                // Display the question number and total questions to answer
                LblQuestionNum.Text = $"Question: {questionNum} / {tempNumQuizItems}";
            }
            else
            {
                TimerQuestion.Stop();   // Stops the timer
                bgMusic.controls.stop();    // Stop background music

                // Displays the final score
                LblShowFinalScore.Text = $"Your Final Score is {score} / {tempNumQuizItems}";

                // Change panel
                PnlQuiz.Visible = false;
                PnlQuizResult.Visible = true;
            }

        }

        private int ShuffleQuestion()
        {
            // Random number generator base on the number of questions and returns the value
            Random random = new Random();
            int randomQuestion = random.Next(numQuizItems);
            return randomQuestion;
        }

        private void PnlOptionA_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerA.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionA, LblOptionA, LblAnswerA);
        }

        private void PnlOptionB_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerB.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionB, LblOptionB, LblAnswerB);
        }

        private void PnlOptionC_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerC.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionC, LblOptionC, LblAnswerC);
        }

        private void PnlOptionD_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerD.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionD, LblOptionD, LblAnswerD);
        }

        private void BtnCheckAnswer_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedAnswer))
            {
                CheckAnswer();
            }
        }

        private async void CheckAnswer()
        {
            DefaultStyle();

            // Checks the users answer after answering the question
            // Background color changes base on the result
            if (selectedAnswer == myQuiz[selectQuestion].correctAnswer)
            {
                score++;
                LblScore.Text = $"Score: {score}";
                // Function call to change the background color of the panel when the answer is correct 
                OptionResultStyle(33, 217, 4, true);  // Color green      
            }
            else
            {
                // Function call to change the background color of the panel when the answer is incorrect 
                OptionResultStyle(33, 217, 4, false);   // Color green
                OptionResultStyle(242, 5, 25, true);    // Color red
            }

            // Store the result into another struct for the viewing of the quiz sheet
            quizSheet[quizSheetCtr] = new QuizSheet(myQuiz[selectQuestion].question, myQuiz[selectQuestion].option1, myQuiz[selectQuestion].option2, myQuiz[selectQuestion].option3, myQuiz[selectQuestion].option4, myQuiz[selectQuestion].correctAnswer, selectedAnswer, customProgressBar.Value);
            quizSheetCtr++;

            await Task.Delay(1500);         // Pause before loading the next question
            RemoveAnsweredQuestion();       // Function call to remove already answered question in the struct
            customProgressBar.Value = 0;    // Reset the timer
            selectedAnswer = "";
            DefaultStyle();                 // Change the color of the choices panel to default
            LoadQuestion();                 // Display next question and choices
        }

        private void OptionResultStyle(int red, int green, int blue, bool correct)
        {
            Color resultColor = Color.FromArgb(red, green, blue);

            if (correct)
            {
                if (selectedAnswer == LblAnswerA.Text)
                {
                    PnlOptionA.BackColor = resultColor;
                }
                else if (selectedAnswer == LblAnswerB.Text)
                {
                    PnlOptionB.BackColor = resultColor;
                }
                else if (selectedAnswer == LblAnswerC.Text)
                {
                    PnlOptionC.BackColor = resultColor;
                }
                else if (selectedAnswer == LblAnswerD.Text)
                {
                    PnlOptionD.BackColor = resultColor;
                }
            }
            else
            {
                string correctAnswer = myQuiz[selectQuestion].correctAnswer;

                if (correctAnswer == LblAnswerA.Text)
                {
                    PnlOptionA.BackColor = resultColor;
                }
                else if (correctAnswer == LblAnswerB.Text)
                {
                    PnlOptionB.BackColor = resultColor;
                }
                else if (correctAnswer == LblAnswerC.Text)
                {
                    PnlOptionC.BackColor = resultColor;
                }
                else if (correctAnswer == LblAnswerD.Text)
                {
                    PnlOptionD.BackColor = resultColor;
                }
            }
        }

        private void RemoveAnsweredQuestion()
        {
            // Delete the answered question into the array and traverse the element
            for (int i = selectQuestion; i < numQuizItems - 1; i++)
            {
                myQuiz[i] = myQuiz[i + 1];
            }

            numQuizItems--;
            myQuiz[numQuizItems] = default;
        }

        private void TimerQuestion_Tick(object sender, EventArgs e)
        {
            // Progress bar timer up to 30 seconds
            // Automatically check the answer when the time runs out
            if (customProgressBar.Value < 30)
            {
                customProgressBar.Value += 1;
            }
            else
            {
                TimerQuestion.Stop();
                CheckAnswer();
            }
        }

        private void LblViewQuizSheet_Click(object sender, EventArgs e)
        {
            DisplayQuizSheet();
            PnlQuizResult.Visible = false;
            PnlQuizSheet.Visible = true;
        }

        private void DisplayQuizSheet()
        {
            int scorePosX = 418, scorePosY = 24;
            int questionNumPosX = 48, questionNumPosY = 74;
            int resultPosX = 160, resultPosY = 77;
            int noAnswerPosX = 250, noAnswerPosY = 77;
            int timePosX = 431, timePosY = 78;
            int questionTextPosX = 78, questionTextPosY = 113;

            int optionAPosX = 92, optionBPosX = 92, optionCPosX = 440, optionDPosX = 440;
            int optionAPosY = 154, optionBPosY = 202, optionCPosY = 154, optionDPosY = 202;

            int verticalSpacing = 180;

            Label LblShowScore = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 14.25F, FontStyle.Bold),
                Location = new Point(scorePosX, scorePosY),
                Name = "LblShowScore",
                Text = $"Score: {score} / {tempNumQuizItems}" // Set text dynamically
            };

            PnlQuizSheet.Controls.Add(LblShowScore);

            for (int i = 0; i < tempNumQuizItems; i++)
            {
                // Create a new Label for each iteration
                Label LblShowQuestionNum = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14.25F, FontStyle.Bold),
                    Location = new Point(questionNumPosX, questionNumPosY + (i * verticalSpacing)),
                    Name = "LblShowQuestionNum",
                    Text = $"Question {i + 1}" // Set text dynamically
                };

                Label LblShowResult = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    Location = new Point(resultPosX, resultPosY + (i * verticalSpacing)),
                    Name = "LblShowResult",
                    // Checks if the answer is correct or not and display's the appropriate text
                    Text = quizSheet[i].userAnswer == quizSheet[i].correctAnswer ? "Correct" : "Incorrect",
                    // Checks if the answer is correct or not and use the appropriate text color
                    ForeColor = quizSheet[i].userAnswer == quizSheet[i].correctAnswer ? Color.Green : Color.Red,
                };

                Label LblShowNoAnswer = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    Location = new Point(noAnswerPosX, noAnswerPosY + (i * verticalSpacing)),
                    Name = "LblShowNoAnswer",
                    Text = string.IsNullOrEmpty(quizSheet[i].userAnswer) ? "No answer" : "",
                    ForeColor = Color.Red
                };

                Label LblShowTimeDuration = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    Location = new Point(timePosX, timePosY + (i * verticalSpacing)),
                    Name = "LblShowTimeDuration",
                    Text = $"Duration: {quizSheet[i].duration} sec" // Set text dynamically
                };

                Label LblShowQuestionText = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    Location = new Point(questionTextPosX, questionTextPosY + (i * verticalSpacing)),
                    Name = "LblShowQuestionText",
                    Text = quizSheet[i].question // Set text dynamically
                };

                Label LblShowOptionA = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    Location = new Point(optionAPosX, optionAPosY + (i * verticalSpacing)),
                    Name = "LblShowOptionA",
                    Padding = new Padding(7, 3, 7, 3),
                    Text = $"A. {quizSheet[i].option1}" // Set text dynamically
                };

                Label LblShowOptionB = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    Location = new Point(optionBPosX, optionBPosY + (i * verticalSpacing)),
                    Name = "LblShowOptionB",
                    Padding = new Padding(7, 3, 7, 3),
                    Text = $"B. {quizSheet[i].option2}" // Set text dynamically
                };

                Label LblShowOptionC = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    Location = new Point(optionCPosX, optionCPosY + (i * verticalSpacing)),
                    Name = "LblShowOptionC",
                    Padding = new Padding(7, 3, 7, 3),
                    Text = $"C. {quizSheet[i].option3}" // Set text dynamically
                };

                Label LblShowOptionD = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    Location = new Point(optionDPosX, optionDPosY + (i * verticalSpacing)),
                    Name = "LblShowOptionD",
                    Padding = new Padding(7, 3, 7, 3),
                    Text = $"D. {quizSheet[i].option4}" // Set text dynamically
                };

                if (quizSheet[i].userAnswer == quizSheet[i].correctAnswer)
                {
                    // Function call to change the background color of the panel when the answer is correct 
                    QuizSheetResultStyle(LblShowOptionA, LblShowOptionB, LblShowOptionC, LblShowOptionD, i, 33, 217, 4, true);  // Color green 
                }
                else
                {
                    // Function call to change the background color of the panel when the answer is incorrect 
                    QuizSheetResultStyle(LblShowOptionA, LblShowOptionB, LblShowOptionC, LblShowOptionD, i, 33, 217, 4, false);   // Color green
                    QuizSheetResultStyle(LblShowOptionA, LblShowOptionB, LblShowOptionC, LblShowOptionD, i, 242, 5, 25, true);    // Color red
                }

                // Add the label to the form's Controls collection
                PnlQuizSheet.Controls.Add(LblShowQuestionNum);
                PnlQuizSheet.Controls.Add(LblShowResult);
                PnlQuizSheet.Controls.Add(LblShowNoAnswer);
                PnlQuizSheet.Controls.Add(LblShowTimeDuration);
                PnlQuizSheet.Controls.Add(LblShowQuestionText);

                PnlQuizSheet.Controls.Add(LblShowOptionA);
                PnlQuizSheet.Controls.Add(LblShowOptionB);
                PnlQuizSheet.Controls.Add(LblShowOptionC);
                PnlQuizSheet.Controls.Add(LblShowOptionD);

                MyModule.SetRoundedCorners(LblShowOptionA, 2, 2, 2, 2);
                MyModule.SetRoundedCorners(LblShowOptionB, 2, 2, 2, 2);
                MyModule.SetRoundedCorners(LblShowOptionC, 2, 2, 2, 2);
                MyModule.SetRoundedCorners(LblShowOptionD, 2, 2, 2, 2);
            }

            int btnBackPosX = 259, btnBackPosY = verticalSpacing * tempNumQuizItems;

            Label BtnBack = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = new Point(btnBackPosX, btnBackPosY + 100),
                Name = "BtnBack",
                //BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15, 6, 15, 6),
                BackColor = Color.FromArgb(1, 3, 38),
                ForeColor = Color.FromArgb(60, 116, 166),
                Text = "BACK" // Set text dynamically
            };

            BtnBack.Click += BtnBack_Click;
            //BtnBack.MouseHover += BtnBack_MouseHover;
            //BtnBack.MouseLeave += BtnBack_MouseLeave;
            PnlQuizSheet.Controls.Add(BtnBack);
            MyModule.SetRoundedCorners(BtnBack, 2, 2, 2, 2);

            //Button BtnBack = new Button
            //{
            //    //BackColor = Color.FromArgb(90, 191, 173),
            //    //FlatAppearance.BorderColor = Color.FromArgb(25, 41, 89),
            //    FlatStyle = FlatStyle.Flat,
            //    Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
            //    Location = new Point(btnBackPosX, btnBackPosY + 100),
            //    Name = "BtnBack",
            //    Size = new Size(120, 40),
            //    Text = "BACK",
            //    //UseVisualStyleBackColor = false,
            //    //Click += BtnCheckAnswer_Click
            //};
        }

        private void QuizSheetResultStyle(Label lblOptionA, Label lblOptionB, Label lblOptionC, Label lblOptionD, int ctr, int red, int green, int blue, bool correct)
        {
            Color resultColor = Color.FromArgb(red, green, blue);

            // Removes the leading letter option, dot, and space and extracts the choices only
            string optionA = lblOptionA.Text.Substring(3);
            string optionB = lblOptionB.Text.Substring(3);
            string optionC = lblOptionC.Text.Substring(3);
            string optionD = lblOptionD.Text.Substring(3);

            if (correct)
            {
                if (quizSheet[ctr].userAnswer == optionA)
                {
                    lblOptionA.BackColor = resultColor;
                }
                else if (quizSheet[ctr].userAnswer == optionB)
                {
                    lblOptionB.BackColor = resultColor;
                }
                else if (quizSheet[ctr].userAnswer == optionC)
                {
                    lblOptionC.BackColor = resultColor;
                }
                else if (quizSheet[ctr].userAnswer == optionD)
                {
                    lblOptionD.BackColor = resultColor;
                }
            }
            else
            {
                if (quizSheet[ctr].correctAnswer == optionA)
                {
                    lblOptionA.BackColor = resultColor;
                }
                else if (quizSheet[ctr].correctAnswer == optionB)
                {
                    lblOptionB.BackColor = resultColor;
                }
                else if (quizSheet[ctr].correctAnswer == optionC)
                {
                    lblOptionC.BackColor = resultColor;
                }
                else if (quizSheet[ctr].correctAnswer == optionD)
                {
                    lblOptionD.BackColor = resultColor;
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            PnlQuizSheet.Visible = false;
            PnlQuizResult.Visible = true;
            PnlQuizSheet.Controls.Clear();
        }

        //private void BtnBack_MouseHover(object sender, EventArgs e)
        //{
        //    BtnBack.ForeColor = Color.FromArgb(90, 191, 173);
        //}

        //private void BtnBack_MouseLeave(object sender, EventArgs e)
        //{
        //    BtnBack.ForeColor = Color.FromArgb(60, 116, 166);
        //}

        private void LblRetakeQuiz_Click(object sender, EventArgs e)
        {
            // Clear and initialized the defaul values of variables
            for (int i = 0; i < numQuizItems; i++)
            {
                quizSheet[quizSheetCtr] = default;
            }

            score = 0;
            questionNum = 0;
            quizSheetCtr = 0;
            numQuizItems = myQuiz.Length;

            LblScore.Text = $"Score: {score}";

            QuestionLists();
            LoadQuestion();
            bgMusic.controls.play();

            PnlQuizResult.Visible = false;
            PnlQuiz.Visible = true;
        }

        private void LblExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuestionLists()
        {
            myQuiz[0] = new Quiz("What is the chemical symbol for water?", "H", "O", "H2O", "HO2", "H2O");
            myQuiz[1] = new Quiz("Which planet is known as the Red Planet?", "Venus", "Mars", "Jupiter", "Saturn", "Mars");
            myQuiz[2] = new Quiz("What is the process by which plants make their food?", "Respiration", "Photosynthesis", "Fermentation", "Digestion", "Photosynthesis");
            myQuiz[3] = new Quiz("What is the powerhouse of the cell?", "Nucleus", "Ribosome", "Mitochondria", "Chloroplast", "Mitochondria");
            myQuiz[4] = new Quiz("Which gas is most abundant in the Earth's atmosphere?", "Oxygen", "Carbon Dioxide", "Nitrogen", "Hydrogen", "Nitrogen");
        }

        private static void ChangeStyle(Control ctrlPanel, Control ctrlLetter, Control ctrlText)
        {
            ctrlPanel.BackColor = Color.FromArgb(90, 191, 173);
            ctrlLetter.ForeColor = Color.FromArgb(1, 3, 38);
            ctrlText.ForeColor = Color.FromArgb(1, 3, 38);
        }

        private void DefaultStyle()
        {
            PnlOptionA.BackColor = Color.FromArgb(25, 41, 89);
            PnlOptionB.BackColor = Color.FromArgb(25, 41, 89);
            PnlOptionC.BackColor = Color.FromArgb(25, 41, 89);
            PnlOptionD.BackColor = Color.FromArgb(25, 41, 89);

            LblOptionA.ForeColor = Color.White;
            LblOptionB.ForeColor = Color.White;
            LblOptionC.ForeColor = Color.White;
            LblOptionD.ForeColor = Color.White;

            LblAnswerA.ForeColor = Color.White;
            LblAnswerB.ForeColor = Color.White;
            LblAnswerC.ForeColor = Color.White;
            LblAnswerD.ForeColor = Color.White;
        }

        private void LblStartQuiz_MouseHover(object sender, EventArgs e)
        {
            LblStartQuiz.ForeColor = Color.FromArgb(90, 191, 173);
        }

        private void LblStartQuiz_MouseLeave(object sender, EventArgs e)
        {
            LblStartQuiz.ForeColor = Color.FromArgb(60, 116, 166);
        }

        private void LblExit_MouseHover(object sender, EventArgs e)
        {
            LblExit.ForeColor = Color.FromArgb(90, 191, 173);
        }

        private void LblExit_MouseLeave(object sender, EventArgs e)
        {
            LblExit.ForeColor = Color.FromArgb(60, 116, 166);
        }

        private void LblViewQuizSheet_MouseHover(object sender, EventArgs e)
        {
            LblViewQuizSheet.ForeColor = Color.FromArgb(90, 191, 173);
        }

        private void LblViewQuizSheet_MouseLeave(object sender, EventArgs e)
        {
            LblViewQuizSheet.ForeColor = Color.FromArgb(60, 116, 166);
        }

        private void LblRetakeQuiz_MouseHover(object sender, EventArgs e)
        {
            LblRetakeQuiz.ForeColor = Color.FromArgb(90, 191, 173);
        }

        private void LblRetakeQuiz_MouseLeave(object sender, EventArgs e)
        {
            LblRetakeQuiz.ForeColor = Color.FromArgb(60, 116, 166);
        }

        private void LblExit2_MouseHover(object sender, EventArgs e)
        {
            LblExit2.ForeColor = Color.FromArgb(90, 191, 173);
        }

        private void LblExit2_MouseLeave(object sender, EventArgs e)
        {
            LblExit2.ForeColor = Color.FromArgb(60, 116, 166);
        }

        private void LblOptionA_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerA.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionA, LblOptionA, LblAnswerA);
        }

        private void LblOptionB_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerB.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionB, LblOptionB, LblAnswerB);
        }

        private void LblOptionC_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerC.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionC, LblOptionC, LblAnswerC);
        }

        private void LblOptionD_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerD.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionD, LblOptionD, LblAnswerD);
        }

        private void LblAnswerA_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerA.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionA, LblOptionA, LblAnswerA);
        }

        private void LblAnswerB_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerB.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionB, LblOptionB, LblAnswerB);
        }

        private void LblAnswerC_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerC.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionC, LblOptionC, LblAnswerC);
        }

        private void LblAnswerD_Click(object sender, EventArgs e)
        {
            selectedAnswer = LblAnswerD.Text;
            DefaultStyle();
            ChangeStyle(PnlOptionD, LblOptionD, LblAnswerD);
        }

        private void CustomStyles()
        {
            MyModule.SetRoundedCorners(this, 10, 10, 10, 10);
            MyModule.SetRoundedCorners(PnlStartPage, 0, 0, 10, 10);
            MyModule.SetRoundedCorners(PnlQuiz, 0, 0, 10, 10);
            MyModule.SetRoundedCorners(PnlQuizResult, 0, 0, 10, 10);
            MyModule.SetRoundedCorners(PnlQuizSheet, 0, 0, 10, 10);
            MyModule.SetRoundedCorners(PnlOptionA, 10, 10, 10, 10);
            MyModule.SetRoundedCorners(PnlOptionB, 10, 10, 10, 10);
            MyModule.SetRoundedCorners(PnlOptionC, 10, 10, 10, 10);
            MyModule.SetRoundedCorners(PnlOptionD, 10, 10, 10, 10);
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblClose_MouseHover(object sender, EventArgs e)
        {
            LblClose.BackColor = Color.Red;
            LblClose.ForeColor = Color.Gainsboro;
        }

        private void LblClose_MouseLeave(object sender, EventArgs e)
        {
            LblClose.BackColor = Color.Gainsboro;
            LblClose.ForeColor = Color.Black;
        }

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Start dragging
                dragHeader = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void PnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            // Move the form
            if (dragHeader)
            {
                // Calculate the new position of the form
                int newLeft = this.Left + e.X - startPoint.X;
                int newTop = this.Top + e.Y - startPoint.Y;

                // Apply constraint to prevent the form from moving above the top edge
                this.Left = newLeft;  // No constraints on left
                this.Top = Math.Max(0, newTop);  // Constraint on top (can't move above the screen)

                // UNCOMMENT THE CODE BELOW TO ALLOW CONSTRAINTS IN EVERY EDGE OF THE SCREEN

                // Ensure the form stays within screen bounds
                // Rectangle screenBounds = Screen.FromControl(this).Bounds;
                //int maxX = screenBounds.Right - this.Width;
                //int maxY = screenBounds.Bottom - this.Height;

                //this.Left = Math.Max(screenBounds.Left, Math.Min(newLeft, maxX));
                //this.Top = Math.Max(screenBounds.Top, Math.Min(newTop, maxY));

                //int maxLeft = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                //int maxTop = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            }
        }

        private void PnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging
            dragHeader = false;
        }
    }
}
