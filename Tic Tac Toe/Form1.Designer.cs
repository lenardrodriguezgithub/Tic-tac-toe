namespace Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PlayPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showturn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.oscore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xscore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.PlayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.textBox1);
            this.MenuPanel.Controls.Add(this.ExitButton);
            this.MenuPanel.Controls.Add(this.PlayButton);
            this.MenuPanel.Location = new System.Drawing.Point(40, 20);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(620, 620);
            this.MenuPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(100, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 90);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Tic-tac-toe";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(240, 430);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 34);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.Location = new System.Drawing.Point(240, 390);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(112, 34);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PlayPanel
            // 
            this.PlayPanel.BackColor = System.Drawing.Color.Transparent;
            this.PlayPanel.Controls.Add(this.textBox2);
            this.PlayPanel.Controls.Add(this.BackButton);
            this.PlayPanel.Controls.Add(this.ResetButton);
            this.PlayPanel.Controls.Add(this.button9);
            this.PlayPanel.Controls.Add(this.button8);
            this.PlayPanel.Controls.Add(this.button7);
            this.PlayPanel.Controls.Add(this.button6);
            this.PlayPanel.Controls.Add(this.button5);
            this.PlayPanel.Controls.Add(this.button4);
            this.PlayPanel.Controls.Add(this.button3);
            this.PlayPanel.Controls.Add(this.button2);
            this.PlayPanel.Controls.Add(this.button1);
            this.PlayPanel.Controls.Add(this.showturn);
            this.PlayPanel.Controls.Add(this.label5);
            this.PlayPanel.Controls.Add(this.oscore);
            this.PlayPanel.Controls.Add(this.label4);
            this.PlayPanel.Controls.Add(this.xscore);
            this.PlayPanel.Controls.Add(this.label3);
            this.PlayPanel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayPanel.Location = new System.Drawing.Point(40, 20);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(620, 620);
            this.PlayPanel.TabIndex = 1;
            this.PlayPanel.Visible = false;
            this.PlayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(10, 10);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 50);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Tic-tac-toe";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.Location = new System.Drawing.Point(150, 530);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(112, 34);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetButton.Location = new System.Drawing.Point(370, 530);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(112, 34);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(370, 400);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 110);
            this.button9.TabIndex = 15;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(260, 400);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 110);
            this.button8.TabIndex = 14;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(150, 400);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 110);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(370, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 110);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(260, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 110);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(150, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 110);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(370, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 110);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(260, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 110);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(150, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 110);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showturn
            // 
            this.showturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showturn.Location = new System.Drawing.Point(270, 140);
            this.showturn.Name = "showturn";
            this.showturn.Size = new System.Drawing.Size(50, 24);
            this.showturn.TabIndex = 6;
            this.showturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(320, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Turn";
            // 
            // oscore
            // 
            this.oscore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oscore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oscore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oscore.Location = new System.Drawing.Point(410, 100);
            this.oscore.Name = "oscore";
            this.oscore.Size = new System.Drawing.Size(60, 24);
            this.oscore.TabIndex = 4;
            this.oscore.Text = "0";
            this.oscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(370, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "o";
            // 
            // xscore
            // 
            this.xscore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xscore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xscore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xscore.Location = new System.Drawing.Point(190, 100);
            this.xscore.Name = "xscore";
            this.xscore.Size = new System.Drawing.Size(60, 24);
            this.xscore.TabIndex = 2;
            this.xscore.Text = "0";
            this.xscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xscore.TextChanged += new System.EventHandler(this.xscore_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(150, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.PlayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(698, 664);
            this.Controls.Add(this.PlayPanel);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TTT";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.PlayPanel.ResumeLayout(false);
            this.PlayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Button ExitButton;
        private Button PlayButton;
        private Label label3;
        private TextBox xscore;
        private Label label4;
        private TextBox oscore;
        private Label label5;
        private TextBox showturn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button ResetButton;
        private Button BackButton;
        private Panel PlayPanel;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}