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
            this.Controls.Add(betButton);
            this.Controls.Add(betBox);
            this.Controls.Add(balance);
            System.Diagnostics.Debug.WriteLine(bal.ToString()); //testing .ToString()
            balance.Text = bal.ToString();
            balance.Font = new Font("Helvetica",20);
            balance.AutoSize = false;
            balance.TextAlign = ContentAlignment.TopCenter;
            balance.Location = new Point(125,250);
            balance.Size = new Size(250,50);

            
            
        }

    }
}
