namespace BackgammonProject2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSend = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.lblThrowDice = new System.Windows.Forms.Label();
            this.picThrowDice = new System.Windows.Forms.PictureBox();
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblServerInfo = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picThrowDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSend.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(151, 190);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(260, 30);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Location = new System.Drawing.Point(4, 28);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(134, 206);
            this.lblInfo.TabIndex = 5;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogIn.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(952, 19);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(93, 32);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(830, 19);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(93, 32);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(151, 140);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(144, 43);
            this.lstUsers.TabIndex = 8;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(214, 140);
            this.txtMess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(261, 30);
            this.txtMess.TabIndex = 9;
            // 
            // lblThrowDice
            // 
            this.lblThrowDice.BackColor = System.Drawing.Color.PaleGreen;
            this.lblThrowDice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThrowDice.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThrowDice.Location = new System.Drawing.Point(928, 119);
            this.lblThrowDice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThrowDice.Name = "lblThrowDice";
            this.lblThrowDice.Size = new System.Drawing.Size(140, 23);
            this.lblThrowDice.TabIndex = 10;
            this.lblThrowDice.Text = "Throw Dice";
            this.lblThrowDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThrowDice.Visible = false;
            this.lblThrowDice.Click += new System.EventHandler(this.lblThrowDice_Click);
            // 
            // picThrowDice
            // 
            this.picThrowDice.BackColor = System.Drawing.Color.Transparent;
            this.picThrowDice.Image = global::BackgammonProject2.Properties.Resources.diceRoll;
            this.picThrowDice.Location = new System.Drawing.Point(848, 178);
            this.picThrowDice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picThrowDice.Name = "picThrowDice";
            this.picThrowDice.Size = new System.Drawing.Size(154, 114);
            this.picThrowDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThrowDice.TabIndex = 11;
            this.picThrowDice.TabStop = false;
            this.picThrowDice.Visible = false;
            // 
            // picDice1
            // 
            this.picDice1.BackColor = System.Drawing.Color.Transparent;
            this.picDice1.Location = new System.Drawing.Point(848, 178);
            this.picDice1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(75, 74);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 12;
            this.picDice1.TabStop = false;
            // 
            // picDice2
            // 
            this.picDice2.BackColor = System.Drawing.Color.Transparent;
            this.picDice2.Location = new System.Drawing.Point(928, 178);
            this.picDice2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(75, 74);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 13;
            this.picDice2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.txtMess);
            this.panel1.Controls.Add(this.lstUsers);
            this.panel1.Location = new System.Drawing.Point(952, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 25);
            this.panel1.TabIndex = 14;
            // 
            // lblServerInfo
            // 
            this.lblServerInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblServerInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerInfo.Location = new System.Drawing.Point(152, 316);
            this.lblServerInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServerInfo.Name = "lblServerInfo";
            this.lblServerInfo.Size = new System.Drawing.Size(459, 63);
            this.lblServerInfo.TabIndex = 10;
            this.lblServerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayer1.Location = new System.Drawing.Point(823, 316);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(83, 37);
            this.lblPlayer1.TabIndex = 11;
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayer2.Location = new System.Drawing.Point(938, 316);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(83, 37);
            this.lblPlayer2.TabIndex = 12;
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPlayer1
            // 
            this.picPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer1.Location = new System.Drawing.Point(823, 395);
            this.picPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(82, 81);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer1.TabIndex = 15;
            this.picPlayer1.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer2.Location = new System.Drawing.Point(938, 395);
            this.picPlayer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(82, 81);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer2.TabIndex = 16;
            this.picPlayer2.TabStop = false;
            // 
            // lblTurn
            // 
            this.lblTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(830, 119);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(76, 23);
            this.lblTurn.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 422);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(830, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Turn of:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BackgammonProject2.Properties.Resources.Board;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.lblServerInfo);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picThrowDice);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.Controls.Add(this.lblThrowDice);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLogIn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picThrowDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Label lblThrowDice;
        private System.Windows.Forms.PictureBox picThrowDice;
        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblServerInfo;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picPlayer2;
        public System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

