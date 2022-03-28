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

namespace SpeedWriter
{
    public partial class Form1 : Form
    {
        private const int MAX_TIME = 60;
        private int wordsCount;
        private int seconds;
        private bool isRun;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            wordsCount = 0;
            seconds = MAX_TIME;
            Seconds.Text = seconds.ToString();
            timer1.Tick += Timer1_Tick;
            isRun = false;
            PanelResult.Visible = false;
            NewText.Text = SelectText();
            Reset.Enabled = false;
        }



        private string SelectText()
        {
            int index = new Random().Next(1, 4);
            string filename = "TextFile" + index;
            return (string)Resource1.ResourceManager.GetObject(filename);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == NewText.Text[0])
            {
                if (!isRun)
                {
                    isRun = true;
                    PanelResult.Visible = false;
                    timer1.Start();
                    Reset.Enabled = false;
                    this.Focus();
                }
                if (isRun)
                {
                    
                    wordsCount++;
                    WordsCount.Text = wordsCount.ToString();

                    if (OldText.Text.Length < 26)
                        OldText.Text += NewText.Text[0].ToString();
                    else
                        OldText.Text = OldText.Text.Substring(1) + NewText.Text[0].ToString();
                    NewText.Text = NewText.Text.Substring(1);
                }
            }
        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            if (seconds == 0)
            {
                timer1.Stop();
                Finish();
                return;
            }
            seconds--;
            Seconds.Text = seconds.ToString();
        }

        private void Finish()
        {
            Finish newForm = new Finish();
            newForm.ShowDialog();
            Reset.Enabled = true;
            string playerName = newForm.playerName;
            PanelResult.Visible = true;

            if (WorkWithResult.isNewRecord(wordsCount))
                NewRecord.Visible = true;
            label3.Text = $"{playerName}, ваш результат: {wordsCount} символов в минуту";
            WorkWithResult.Save(playerName, wordsCount);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Закрытие окна

        Font f;
        private void Close_MouseEnter(object sender, EventArgs e)
        {
            f = Close.Font;
            Close.Font = new Font(f, FontStyle.Bold);
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.Font = f;
        }
        #endregion

        #region Перемещение формы
        private Point formPosition;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(this.Location.X + e.X - formPosition.X, this.Location.Y + e.Y - formPosition.Y);
        }
        #endregion

        private void Reset_Click(object sender, EventArgs e)
        {
            wordsCount = 0;
            seconds = MAX_TIME;
            Seconds.Text = seconds.ToString();           
            isRun = false;
            NewText.Text = SelectText();
            OldText.Text = "";
        }
    }
}

