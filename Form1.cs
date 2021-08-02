using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        //create objects
        Label balance = new Label();
        Label betLabel = new Label();
        TextBox betBox = new TextBox();
        Button betButton = new Button();
        Panel bets = new Panel();
        Panel debug = new Panel();
        Button debugWin = new Button();
        Button debugLose = new Button();
        Button debugBlackjack = new Button();
        int bal=100;
        int bet = 0;
        public Form1(){
            InitializeComponent();
            //set form size
            this.MinimumSize = new Size(500,500);
            this.Size = new Size(500,500);
            this.MaximumSize = new Size(500,500);
            this.Text = ".NET Blackjack";
            //add objects
            this.Controls.Add(bets);
            this.Controls.Add(debug);
            bets.Controls.Add(betButton);
            bets.Controls.Add(betBox);
            bets.Controls.Add(balance);
            bets.Controls.Add(betLabel);
            //cofigure objects
            bets.Location = new Point(0,250);
            bets.Size = new Size(250,80);
            bets.BackColor = Color.Azure; //Debug. To see where the panel is
            //DEBUG START
            debug.Location = new Point(0,0);
            debug.Size = new Size(340,45);
            debug.BackColor = Color.MistyRose;
            debug.Controls.Add(debugBlackjack);
            debug.Controls.Add(debugWin);
            debug.Controls.Add(debugLose);
            debugWin.Location = new Point(10,10);
            debugWin.Size = new Size(100,25);
            debugWin.Text = "Force Win";
            debugWin.Click += new EventHandler(win);
            debugLose.Location = new Point(120,10);
            debugLose.Size = new Size(100,25);
            debugLose.Text = "Force Loose";
            debugLose.Click += new EventHandler(lose);
            debugBlackjack.Location = new Point(230,10);
            debugBlackjack.Size = new Size(100,25);
            debugBlackjack.Text = "BlackJack";
            debugBlackjack.Click += new EventHandler(blackjackWin);
            //DEBUG END
            balance.Text = bal.ToString();
            balance.Font = new Font("Helvetica",10);
            balance.AutoSize = false;
            balance.Location = new Point(125-50,10);
            balance.Size = new Size(50,50);
            betBox.AutoSize=false;
            betBox.Font = new Font("Helvetica", 10);
            betBox.Location = new Point(125-50,30);
            betBox.Size = new Size(100,20);
            betButton.Location = new Point(125-25,50);
            betButton.Size = new Size(50,20);
            betButton.Text = "Bet";
            betButton.Font = new Font("Helvetica",7);
            betButton.Click += new EventHandler(setBet);
            betLabel.Location = new Point(125,10);
            betLabel.Size = new Size(50,999); //TEMP
            betLabel.TextAlign = ContentAlignment.TopRight;
            betLabel.Text=bet.ToString();
        }

        public void setBet(object sender, EventArgs e){
            int tmp = bet;
            bet = Int32.Parse(betBox.Text);
            if ((bal-bet)>0){bal-=bet;}
            balance.Text = bal.ToString();
            betLabel.Text = bet.ToString();
        }
        public void win(object sender, EventArgs e){
            bet*=2;
            bal+=bet;
            bet=0;
        }
        public void lose(object sender, EventArgs e){
            bet=0;
        }
        public void blackjackWin(object sender, EventArgs e){
            bet*=5;
            bet/=2;
            bal+=bet;
            bet=0;
        }
    }
}
