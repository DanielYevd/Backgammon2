namespace BackgammonProject2
{
    partial class FormBegin
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
            this.btnInstr = new System.Windows.Forms.Button();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstr
            // 
            this.btnInstr.BackColor = System.Drawing.Color.Transparent;
            this.btnInstr.BackgroundImage = global::BackgammonProject2.Properties.Resources.picInstructions;
            this.btnInstr.Location = new System.Drawing.Point(46, 434);
            this.btnInstr.Name = "btnInstr";
            this.btnInstr.Size = new System.Drawing.Size(120, 100);
            this.btnInstr.TabIndex = 1;
            this.btnInstr.UseVisualStyleBackColor = false;
            this.btnInstr.Click += new System.EventHandler(this.btnInstr_Click);
            // 
            // picStart
            // 
            this.picStart.BackColor = System.Drawing.Color.Transparent;
            this.picStart.BackgroundImage = global::BackgammonProject2.Properties.Resources.picPlay;
            this.picStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStart.Location = new System.Drawing.Point(1302, 692);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(130, 100);
            this.picStart.TabIndex = 2;
            this.picStart.TabStop = false;
            this.picStart.Click += new System.EventHandler(this.picStart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::BackgammonProject2.Properties.Resources.picInstructions;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(34, 692);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FormBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BackgammonProject2.Properties.Resources.welcomePic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1483, 853);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picStart);
            this.Controls.Add(this.btnInstr);
            this.Name = "FormBegin";
            this.Text = "FormBegin";
            this.Load += new System.EventHandler(this.FormBegin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInstr;
        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}