using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Lab01
{
    public partial class Form_MainMenu : Form
    {
        List<string> paths = new List<string>();
        int score;
        string name;
        DateTime dateTime = new DateTime();
        DataTable dt = new DataTable();
        int times = 0;

        public Form_MainMenu()
        {
            InitializeComponent();

            DataColumn stt = new DataColumn();
            stt.ColumnName = "Stt";
            stt.DataType = typeof(int);
            stt.AutoIncrement = true;
            stt.AutoIncrementSeed = 1;
            stt.AutoIncrementStep = 1;

            dt.Columns.Add(stt);
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Score", typeof(int));
            dt.Columns.Add("Time", typeof(DateTime));

            DataColumn[] primaryKeyColumns = new DataColumn[1];
            primaryKeyColumns[0] = dt.Columns["STT"];
            dt.PrimaryKey = primaryKeyColumns;

            dt.Columns["STT"].AutoIncrement = true;
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            this.pnl_MainMenu.Visible = false;
            this.pnl_Topics.Visible = true;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.pnl_MainMenu.Visible = true;
            this.pnl_Topics.Visible = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to exit?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void AddPath(string dir)
        {
            paths.Clear();
            foreach (string path in Directory.GetFiles(dir))
            {
                paths.Add(path);
            }
        }

        private void btn_Topic_Click(object sender, EventArgs e)
        {
            BunifuImageButton b = (BunifuImageButton)sender;
            pnl_Topics.Visible = false;
            pnl_PlayScreen.Visible = true;

            string topicDir = "Images\\Topics\\";
            string[] columns = b.Name.Split('_');
            string imgDir = topicDir + columns[1];

            AddPath(imgDir);

            Random random = new Random();
            pic_PlayScreen.ImageLocation = paths[random.Next(0, paths.Count)];
            times++;
        }

        private void btn_BackToTopic_Click(object sender, EventArgs e)
        {
            pnl_PlayScreen.Visible = false;
            pnl_Topics.Visible = true;

            times = 0;
            score = 0;

            txt_Input.Clear();
            lbl_Score.Text = score.ToString();
        }

        private async void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string imgPath = System.IO.Path.GetFileName(pic_PlayScreen.ImageLocation);
                string[] result = imgPath.Split('.', '-', ' ');
                if (txt_Input.Text.ToLower() == result[0])
                {
                    txt_Input.Clear();

                    score += 2;
                    lbl_Score.Text = score.ToString();
                    pic_CorrectAnswer.Visible = true;

                    await Task.Delay(1000);

                    pic_CorrectAnswer.Visible = false;
                    pic_NextPic_Click(sender, e);
                }
                else
                {
                    txt_Input.Clear();

                    pic_WrongAnswer.Visible = true;

                    await Task.Delay(1000);

                    pic_WrongAnswer.Visible = false;
                    pic_NextPic_Click(sender, e);
                }
            }
        }

        private void pic_NextPic_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            paths.Remove(pic_PlayScreen.ImageLocation);
            if (times < 5)
            {
                times++;
                pic_PlayScreen.ImageLocation = paths[random.Next(0, paths.Count)];
            }
            else
            {
                times = 0;
                txt_Input.Clear();

                string message = "Your score: " + score.ToString();
                string title = "Result";

                DialogResult dr = MessageBox.Show(message, title);

                if (dr == DialogResult.OK)
                {
                    pnl_EnterName.Visible = true;
                    pnl_PlayScreen.Visible = false;
                }
            }
        }

        private void btn_HighScore_Click(object sender, EventArgs e)
        {
            pnl_MainMenu.Visible = false;
            pnl_HighScore.Visible = true;
            PrintScore();
        }

        private void btn_ScoresBack_Click(object sender, EventArgs e)
        {
            pnl_MainMenu.Visible = true;
            pnl_HighScore.Visible = false;
            ClearScore();
        }

        private void txt_EnterName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name = txt_EnterName.Text;
                dateTime = DateTime.Now;
                txt_EnterName.Clear();

                pnl_HighScore.Visible = true;
                pnl_EnterName.Visible = false;

                AddData(name, score, dateTime);
                PrintScore();

                score = 0;
                lbl_Score.Text = score.ToString();
            }
        }

        private void AddData(string name, int score, DateTime dateTime)
        {
            dt.Rows.Add(null, name, score, dateTime);
            SortScoreDesc();
        }

        private void PrintScore()
        {
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                i++;
                string name = dr["Name"].ToString();
                string score = dr["Score"].ToString();
                string dateTime = dr["Time"].ToString();

                rtb_SttCol.Text += i.ToString() + "\n\n";
                rtb_NameCol.Text += name + "\n\n";
                rtb_ScoreCol.Text += score + "\n\n";
                rtb_TimeCol.Text += dateTime + "\n\n";
                if (i == 5)
                {
                    break;
                }
            }
        }

        private void ClearScore()
        {
            rtb_SttCol.Clear();
            rtb_NameCol.Clear();
            rtb_ScoreCol.Clear();
            rtb_TimeCol.Clear();
        }

        private void SortScoreDesc()
        {
            dt.DefaultView.Sort = "Score DESC";
            dt = dt.DefaultView.ToTable();
        }

        private void Form_MainMenu_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            wmp_Player.URL = "Sounds\\background.mp3";

            pnl_Buttons.Location = new Point((this.Size.Width - pnl_Buttons.Size.Width) / 2, (this.Size.Height - pnl_Buttons.Size.Height) * 3 / 4);
            pnl_WrappedTopic.Location = new Point((this.Size.Width - pnl_WrappedTopic.Size.Width) / 2, (this.Size.Height - pnl_WrappedTopic.Size.Height) / 2);
            pnl_WrappedPlayScreen.Location = new Point((this.Size.Width - pnl_WrappedPlayScreen.Size.Width) / 2, (this.Size.Height - pnl_WrappedPlayScreen.Size.Height) / 2);
            pnl_WrappedScore.Location = new Point((this.Size.Width - pnl_WrappedScore.Size.Width) / 2, (this.Size.Height - pnl_WrappedScore.Size.Height) / 2);
            pnl_WrappedEnterName.Location = new Point((this.Size.Width - pnl_WrappedEnterName.Size.Width) / 2, (this.Size.Height - pnl_WrappedEnterName.Size.Height) / 2);
            pnl_WrappedDictionary.Location = new Point((this.Size.Width - pnl_WrappedDictionary.Size.Width) / 2, (this.Size.Height - pnl_WrappedDictionary.Size.Height) / 2);
        }

        private void btn_Mute_Click(object sender, EventArgs e)
        {
            btn_Mute.Visible = false;
            btn_Unmute.Visible = true;
            wmp_Player.settings.mute = true;
        }

        private void btn_Unmute_Click(object sender, EventArgs e)
        {
            btn_Mute.Visible = true;
            btn_Unmute.Visible = false;
            wmp_Player.settings.mute = false;
        }

        private void pic_Dictionary_Click(object sender, EventArgs e)
        {
            pnl_MainMenu.Visible = false;
            pnl_Dictionary.Visible = true;
        }

        private void btn_DictionaryBack_Click(object sender, EventArgs e)
        {
            pnl_MainMenu.Visible = true;
            pnl_Dictionary.Visible = false;
        }

        private void cbb_Dictionary_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rtb_Vie.Clear();
            rtb_Eng.Clear();

            string topicDir = "Images\\Topics\\";
            string imageDir = topicDir + cbb_Dictionary.GetItemText(cbb_Dictionary.SelectedItem);
            string[] files = Directory.GetFiles(imageDir);

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string[] token = fileName.Split('-', '.');
                string eng = token[0].Trim();
                string vie = token[1];
                rtb_Eng.Text += eng + "\n";
                rtb_Vie.Text += vie + "\n";
            }
        }
    }
}
