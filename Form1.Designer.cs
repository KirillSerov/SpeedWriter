namespace SpeedWriter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OldText = new System.Windows.Forms.Label();
            this.NewText = new System.Windows.Forms.Label();
            this.WordsCount = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelResult = new System.Windows.Forms.Panel();
            this.NewRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.Button();
            this.PanelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Name = "label2";
            // 
            // OldText
            // 
            this.OldText.BackColor = System.Drawing.Color.White;
            this.OldText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OldText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.OldText, "OldText");
            this.OldText.Name = "OldText";
            // 
            // NewText
            // 
            this.NewText.BackColor = System.Drawing.Color.White;
            this.NewText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.NewText, "NewText");
            this.NewText.Name = "NewText";
            // 
            // WordsCount
            // 
            this.WordsCount.BackColor = System.Drawing.Color.White;
            this.WordsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WordsCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.WordsCount, "WordsCount");
            this.WordsCount.Name = "WordsCount";
            // 
            // Seconds
            // 
            this.Seconds.BackColor = System.Drawing.Color.White;
            this.Seconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Seconds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.Seconds, "Seconds");
            this.Seconds.Name = "Seconds";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // PanelResult
            // 
            this.PanelResult.BackColor = System.Drawing.Color.DarkGray;
            this.PanelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelResult.Controls.Add(this.NewRecord);
            this.PanelResult.Controls.Add(this.label3);
            resources.ApplyResources(this.PanelResult, "PanelResult");
            this.PanelResult.Name = "PanelResult";
            // 
            // NewRecord
            // 
            resources.ApplyResources(this.NewRecord, "NewRecord");
            this.NewRecord.ForeColor = System.Drawing.Color.Gold;
            this.NewRecord.Name = "NewRecord";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Close
            // 
            resources.ApplyResources(this.Close, "Close");
            this.Close.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Close.Name = "Close";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Reset
            // 
            resources.ApplyResources(this.Reset, "Reset");
            this.Reset.Name = "Reset";
            this.Reset.TabStop = false;
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.PanelResult);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.WordsCount);
            this.Controls.Add(this.NewText);
            this.Controls.Add(this.OldText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.PanelResult.ResumeLayout(false);
            this.PanelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OldText;
        private System.Windows.Forms.Label NewText;
        private System.Windows.Forms.Label WordsCount;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PanelResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NewRecord;
        private System.Windows.Forms.Button Reset;
    }
}
