using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgammonProject2
{
    //enum Colors
    //{
    //    Black,
    //    White,
    //}

    class Triangle
    {
        private int count;
        private int x;
        private int y;
        private Stack<Cell> stack;
        private int place;
        private int upOrDown; // 0 for up and 1 for down
        private Form frm;
        //private int triangleIndex = 0;
        public Cell popCell(int i)
        {
            return stack.Pop();
        }
        public void pushCell(int i)
        {

        }
        public Triangle(int x, int y, int place, int upOrDown, Form form)
        {
            this.x = x;
            this.y = y;
            this.place = place;
            this.upOrDown = upOrDown;
            this.stack = new Stack<Cell>();
            this.frm = form;
            this.count = 0;

        }

        public void Add(int color, int count)
        {
            for (int i = 0; i < count ; i++)
            {
                Add(color);
            }
        }
        public void Add(int color)
        {
            
            Cell c;
            c = new Cell(this.x, this.y, color,place);
            if (this.upOrDown == 0)
                c.Y += count * 50;
            else
                c.Y -= count * 50;
            this.stack.Push(c);
            this.frm.Controls.Add(c.Cellpic);
            this.count++;
        }
        public void Remove()
        {
            if (count > 0)
            {
                this.count--;
                this.frm.Controls.Remove(this.stack.Pop().Cellpic);
            }
        }
        public int getTriangleColor()
        {
           
                return this.stack.Peek().Color;
           
        }

        internal Stack<Cell> getTriangleStack()
        {
            return stack;
        }
    }
}
