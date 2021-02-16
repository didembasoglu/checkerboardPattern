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
            //64 tane buton yapmamız lazım 8x8 dama tahtası yapmak için arraydan yararlanıcaz

            Button[,] buttons = new Button[8,8];  //buton nesnesini oluşturduk
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0) ; i++)// sıfırıncı boyutun en büyük alabileceği değer 7
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    //butonları sağa koyması için
                    buttons[i, j].Left = left;
                    //aşağı kayması için
                    buttons[i, j].Top = top;
                    left += 50;
                    //butonların biri siyah biri beyaz olsun istiyoruz
                    if ((i+j)%2==0)  //i+jnin mod 2si sıfırsa yani ikiye tam bölünüyorsa
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    
                    this.Controls.Add(buttons[i,j]); //buton ekleme
                }
                //ikinci satıra geçmesi için lefti sıfırlamam lazım yoksa sonsuza kadar sağa gider
                top += 50;
                left = 0; //8 tane buton yanyana oldu 
            }

           

        }
    }
}
