using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //64 button is required for 8x8 checkerboard pattern ,so we use arrays
          
            Button[,] buttons = new Button[8,8];  //button object is created
            int top = 0;
            int left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0) ; i++)// from 0 to 7
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    //buttons is put through right
                    buttons[i, j].Left = left;
                    //for buttons go down
                    buttons[i, j].Top = top;
                    left += 50;
                    //one of the button's colour is black and the other one is white
                    if ((i+j)%2==0)  //if the mod operation of i+j for 2 is equal to zero 
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    
                    this.Controls.Add(buttons[i,j]); //adds button
                }
                //for the buttons go to second row, left should be resetted otherwise the buttons go to the left forever
                top += 50;
                left = 0; //8 buttons put next to each other
            } 

           

        }
    }
}
