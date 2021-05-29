using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace BackgammonProject2
{
    public partial class Form1 : Form
    {
        bool checkLogin = false;
        Player p1, p2;
        int dice1 = 0, dice2 = 0;
        int tcount = 1; //בשביל הטיימר לגיף
        public PictureBox recvpic;//        הגדרת משתנה זה רק לתמונה 
        public delegate void deleForm();
        public static deleForm myDelegate;
        public Form1 frmChat;
        ServerData sd;
        public static string IPAddress, UserName, Port, mess;
        public string firstCharInfoRes;

        public Form1()
        {
            InitializeComponent();
            myDelegate = new deleForm(MyProtocol);
        }
        Board b1;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogIn.Enabled == true)
            {

                btnLogIn.Enabled = false;
                frmConnect f2 = new frmConnect();
                f2.ShowDialog();
                if (IPAddress != null && Port != null && UserName != null)
                {


                    sd.StartServer(UserName, IPAddress, int.Parse(Port));
                    this.Text = UserName;//הכותרת של הטקסט תהיה השם של המשתמש
                }
                else
                    MessageBox.Show("לא הזנת נתוני התחברות", "שגיאה");
            }
            else
            {
                sd.WriteToServer("!" + UserName);
                sd.OnClosing();
                sd.stm = null;
                this.Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            sd.WriteToServer("!" + UserName);
            sd.stm = null;
            sd.OnClosing();
            this.Close();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sd.WriteToServer("#" + UserName + " : " + txtMess.Text + "\n");
        }

        private void lblThrowDice_Click(object sender, EventArgs e)
        {
            if (myPlayerNumber == currentPlayerNumber)
            {
                picThrowDice.Visible = true;
                tcount = 1;
                timer1.Enabled = true;
            }
            lblThrowDice.Visible = false;
            lblServerInfo.Visible = false;
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            frmChat = (Form1)this;//הגדרת מצביע לטופס הנוכחי
            sd = new ServerData(frmChat);//יצירת אובייקט חדש של המחלקה


        }

        public int myPlayerNumber;

        private void button1_Click(object sender, EventArgs e)
        {
            b1 = new Board(this, 83, 60, 2);
        }

        public int currentPlayerNumber = 1;
        Player[] allPlayers = new Player[3];
        string[] s1;
        public void MyProtocol()
        {
            string s;
            firstCharInfoRes = mess.Substring(0);
            switch (firstCharInfoRes[0])
            {// חלק זה יתבצע כל פעם שיתחבר לקוח חדש ואז נמחקת  רשימת המשתמשים שאונליין והיא נבנית מחדש 
                case '@':
                    lstUsers.Items.Clear();
                    //lstUsers.Items.Add("All Users");
                    //lstUsers.SetSelected(0, true);
                    firstCharInfoRes = firstCharInfoRes.Substring(2);// מוריד גם @ וגם רווח
                    firstCharInfoRes += " ";
                    s1 = firstCharInfoRes.Split(' ');
                    for (int i = 0; i < s1.Length - 2; i++)
                    {
                        lstUsers.Items.Add(s1[i]);
                    }
                    if (lstUsers.Items.Count == 1)  
                        lblServerInfo.Text = "מחכה לשחקן נוסף";
                    if (lstUsers.Items.Count == 2)
                    {
                        allPlayers[1] = new Player(1, "black", false, lstUsers.Items[0].ToString(), Properties.Resources.pic1);
                        allPlayers[2] = new Player(2, "white", false, lstUsers.Items[1].ToString(), Properties.Resources.pic0);
                        if (allPlayers[1].PlayerName == UserName)
                        {
                            myPlayerNumber = 1;
                            b1 = new Board(this, 660, 60, 1);
                        }
                        else
                        {
                            myPlayerNumber = 2;
                            b1 = new Board(this, 83, 60, 2);
                        }
                        lblServerInfo.Text = "התחילו לשחק";
                        lblPlayer1.Text = lstUsers.Items[0].ToString();
                        picPlayer1.Image = Properties.Resources.pic1;
                        lblPlayer2.Text = lstUsers.Items[1].ToString();
                        picPlayer2.Image = Properties.Resources.pic0;

                        lblTurn.Text = allPlayers[currentPlayerNumber].PlayerName;
                        if (UserName == lblTurn.Text)
                            lblThrowDice.Visible = true;
                    }
                    break;
                // חלק זה יתבצע כשאר לקוח מתנתק מהצ'אט ואז רשימת השתמשים תעודכן בלעדיו
                case '!':
                    s = firstCharInfoRes.Substring(1, firstCharInfoRes.IndexOf("\0") - 1);
                    lstUsers.Items.Remove(s);
                    break;
                // חלק זה מציג את ההודעה לכל המשתמשים בחלון הצאט
                case '#':
                    string tmp = firstCharInfoRes.Substring(1) + "\n";
                    //  messages.Add(tmp);
                    lblInfo.Text += tmp;
                    break;

                case '$':
                    firstCharInfoRes= firstCharInfoRes.Substring(0, 3);
                    dice1 = int.Parse(firstCharInfoRes.Substring(1,1));
                    dice2= int.Parse(firstCharInfoRes.Substring(2));
                    
                    b1.GetDice(dice1, dice2);
                    break;
                case '%'://MessageBox.Show(firstCharInfoRes);
                    firstCharInfoRes=firstCharInfoRes.Substring(0,firstCharInfoRes.IndexOf('\0'));
                    s1 = firstCharInfoRes.Substring(1).Split(' ');

                    if (UserName == s1[0])
                        b1.moveToFromServer(1, int.Parse(s1[1]), int.Parse(s1[2]), int.Parse(s1[3]));
                    //לסדר את התזוזה רגיל 
                    else
                        //,זוזה הפוכה 
                        b1.moveToFromServer(2, int.Parse(s1[1]), int.Parse(s1[2]), int.Parse(s1[3]));
                    
                    break;

                case '~':
                    ChangeCurrentPlayer(mess);
                    break;
                case '^':
                    
                    break;
                    
            }
            
            //string s;
            //firstCharInfoRes = mess;
            //switch (firstCharInfoRes[0])
            //{// חלק זה יתבצע כל פעם שיתחבר לקוח חדש ואז נמחקת  רשימת המשתמשים שאונליין והיא נבנית מחדש 
            //    case '@':
            //        lstUsers.Items.Clear();
            //        lstUsers.Items.Add("All Users");
            //        lstUsers.SetSelected(0, true);
            //        firstCharInfoRes = firstCharInfoRes.Substring(2);// מוריד גם @ וגם רווח
            //        firstCharInfoRes += " ";
            //        while (firstCharInfoRes != " ")
            //        {
            //            s = firstCharInfoRes.Substring(0, firstCharInfoRes.IndexOf(" "));
            //            lstUsers.Items.Add(s);
            //            firstCharInfoRes = firstCharInfoRes.Substring(firstCharInfoRes.IndexOf(" ") + 1);
            //        }
            //        break;
            //    // חלק זה יתבצע כשאר לקוח מתנתק מהצ'אט ואז רשימת השתמשים תעודכן בלעדיו
            //    case '!':
            //        s = firstCharInfoRes.Substring(1, firstCharInfoRes.IndexOf("\0") - 1);
            //        lstUsers.Items.Remove(s);
            //        break;                // חלק זה מציג את ההודעה לכל המשתמשים בחלון הצאט
            //    case '#':
            //        string tmp = firstCharInfoRes.Substring(1) + "\n";
            //        lblInfo.Text += tmp;
            //        break;
            

        }

        private void switchTurn()
        {
          
        }

        public void ChangeCurrentPlayer(string m)
        {
            if (m.Contains(allPlayers[1].PlayerName))
            {
                currentPlayerNumber = 2;
                lblTurn.Text = allPlayers[2].PlayerName;
            }
           else
            {
                currentPlayerNumber = 1;
                lblTurn.Text = allPlayers[1].PlayerName;
            }
            if (UserName == lblTurn.Text)
                lblThrowDice.Visible = true;
            else
                lblThrowDice.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            tcount--;
            if (tcount == 0)
            {
                timer1.Enabled = false;
                picThrowDice.Visible = false;
                DiceShowResult();
            }  
        }

        public void DiceShowResult()
        {
            Random rnd = new Random();
            dice1 = rnd.Next(1,7);
            dice2 = rnd.Next(1,7);
            if (dice1 == 1)
                picDice1.Image = Properties.Resources.dice1;
            if (dice1 == 2)
                picDice1.Image = Properties.Resources.dice2;
            if (dice1 == 3)
                picDice1.Image = Properties.Resources.dice3;
            if (dice1 == 4)
                picDice1.Image = Properties.Resources.dice4;
            if (dice1 == 5)
                picDice1.Image = Properties.Resources.dice5;
            if (dice1 == 6)
                picDice1.Image = Properties.Resources.dice6;

            if (dice2 == 1)
                picDice2.Image = Properties.Resources.dice1;
            if (dice2 == 2)
                picDice2.Image = Properties.Resources.dice2;
            if (dice2 == 3)
                picDice2.Image = Properties.Resources.dice3;
            if (dice2 == 4)
                picDice2.Image = Properties.Resources.dice4;
            if (dice2 == 5)
                picDice2.Image = Properties.Resources.dice5;
            if (dice2 == 6)
                picDice2.Image = Properties.Resources.dice6;

            
            sd.WriteToServer("$" + dice1+dice2);
            
            

        }

        internal void sendFinishMove(string v)
        {
            sd.WriteToServer(v);
        }

        public void sendToServerPressTag(string tag)
        {
            sd.WriteToServer("%" + UserName + " " + tag);
        }
        public void sendToServerEaten(string tag)
        {

        }
    }
}
