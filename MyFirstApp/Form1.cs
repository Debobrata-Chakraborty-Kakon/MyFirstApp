using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        string lastOperand;
        int lastNumber;

        public Form1()
        {
            InitializeComponent();


            for (int i = 0; i < 9; i++)
            {
                Button btn = new Button();
                btn.Text = (i + 1).ToString();
                btn.Location = new Point(10 + (i % 3) * 50, 120 + (i / 3) * 50);
                btn.Size = new Size(50, 50);

                btn.Click += (object sender, EventArgs e) => { numbersTextBox.Text += (sender as Button).Text; };

                this.Controls.Add(btn);

            }



            string[] opratorButtonsName = { "+", "-", "*", "/" };
            for (int i = 0; i < 4; i++)
            { 
                Button btn = new Button();
                btn.Text = opratorButtonsName[i];
                btn.Location = new Point(160, 70 + i * 50);
                btn.Size = new Size(50, 50);
                this.Controls.Add(btn);

                btn.Click += (object sender, EventArgs e) => {
                    int.TryParse(numbersTextBox.Text, out lastNumber);
                    lastOperand = (sender as Button).Text;

                };

            }

        }
                
    }
}
