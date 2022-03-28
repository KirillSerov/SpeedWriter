using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpeedWriter
{
    public partial class Finish : Form
    {
        public string playerName;
        public Finish()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PlayerName.Text))
                return;
            playerName = PlayerName.Text.Trim();
            this.Close();
        }
    }
}
