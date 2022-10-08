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

namespace Lab01
{
    public partial class Form_MainMenu : Form
    {
        List<string> paths = new List<string>();
        int score;
        string name;
        DateTime dateTime = new DateTime();
        DataTable dt = new DataTable();
        int indx = 0;

        public Form_MainMenu()
        {
            InitializeComponent();
            dt.Columns.Add("STT", typeof(int));
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
            foreach (string path in Directory.GetFiles(dir))
            {
                paths.Add(path);
            }
        }

        private void btn_Topic_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            pnl_Topics.Visible = false;
            pnl_PlayScreen.Visible = true;

            string topicDir = "d:\\a jerry\\aa c#\\lab01\\images\\topics\\";
            string[] columns = b.Name.Split('_');
            string imgDir = topicDir + columns[1];

            AddPath(imgDir);
            Random random = new Random();
            pic_PlayScreen.ImageLocation = paths[random.Next(0, paths.Count)];
            paths.Remove(pic_PlayScreen.ImageLocation);
        }

        private void btn_BackToTopic_Click(object sender, EventArgs e)
        {
            pnl_PlayScreen.Visible = false;
            pnl_Topics.Visible = true;
            score = 0;
            lbl_Score.Text = score.ToString();
        }

        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string imgPath = System.IO.Path.GetFileName(pic_PlayScreen.ImageLocation);
                string[] result = imgPath.Split('.');
                if (paths.Count > 0)
                {
                    
                    if (txt_Input.Text.ToLower() == result[0])
                    {
                        txt_Input.Clear();
                        score++;
                        lbl_Score.Text = score.ToString();
                        pic_NextPic_Click(sender, e);
                    }
                    else
                    {
                        txt_Input.Clear();
                        pic_NextPic_Click(sender, e);
                    }
                    
                }
                else
                {
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
        }

        private void pic_NextPic_Click(object sender, EventArgs e)
        {
            if (paths.Count > 0)
            {
                Random random = new Random();
                pic_PlayScreen.ImageLocation = paths[random.Next(0, paths.Count)];
                paths.Remove(pic_PlayScreen.ImageLocation);
            }
            else
            {
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
        }

        private void btn_ScoresBack_Click(object sender, EventArgs e)
        {
            pnl_MainMenu.Visible = true;
            pnl_HighScore.Visible = false;
        }

        private void txt_EnterName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                name = txt_EnterName.Text;
                dateTime = DateTime.Now;
                txt_EnterName.Clear();
                pnl_HighScore.Visible = true;
                pnl_EnterName.Visible = false;
                AddData(indx, name, score, dateTime);
                MessageBox.Show(dt.ToString());
            }
        }

        private void AddData(int indx, string name, int score, DateTime dateTime)
        {
            dt.Rows.Add(indx, name, score, dateTime);
        }
    }
}
