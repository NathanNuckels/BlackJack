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
        TextBox betBox = new TextBox();
        Button betButton = new Button();
        Panel bets = new Panel();
        int bal=100;
        public Form1()
        {
            InitializeComponent();
            //set form size
            this.MinimumSize = new Size(500,500);
            this.Size = new Size(500,500);
            this.MaximumSize = new Size(500,500);
            this.Text = ".NET Blackjack";
            //add objects
            this.Controls.Add(bets);
            bets.Controls.Add(betButton);
            bets.Controls.Add(betBox);
            bets.Controls.Add(balance);
            bets.Location = new Point(0,250);
            bets.Size = new Size(250,80);
            bets.BackColor = Color.Azure; //Debug. To see where the panel is

            balance.Text = bal.ToString();
            balance.Font = new Font("Helvetica",10);
            balance.AutoSize = false;
            balance.TextAlign = ContentAlignment.TopCenter;
            balance.Location = new Point(0,10);
            balance.Size = new Size(250,50);

            betBox.AutoSize=false;
            //betBox.Text = "lokiujhygtfr"; //debug
            betBox.Font = new Font("Helvetica", 10);
            betBox.Location = new Point(125-50,30);
            betBox.Size= new Size(100,20);

            betButton.Location = new Point(125-25,50);
            betButton.Size = new Size(50,20);
            betButton.Text="Bet";
            betButton.Font= new Font("Helvetica",7);

            
            
        }

    }
}
