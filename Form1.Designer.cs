namespace Lab01
{
    partial class Form_MainMenu
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
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_MainMenu = new System.Windows.Forms.Panel();
            this.btn_HighScore = new System.Windows.Forms.Button();
            this.pnl_Topics = new System.Windows.Forms.Panel();
            this.pnl_Animal = new System.Windows.Forms.Panel();
            this.btn_Animal = new System.Windows.Forms.Button();
            this.lbl_Animal = new System.Windows.Forms.Label();
            this.pnl_Fruit = new System.Windows.Forms.Panel();
            this.btn_Fruit = new System.Windows.Forms.Button();
            this.lbl_Fruit = new System.Windows.Forms.Label();
            this.lbl_ChooseTopic = new System.Windows.Forms.Label();
            this.btn_BackToMenu = new System.Windows.Forms.Button();
            this.pnl_PlayScreen = new System.Windows.Forms.Panel();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_ScoreLbl = new System.Windows.Forms.Label();
            this.pic_NextPic = new System.Windows.Forms.PictureBox();
            this.pic_PrevPic = new System.Windows.Forms.PictureBox();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.pic_PlayScreen = new System.Windows.Forms.PictureBox();
            this.btn_BackToTopic = new System.Windows.Forms.Button();
            this.pnl_HighScore = new System.Windows.Forms.Panel();
            this.rtb_Scores = new System.Windows.Forms.RichTextBox();
            this.btn_ScoresBack = new System.Windows.Forms.Button();
            this.lbl_Scores = new System.Windows.Forms.Label();
            this.pnl_EnterName = new System.Windows.Forms.Panel();
            this.lbl_EnterName = new System.Windows.Forms.Label();
            this.txt_EnterName = new System.Windows.Forms.TextBox();
            this.pnl_MainMenu.SuspendLayout();
            this.pnl_Topics.SuspendLayout();
            this.pnl_Animal.SuspendLayout();
            this.pnl_Fruit.SuspendLayout();
            this.pnl_PlayScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NextPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PrevPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PlayScreen)).BeginInit();
            this.pnl_HighScore.SuspendLayout();
            this.pnl_EnterName.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.AutoSize = true;
            this.btn_StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StartGame.Location = new System.Drawing.Point(296, 254);
            this.btn_StartGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(102, 31);
            this.btn_StartGame.TabIndex = 0;
            this.btn_StartGame.Text = "Start game";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Location = new System.Drawing.Point(296, 335);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(102, 31);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pnl_MainMenu
            // 
            this.pnl_MainMenu.Controls.Add(this.btn_HighScore);
            this.pnl_MainMenu.Controls.Add(this.btn_Exit);
            this.pnl_MainMenu.Controls.Add(this.btn_StartGame);
            this.pnl_MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_MainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_MainMenu.Name = "pnl_MainMenu";
            this.pnl_MainMenu.Size = new System.Drawing.Size(738, 794);
            this.pnl_MainMenu.TabIndex = 2;
            // 
            // btn_HighScore
            // 
            this.btn_HighScore.AutoSize = true;
            this.btn_HighScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HighScore.Location = new System.Drawing.Point(296, 294);
            this.btn_HighScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_HighScore.Name = "btn_HighScore";
            this.btn_HighScore.Size = new System.Drawing.Size(102, 31);
            this.btn_HighScore.TabIndex = 2;
            this.btn_HighScore.Text = "High score";
            this.btn_HighScore.UseVisualStyleBackColor = true;
            this.btn_HighScore.Click += new System.EventHandler(this.btn_HighScore_Click);
            // 
            // pnl_Topics
            // 
            this.pnl_Topics.Controls.Add(this.pnl_Animal);
            this.pnl_Topics.Controls.Add(this.pnl_Fruit);
            this.pnl_Topics.Controls.Add(this.lbl_ChooseTopic);
            this.pnl_Topics.Controls.Add(this.btn_BackToMenu);
            this.pnl_Topics.Location = new System.Drawing.Point(386, 10);
            this.pnl_Topics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Topics.Name = "pnl_Topics";
            this.pnl_Topics.Size = new System.Drawing.Size(325, 220);
            this.pnl_Topics.TabIndex = 3;
            this.pnl_Topics.Visible = false;
            // 
            // pnl_Animal
            // 
            this.pnl_Animal.Controls.Add(this.btn_Animal);
            this.pnl_Animal.Controls.Add(this.lbl_Animal);
            this.pnl_Animal.Location = new System.Drawing.Point(182, 69);
            this.pnl_Animal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Animal.Name = "pnl_Animal";
            this.pnl_Animal.Size = new System.Drawing.Size(122, 129);
            this.pnl_Animal.TabIndex = 6;
            // 
            // btn_Animal
            // 
            this.btn_Animal.BackgroundImage = global::Lab01.Properties.Resources.animalTopic;
            this.btn_Animal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Animal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Animal.Location = new System.Drawing.Point(0, 0);
            this.btn_Animal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Animal.Name = "btn_Animal";
            this.btn_Animal.Size = new System.Drawing.Size(122, 111);
            this.btn_Animal.TabIndex = 6;
            this.btn_Animal.UseVisualStyleBackColor = true;
            this.btn_Animal.Click += new System.EventHandler(this.btn_Topic_Click);
            // 
            // lbl_Animal
            // 
            this.lbl_Animal.AutoSize = true;
            this.lbl_Animal.Location = new System.Drawing.Point(46, 114);
            this.lbl_Animal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Animal.Name = "lbl_Animal";
            this.lbl_Animal.Size = new System.Drawing.Size(38, 13);
            this.lbl_Animal.TabIndex = 4;
            this.lbl_Animal.Text = "Animal";
            // 
            // pnl_Fruit
            // 
            this.pnl_Fruit.Controls.Add(this.btn_Fruit);
            this.pnl_Fruit.Controls.Add(this.lbl_Fruit);
            this.pnl_Fruit.Location = new System.Drawing.Point(22, 69);
            this.pnl_Fruit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Fruit.Name = "pnl_Fruit";
            this.pnl_Fruit.Size = new System.Drawing.Size(122, 129);
            this.pnl_Fruit.TabIndex = 5;
            // 
            // btn_Fruit
            // 
            this.btn_Fruit.BackgroundImage = global::Lab01.Properties.Resources.fruitTopic;
            this.btn_Fruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Fruit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Fruit.Location = new System.Drawing.Point(0, 0);
            this.btn_Fruit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Fruit.Name = "btn_Fruit";
            this.btn_Fruit.Size = new System.Drawing.Size(122, 111);
            this.btn_Fruit.TabIndex = 5;
            this.btn_Fruit.UseVisualStyleBackColor = true;
            this.btn_Fruit.Click += new System.EventHandler(this.btn_Topic_Click);
            // 
            // lbl_Fruit
            // 
            this.lbl_Fruit.AutoSize = true;
            this.lbl_Fruit.Location = new System.Drawing.Point(46, 114);
            this.lbl_Fruit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fruit.Name = "lbl_Fruit";
            this.lbl_Fruit.Size = new System.Drawing.Size(27, 13);
            this.lbl_Fruit.TabIndex = 4;
            this.lbl_Fruit.Text = "Fruit";
            // 
            // lbl_ChooseTopic
            // 
            this.lbl_ChooseTopic.AutoSize = true;
            this.lbl_ChooseTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChooseTopic.Location = new System.Drawing.Point(118, 36);
            this.lbl_ChooseTopic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ChooseTopic.Name = "lbl_ChooseTopic";
            this.lbl_ChooseTopic.Size = new System.Drawing.Size(115, 20);
            this.lbl_ChooseTopic.TabIndex = 2;
            this.lbl_ChooseTopic.Text = "Choose a topic";
            // 
            // btn_BackToMenu
            // 
            this.btn_BackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BackToMenu.Location = new System.Drawing.Point(2, 2);
            this.btn_BackToMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_BackToMenu.Name = "btn_BackToMenu";
            this.btn_BackToMenu.Size = new System.Drawing.Size(74, 31);
            this.btn_BackToMenu.TabIndex = 1;
            this.btn_BackToMenu.Text = "Back";
            this.btn_BackToMenu.UseVisualStyleBackColor = true;
            this.btn_BackToMenu.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_PlayScreen
            // 
            this.pnl_PlayScreen.Controls.Add(this.lbl_Score);
            this.pnl_PlayScreen.Controls.Add(this.lbl_ScoreLbl);
            this.pnl_PlayScreen.Controls.Add(this.pic_NextPic);
            this.pnl_PlayScreen.Controls.Add(this.pic_PrevPic);
            this.pnl_PlayScreen.Controls.Add(this.txt_Input);
            this.pnl_PlayScreen.Controls.Add(this.pic_PlayScreen);
            this.pnl_PlayScreen.Controls.Add(this.btn_BackToTopic);
            this.pnl_PlayScreen.Location = new System.Drawing.Point(10, 243);
            this.pnl_PlayScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_PlayScreen.Name = "pnl_PlayScreen";
            this.pnl_PlayScreen.Size = new System.Drawing.Size(326, 246);
            this.pnl_PlayScreen.TabIndex = 4;
            this.pnl_PlayScreen.Visible = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Location = new System.Drawing.Point(284, 11);
            this.lbl_Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(13, 13);
            this.lbl_Score.TabIndex = 8;
            this.lbl_Score.Text = "0";
            // 
            // lbl_ScoreLbl
            // 
            this.lbl_ScoreLbl.AutoSize = true;
            this.lbl_ScoreLbl.Location = new System.Drawing.Point(248, 11);
            this.lbl_ScoreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ScoreLbl.Name = "lbl_ScoreLbl";
            this.lbl_ScoreLbl.Size = new System.Drawing.Size(38, 13);
            this.lbl_ScoreLbl.TabIndex = 7;
            this.lbl_ScoreLbl.Text = "Score:";
            // 
            // pic_NextPic
            // 
            this.pic_NextPic.Image = global::Lab01.Properties.Resources.nextArrow;
            this.pic_NextPic.Location = new System.Drawing.Point(286, 106);
            this.pic_NextPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_NextPic.Name = "pic_NextPic";
            this.pic_NextPic.Size = new System.Drawing.Size(38, 41);
            this.pic_NextPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_NextPic.TabIndex = 6;
            this.pic_NextPic.TabStop = false;
            this.pic_NextPic.Click += new System.EventHandler(this.pic_NextPic_Click);
            // 
            // pic_PrevPic
            // 
            this.pic_PrevPic.Image = global::Lab01.Properties.Resources.prevArrow;
            this.pic_PrevPic.Location = new System.Drawing.Point(2, 106);
            this.pic_PrevPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_PrevPic.Name = "pic_PrevPic";
            this.pic_PrevPic.Size = new System.Drawing.Size(38, 41);
            this.pic_PrevPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_PrevPic.TabIndex = 5;
            this.pic_PrevPic.TabStop = false;
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(109, 176);
            this.txt_Input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(103, 20);
            this.txt_Input.TabIndex = 4;
            this.txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Input_KeyDown);
            // 
            // pic_PlayScreen
            // 
            this.pic_PlayScreen.Location = new System.Drawing.Point(109, 62);
            this.pic_PlayScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_PlayScreen.Name = "pic_PlayScreen";
            this.pic_PlayScreen.Size = new System.Drawing.Size(102, 110);
            this.pic_PlayScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_PlayScreen.TabIndex = 3;
            this.pic_PlayScreen.TabStop = false;
            // 
            // btn_BackToTopic
            // 
            this.btn_BackToTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BackToTopic.Location = new System.Drawing.Point(2, 2);
            this.btn_BackToTopic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_BackToTopic.Name = "btn_BackToTopic";
            this.btn_BackToTopic.Size = new System.Drawing.Size(74, 31);
            this.btn_BackToTopic.TabIndex = 2;
            this.btn_BackToTopic.Text = "Back";
            this.btn_BackToTopic.UseVisualStyleBackColor = true;
            this.btn_BackToTopic.Click += new System.EventHandler(this.btn_BackToTopic_Click);
            // 
            // pnl_HighScore
            // 
            this.pnl_HighScore.Controls.Add(this.rtb_Scores);
            this.pnl_HighScore.Controls.Add(this.btn_ScoresBack);
            this.pnl_HighScore.Controls.Add(this.lbl_Scores);
            this.pnl_HighScore.Location = new System.Drawing.Point(386, 243);
            this.pnl_HighScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_HighScore.Name = "pnl_HighScore";
            this.pnl_HighScore.Size = new System.Drawing.Size(326, 246);
            this.pnl_HighScore.TabIndex = 5;
            this.pnl_HighScore.Visible = false;
            // 
            // rtb_Scores
            // 
            this.rtb_Scores.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_Scores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Scores.Location = new System.Drawing.Point(22, 40);
            this.rtb_Scores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtb_Scores.Name = "rtb_Scores";
            this.rtb_Scores.Size = new System.Drawing.Size(281, 204);
            this.rtb_Scores.TabIndex = 10;
            this.rtb_Scores.Text = "";
            // 
            // btn_ScoresBack
            // 
            this.btn_ScoresBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ScoresBack.Location = new System.Drawing.Point(2, 2);
            this.btn_ScoresBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ScoresBack.Name = "btn_ScoresBack";
            this.btn_ScoresBack.Size = new System.Drawing.Size(74, 31);
            this.btn_ScoresBack.TabIndex = 9;
            this.btn_ScoresBack.Text = "Back";
            this.btn_ScoresBack.UseVisualStyleBackColor = true;
            this.btn_ScoresBack.Click += new System.EventHandler(this.btn_ScoresBack_Click);
            // 
            // lbl_Scores
            // 
            this.lbl_Scores.AutoSize = true;
            this.lbl_Scores.Location = new System.Drawing.Point(131, 11);
            this.lbl_Scores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Scores.Name = "lbl_Scores";
            this.lbl_Scores.Size = new System.Drawing.Size(63, 13);
            this.lbl_Scores.TabIndex = 1;
            this.lbl_Scores.Text = "High scores";
            // 
            // pnl_EnterName
            // 
            this.pnl_EnterName.Controls.Add(this.lbl_EnterName);
            this.pnl_EnterName.Controls.Add(this.txt_EnterName);
            this.pnl_EnterName.Location = new System.Drawing.Point(9, 494);
            this.pnl_EnterName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_EnterName.Name = "pnl_EnterName";
            this.pnl_EnterName.Size = new System.Drawing.Size(326, 246);
            this.pnl_EnterName.TabIndex = 6;
            this.pnl_EnterName.Visible = false;
            // 
            // lbl_EnterName
            // 
            this.lbl_EnterName.AutoSize = true;
            this.lbl_EnterName.Location = new System.Drawing.Point(122, 117);
            this.lbl_EnterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EnterName.Name = "lbl_EnterName";
            this.lbl_EnterName.Size = new System.Drawing.Size(84, 13);
            this.lbl_EnterName.TabIndex = 6;
            this.lbl_EnterName.Text = "Enter your name";
            // 
            // txt_EnterName
            // 
            this.txt_EnterName.Location = new System.Drawing.Point(110, 132);
            this.txt_EnterName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_EnterName.Name = "txt_EnterName";
            this.txt_EnterName.Size = new System.Drawing.Size(103, 20);
            this.txt_EnterName.TabIndex = 5;
            this.txt_EnterName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EnterName_KeyDown);
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(738, 794);
            this.Controls.Add(this.pnl_MainMenu);
            this.Controls.Add(this.pnl_EnterName);
            this.Controls.Add(this.pnl_HighScore);
            this.Controls.Add(this.pnl_PlayScreen);
            this.Controls.Add(this.pnl_Topics);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_MainMenu_Load);
            this.pnl_MainMenu.ResumeLayout(false);
            this.pnl_MainMenu.PerformLayout();
            this.pnl_Topics.ResumeLayout(false);
            this.pnl_Topics.PerformLayout();
            this.pnl_Animal.ResumeLayout(false);
            this.pnl_Animal.PerformLayout();
            this.pnl_Fruit.ResumeLayout(false);
            this.pnl_Fruit.PerformLayout();
            this.pnl_PlayScreen.ResumeLayout(false);
            this.pnl_PlayScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NextPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PrevPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PlayScreen)).EndInit();
            this.pnl_HighScore.ResumeLayout(false);
            this.pnl_HighScore.PerformLayout();
            this.pnl_EnterName.ResumeLayout(false);
            this.pnl_EnterName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pnl_MainMenu;
        private System.Windows.Forms.Panel pnl_Topics;
        private System.Windows.Forms.Button btn_BackToMenu;
        private System.Windows.Forms.Label lbl_ChooseTopic;
        private System.Windows.Forms.Panel pnl_PlayScreen;
        private System.Windows.Forms.Panel pnl_Animal;
        private System.Windows.Forms.Label lbl_Animal;
        private System.Windows.Forms.Panel pnl_Fruit;
        private System.Windows.Forms.Label lbl_Fruit;
        private System.Windows.Forms.Button btn_Animal;
        private System.Windows.Forms.Button btn_Fruit;
        private System.Windows.Forms.Button btn_BackToTopic;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.PictureBox pic_PlayScreen;
        private System.Windows.Forms.PictureBox pic_NextPic;
        private System.Windows.Forms.PictureBox pic_PrevPic;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_ScoreLbl;
        private System.Windows.Forms.Button btn_HighScore;
        private System.Windows.Forms.Panel pnl_HighScore;
        private System.Windows.Forms.Label lbl_Scores;
        private System.Windows.Forms.Button btn_ScoresBack;
        private System.Windows.Forms.RichTextBox rtb_Scores;
        private System.Windows.Forms.Panel pnl_EnterName;
        private System.Windows.Forms.Label lbl_EnterName;
        private System.Windows.Forms.TextBox txt_EnterName;
    }
}

