using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgammonProject2
{
    class Board
    {
        bool isThereMoveTo = false;
        bool isDoubleTurn = false;
        int doubleTurnCount = 0;
        int dice1 = 0, dice2 = 0;
        int where1 = 0, where2 = 0;
        private Triangle[] boardarr = new Triangle[27];
        private int x;
        private int y;
        private Form1 frm;
        private int playerNum;
        PictureBox[] moveToArr = new PictureBox[25];
        int pressPicTag;
        Triangle eatenBlack;
        Triangle eatenWhite;

        public Board(Form1 frm, int x, int y, int playerNum)
        {
            this.frm = frm;
            this.x = x;
            this.y = y;
            this.playerNum = playerNum;
            drawBoard();
        }
        //פונקציה הממקמת את התמונות מתחת לכל חלק על מנת לדעת לאן לזוז
        public void PlaceUnder(int i,int x,int y)
        {
            
             moveToArr[i] = new PictureBox();
            this.moveToArr[i].Location = new Point(x, y);
            this.moveToArr[i].Size = new Size(30, 20);
            this.moveToArr[i].SizeMode = PictureBoxSizeMode.StretchImage;
            this.moveToArr[i].Tag = i.ToString();
            this.moveToArr[i].BackColor = System.Drawing.Color.Transparent;
            this.moveToArr[i].Image = Properties.Resources.redDot1;
            this.moveToArr[i].Visible = false;
            frm.Controls.Add(this.moveToArr[i]);
           
        }
        
        private void drawBoard()
        {
            
            if (this.playerNum == 1)
            {
                for (int i = 1; i < 25; i++)
                {
                    if (i < 13)
                        boardarr[i] = new Triangle(this.x, this.y, i, 0, frm);
                    else
                        boardarr[i] = new Triangle(this.x, this.y, i, 1, frm);

                    if (i == 6 || i == 13)
                        boardarr[i].Add(2, 5);
                    if (i == 12 || i == 19)
                        boardarr[i].Add(1, 5);
                    if (i == 17)
                        boardarr[i].Add(1, 3);
                    if (i == 24)
                        boardarr[i].Add(2, 2);
                    if (i == 8)
                        boardarr[i].Add(2, 3);
                    if (i == 1)
                        boardarr[i].Add(1, 2);


                    if (i >= 0 && i <= 12)
                        PlaceUnder(i, this.x+10, this.y - 20);
                    else
                        PlaceUnder(i, this.x+10, this.y + 60);

                    if (i != 12)
                    {
                        if (i < 12)
                            this.y = 60;
                        if (i > 12)
                            this.y = 584;
                        if (i != 24)
                        {
                            if (i < 12)
                            {
                                if (i != 6)
                                    this.x -= 49;
                                else
                                    this.x -= 87;
                            }
                            if (i > 12)
                            {
                                if (i != 18)
                                    this.x += 49;
                                else
                                    this.x += 87;
                            }
                            //if (i == 6)
                            //    this.x -= 91;
                            //else if (i == 18)
                            //    this.x += 91;
                            //else
                            //{ 
                            //if (x < 13)
                            //    this.x -= 58;
                            //if (x > 13)
                            //        this.x += 58;
                            //}
                        }
                    }
                    else
                    {
                        this.x = 83;
                        this.y = 584;
                    }
                }
            }
            if (playerNum == 2)
            {
                for (int i = 1; i < 25; i++)
                {
                    if (i < 13)
                        boardarr[i] = new Triangle(this.x, this.y, i, 0, frm);
                    else
                        boardarr[i] = new Triangle(this.x, this.y, i, 1, frm);

                    if (i == 6 || i == 13)
                        boardarr[i].Add(1, 5);
                    if (i == 12 || i == 19)
                        boardarr[i].Add(2, 5);
                    if (i == 17)
                        boardarr[i].Add(2, 3);
                    if (i == 24)
                        boardarr[i].Add(1, 2);
                    if (i == 8)
                        boardarr[i].Add(1, 3);
                    if (i == 1)
                        boardarr[i].Add(2, 2);


                    if (i>=0 && i<=12)
                        PlaceUnder(i,this.x+20,this.y-20);
                    else
                        PlaceUnder(i, this.x+20, this.y + 60);

                    if (i != 12)
                    {
                        if (i < 12)
                            this.y = 60;
                        if (i > 12)
                            this.y = 584;
                        if (i != 24)
                        {
                            if (i < 12)
                            {
                                if (i != 6)
                                    this.x += 49;
                                else
                                    this.x += 87;
                            }
                            if (i > 12)
                            {
                                if (i != 18)
                                    this.x -= 49;
                                else
                                    this.x -= 87;
                            }
                        }
                        }
                    else
                    {
                        this.x = 660;
                        this.y = 584;
                    }
                }
            }
            eatenBlack = new Triangle(1, 1, 25, 0, frm);
            eatenWhite = new Triangle(1, 1, 26, 0, frm);
            boardarr[25] = eatenBlack;
            boardarr[26] = eatenWhite;
            //רצנו על כל המשולשים שיש לנו בלוח 
            //ובכל משולש פנינו לכל תמונה והוספנו לה ארוע לחיצה 
            //יש לבדוק את האופציה שאולי ניתן רק לתא הראשון במחסנית את הערכים 
            //יש בסדוק למה זה עובד רק על 3 חיילים ולא על כולם 
            for (int i = 1; i < boardarr.Length-2; i++)
            {
                Stack<Cell> s = new Stack<Cell>();
                s= boardarr[i].getTriangleStack();
                Stack<Cell> tmp = new Stack<Cell>();
                Cell c;
                while(s.Count>0)
                {
                    c = s.Pop();
                    c.Cellpic.Click += Cellpic_Click;
                    tmp.Push(c);
                }
                while(tmp.Count>0)
                {
                    s.Push(tmp.Pop());
                }
            }

            for (int i = 1; i < moveToArr.Length; i++)
            {
                    moveToArr[i].Click += moveTo_Click;
            }

        }

        public void clearMoveArr(PictureBox[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != null)
                    arr[i].Visible = false;
            }
        }
        string stam = "";
        private void moveTo_Click(object sender, EventArgs e)
        {
            PictureBox MoveToPic = (PictureBox)sender;
            if (MoveToPic.Visible == true)
            {
                int tag = int.Parse(MoveToPic.Tag.ToString());
                stam = "";
                stam = pressPicTag.ToString();
                if (boardarr[tag].getTriangleStack().Count == 1 && boardarr[tag].getTriangleColor() != this.frm.currentPlayerNumber)
                {
                    frm.sendToServerPressTag(stam + " " + tag + " " + boardarr[tag].getTriangleColor());
                }
                else
                    frm.sendToServerPressTag(stam + " " + tag + " " + 0);//*****************************************************************
               
                //boardarr[tag].Add(boardarr[pressPicTag].getTriangleColor());
                //boardarr[tag].getTriangleStack().Peek().Cellpic.Click += Cellpic_Click;
                //boardarr[pressPicTag].Remove();
                //clearMoveArr(moveToArr);
                //if (tag == where1)
                //    dice1 = -1;
                //else
                //    dice2 = -1;
           
            }
        }
        public void moveToFromServer(int x,int start,int end,int whichEaten)
        {
            if (x == 1)
            {
                if (whichEaten != 0)
                {
                    if (whichEaten == 1)
                        boardarr[25].Add(boardarr[end].getTriangleColor());
                    else
                        boardarr[26].Add(boardarr[end].getTriangleColor());
                    boardarr[end].Remove();
                }
                boardarr[end].Add(boardarr[start].getTriangleColor());
                boardarr[end].getTriangleStack().Peek().Cellpic.Click += Cellpic_Click;
                boardarr[start].Remove();

                clearMoveArr(moveToArr);
                if (isDoubleTurn == false)
                {
                    if (end == where1)
                        dice1 = -1;
                    else
                        dice2 = -1;
                }
                else
                    doubleTurnCount++;
            }
            else
            {
                if (isDoubleTurn == false)
                {
                    if (end == where1)
                        dice1 = -1;
                    else
                        dice2 = -1;
                }
                else
                    doubleTurnCount++;

                if (end <= 12)
                    end += 12;
                else
                    end -= 12;
                if (end <= 12)
                    end = 13 - end;
                else
                    end = 12 + (25 - end);


                if (start <= 12)
                    start += 12;
                else
                    start -= 12;
                if (start <= 12)
                    start = 13 - start;
                else
                    start = 12 + (25 - start);

                //boardarr[end].Add(boardarr[start].getTriangleColor());
                //boardarr[end].getTriangleStack().Peek().Cellpic.Click += Cellpic_Click;
                //boardarr[start].Remove();
                //clearMoveArr(moveToArr);

                if (whichEaten != 0)
                {
                    if (whichEaten == 1)
                        boardarr[25].Add(boardarr[end].getTriangleColor());
                    else
                        boardarr[26].Add(boardarr[end].getTriangleColor());
                    boardarr[end].Remove();
                }
                boardarr[end].Add(boardarr[start].getTriangleColor());
                boardarr[end].getTriangleStack().Peek().Cellpic.Click += Cellpic_Click;
                boardarr[start].Remove();
            }
            if (isDoubleTurn == false)
            {
                if (dice1 == -1 && dice2 == -1)
                    frm.sendFinishMove("~" + Form1.UserName);
            }
            else
            {
                if (doubleTurnCount == 4)
                {
                    isDoubleTurn = false;
                    doubleTurnCount = 0;
                    frm.sendFinishMove("~"+Form1.UserName);
                }
            }
            start = 0;
            end = 0;
                    //    frm.ChangeCurrentPlayer();
        }
        private void Cellpic_Click(object sender, EventArgs e)
        {
            if (frm.currentPlayerNumber == frm.myPlayerNumber)
            {
                int playernum = this.frm.currentPlayerNumber;
                //int where1 = 0, where2 = 0;
                PictureBox pressPic = (PictureBox)sender;
                pressPicTag = int.Parse(pressPic.Tag.ToString().Split(',')[1]);




                if (dice1 != 0 && dice2 != 0 && playernum == int.Parse(pressPic.Tag.ToString().Split(',')[0])) //can use piece?
                {
                    clearMoveArr(moveToArr);
                    where1 = int.Parse(pressPic.Tag.ToString().Substring(2)) + dice1;
                    where2 = int.Parse(pressPic.Tag.ToString().Substring(2)) + dice2;
                    if (isDoubleTurn == false)
                    {
                        if (dice1 != -1)
                        {
                            if (where1 > 24)
                            {
                                if (boardarr[24].getTriangleStack().Count == 1 || boardarr[24].getTriangleStack().Count == 0 || (boardarr[24].getTriangleColor() == playernum && boardarr[24].getTriangleStack().Count<5))
                                {
                                    //if (boardarr[24].getTriangleStack().Count == 1 || boardarr[24].getTriangleStack().Peek().Color == int.Parse(pressPic.Tag.ToString().Substring(0, 0)))
                                    moveToArr[24].Visible = true;
                                    where1 = 24;
                                }
                            }
                            else
                            {
                                if (boardarr[where1].getTriangleStack().Count == 1 || boardarr[where1].getTriangleStack().Count == 0 || (boardarr[where1].getTriangleColor() == playernum && boardarr[where1].getTriangleStack().Count<5))
                                    moveToArr[where1].Visible = true;
                            }
                        }
                        if (dice2 != -1)
                        {
                            if (where2 > 24)
                            {
                                if (boardarr[24].getTriangleStack().Count == 1 || boardarr[24].getTriangleStack().Count == 0 || (boardarr[24].getTriangleColor() == playernum && boardarr[24].getTriangleStack().Count<5))
                                {
                                    moveToArr[24].Visible = true;
                                    where2 = 24;
                                }
                            }
                            else
                            {
                                if (boardarr[where2].getTriangleStack().Count == 1 || boardarr[where2].getTriangleStack().Count == 0 || (boardarr[where2].getTriangleColor() == playernum && boardarr[where2].getTriangleStack().Count<5))
                                    moveToArr[where2].Visible = true;
                            }
                        }
                        //if (dice1 == -1 && dice2 == -1)
                        //{
                        //    frm.ChangeCurrentPlayer();
                            
                        //}
                    }
                    else
                    {
                        if (where1 > 24)
                        {
                            if (boardarr[24].getTriangleStack().Count == 1 || boardarr[24].getTriangleStack().Count == 0 || (boardarr[24].getTriangleColor() == playernum && boardarr[24].getTriangleStack().Count<5))
                            {
                                //if (boardarr[24].getTriangleStack().Count == 1 || boardarr[24].getTriangleStack().Peek().Color == int.Parse(pressPic.Tag.ToString().Substring(0, 0)))
                                moveToArr[24].Visible = true;
                                where1 = 24;
                            }
                        }
                        else
                        {
                            if (boardarr[where1].getTriangleStack().Count == 1 || boardarr[where1].getTriangleStack().Count == 0 || (boardarr[where1].getTriangleColor() == playernum && boardarr[where1].getTriangleStack().Count<5))
                                moveToArr[where1].Visible = true;
                        }
                        //if (doubleTurnCount == 4)
                        //{
                        //    doubleTurnCount = 0;
                        //    isDoubleTurn = false;
                        //    frm.ChangeCurrentPlayer();
                        //}


                        //doubleTurnCount++;
                        //if (doubleTurnCount == 4)
                        //{
                        //    doubleTurnCount = 0;
                        //    isDoubleTurn = false;
                        //    frm.ChangeCurrentPlayer();
                        //}
                    }
                    for (int j = 1; j < 25; j++)
                    {
                        if (moveToArr[j].Visible == true)
                            isThereMoveTo = true;
                    }
                    if (isThereMoveTo == false)
                    {
                        if (isDoubleTurn == true)
                        {
                            doubleTurnCount = 0;
                            isDoubleTurn = false;
                        }
                        frm.sendFinishMove("~" + Form1.UserName);
                    }
                    //howMany1 = int.Parse(pressPic.Tag.ToString().Substring(2));
                    //howMany2 = int.Parse(pressPic.Tag.ToString().Substring(1));
                    //moveToArr[howMany]
                }
            }
        }
        public void GetDice(int d1, int d2)
        {
            dice1 = 3;
            dice2 = 3;
            if (dice1 == dice2)
                isDoubleTurn = true;
            if (boardarr[frm.myPlayerNumber + 24].getTriangleStack().Count() !=0)
            {
                for (int i = 1; i < 25; i++)
                    if (boardarr[i].getTriangleStack() == null || boardarr[i].getTriangleColor()==frm.myPlayerNumber)
                        boardarr[i].getTriangleStack().Push(boardarr[frm.myPlayerNumber + 24].getTriangleStack().Pop());
                if (isDoubleTurn == true)
                    doubleTurnCount++;
                else
                {
                    if (dice1 < dice2)
                        dice1 = -1;
                    else
                        dice2 = -1;
                }
            }
        }
    }
}

