using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Location = new Point(13, 13 + (23 + 3) * i);
                button.Text = "동적 생성 " + i + "번째";
                button.Width = 100;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
