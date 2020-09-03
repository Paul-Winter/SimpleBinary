using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Simple_Binary
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        static int result = 0;
        static int[] values = new int[8];
        List<Label> labels = new List<Label>();
        List<Button> buttons = new List<Button>();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Заполнение коллекций

            //  заполняется коллекция меток
            labels.Add(lbl1);
            labels.Add(lbl2);
            labels.Add(lbl4);
            labels.Add(lbl8);
            labels.Add(lbl16);
            labels.Add(lbl32);
            labels.Add(lbl64);
            labels.Add(lbl128);

            //  заполняется коллекция кнопок
            buttons.Add(btn_1);
            buttons.Add(btn_2);
            buttons.Add(btn_4);
            buttons.Add(btn_8);
            buttons.Add(btn_16);
            buttons.Add(btn_32);
            buttons.Add(btn_64);
            buttons.Add(btn_128);

            #endregion

            values[0] = 1;
            labels[0].Text = values[0].ToString();

            //  заполняется массив значений и присваиваются значения соответствующим меткам
            for (int i = 1; i < values.Length; i++)
            {
                values[i] = values[i - 1] * 2;
                labels[i].Text = values[i].ToString();
            }
            lblResult.Text = result.ToString();
        }

        /// <summary>
        /// Метод инвертирует двоичные значения кнопок
        /// и меняет значение итогового результата соответственно им
        /// </summary>
        /// <param name="button"></param>
        /// <param name="i"></param>
        private void Clicker(Button button, Label label)
        {
            if (button.Text == "0")
            {
                button.Text = "1";
                lblResult.Text = (Convert.ToInt32(lblResult.Text) + Convert.ToInt32(label.Text)).ToString();
            }
            else
            {
                button.Text = "0";
                lblResult.Text = (Convert.ToInt32(lblResult.Text) - Convert.ToInt32(label.Text)).ToString();
            }
        }

        #region Нажатие на кнопки

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Clicker(buttons[0], labels[0]);
        }
        private void Btn_2_Click(object sender, EventArgs e)
        {
            Clicker(buttons[1], labels[1]);
        }
        private void Btn_4_Click(object sender, EventArgs e)
        {
            Clicker(buttons[2], labels[2]);
        }
        private void Btn_8_Click(object sender, EventArgs e)
        {
            Clicker(buttons[3], labels[3]);
        }
        private void Btn_16_Click(object sender, EventArgs e)
        {
            Clicker(buttons[4], labels[4]);
        }
        private void Btn_32_Click(object sender, EventArgs e)
        {
            Clicker(buttons[5], labels[5]);
        }
        private void Btn_64_Click(object sender, EventArgs e)
        {
            Clicker(buttons[6], labels[6]);
        }
        private void Btn_128_Click(object sender, EventArgs e)
        {
            Clicker(buttons[7], labels[7]);
        }

        #endregion
    }
}