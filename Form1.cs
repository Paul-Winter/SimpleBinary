using System;
using System.Windows.Forms;

namespace Binary_Simple
{
    public partial class Form : System.Windows.Forms.Form
    {
        public static byte x;
        public const byte a = 1;
        public const byte b = a * 2;
        public const byte c = b * 2;
        public const byte d = c * 2;
        public const byte e = d * 2;
        public const byte f = e * 2;
        public const byte g = f * 2;
        public const byte h = g * 2;

        public Form()
        {
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            field.Text = x.ToString();
        }

        private void Clicker(Button button, byte i)
        {
            if (button.Text == "0")
            {
                button.Text = "1";
                x = (byte)(x + i);
            }
            else
            {
                button.Text = "0";
                x = (byte)(x - i);
            }

            field.Text = x.ToString();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Clicker(btn_1, a);
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Clicker(btn_2, b);
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Clicker(btn_4, c);
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Clicker(btn_8, d);
        }

        private void Btn_16_Click(object sender, EventArgs e)
        {
            Clicker(btn_16, Form.e);
        }

        private void Btn_32_Click(object sender, EventArgs e)
        {
            Clicker(btn_32, f);
        }

        private void Btn_64_Click(object sender, EventArgs e)
        {
            Clicker(btn_64, g);
        }

        private void Btn_128_Click(object sender, EventArgs e)
        {
            Clicker(btn_128, h);
        }
    }
}
