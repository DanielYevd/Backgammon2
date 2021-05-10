using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgammonProject2
{
    class Cell
    {
        private int x;
        private int y;
        private int color; //2-white,1-black
        private PictureBox cellpic;
        private Image img;
        int place;
        public Cell(int x, int y, int color, int place)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.place = place;
            picDef();
            
        }

        public int X { get => x; set { x = value; cellpic.Location = new Point(value,cellpic.Location.Y); } }
        public int Y { get => y; set { y = value; cellpic.Location = new Point( cellpic.Location.X,value); } }

        public int Color { get => color; set => color = value; }
        public PictureBox Cellpic { get => cellpic; set => cellpic = value; }
        public Image Img { get => img; set => img = value; }

        private void picDef()
        {
            this.cellpic = new PictureBox();
            if (this.color == 2)
                this.cellpic.Image = Properties.Resources.pic0;
            if (this.color == 1)
                this.cellpic.Image = Properties.Resources.pic1;
            
            this.cellpic.Location = new Point(x, y);
            this.cellpic.Size = new Size(50, 50);
            this.cellpic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.cellpic.Tag = this.color+","+place;
            this.cellpic.BackColor = System.Drawing.Color.Transparent;
            //this.cellpic.Click += Cellpic_Click;
           
        }

        //private void Cellpic_Click(object sender, EventArgs e)
        //{
        //    PictureBox pressPic = (PictureBox)sender;
        //    MessageBox.Show(pressPic.Tag.ToString());
        //}
    }
}
