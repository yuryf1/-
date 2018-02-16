using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Брахман
{
    /// <summary>
    /// Код написан до изучения объектно-ориентированного программирования
    /// </summary>
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] Health = { 0.5, 1.5 };
            double[] Sex = { 0.5, 2.5 };
            double[] Superman = { 1, 3 };
            double[] Business = { 3, 8 };

            double Happ = Happy();

            double X1, X2, X3, X4;
            X1 = Convert.ToDouble(textBoxHealth.Text);
            X2 = Convert.ToDouble(textBoxSex.Text);
            X3 = Convert.ToDouble(textBoxSuperman.Text);
            X4 = Convert.ToDouble(textBoxBusiness.Text);

            double H = Solution(Happ, X1, Health);
            double Se = Solution(Happ, X2, Sex);
            double Su = Solution(Happ, X3, Superman);
            double B = Solution(Happ, X4, Business);

//расчет с заполнением в ячейки
            HealthDay1.Text = Convert.ToString(Math.Truncate(H));
            HealthDay11.Text = Convert.ToString(Math.Round((H - Math.Truncate(H)) * 60,0));
            SexDay1.Text = Convert.ToString(Math.Truncate(Se));
            SexDay11.Text = Convert.ToString(Math.Round((Se - Math.Truncate(Se)) * 60, 0));
            SupermanDay1.Text = Convert.ToString(Math.Truncate(Su));
            SupermanDay11.Text = Convert.ToString(Math.Round((Su - Math.Truncate(Su)) * 60, 0));
            BusinessDay1.Text = Convert.ToString(Math.Truncate(B));
            BusinessDay11.Text = Convert.ToString(Math.Round((B - Math.Truncate(B)) * 60, 0));
//расчет идеальной жизни)
            double I, I1, I2, I3, I4;
            I1 = Math.Min(H, X1) / Math.Max(H, X1);
            I2 = Math.Min(Se, X2) / Math.Max(Se, X2);
            I3 = Math.Min(Su, X3) / Math.Max(Su, X3);
            I4 = Math.Min(B, X4) / Math.Max(B, X4);
            I =  100 * (I1 + I2 + I3 + I4) / 4;
            I = Math.Round(I, 0);
            textBoxOut.Text = "Вы являетесь роботом на " + Convert.ToString(I) + "%.\n\r";
            textBoxOut.Text += "\n\rЧем более высоким процентом Вы обладаете - тем Вы эффективнее.";
        }
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44)
                {
                e.Handled = true;
                }
        }


        private double Happy()
        {
            double A;
            switch (comboBox1.SelectedIndex)
            {
                case 4:
                    A = 0.5;
                    break;
                case 1:
                    A = 0.9;
                    break;
                case 2:
                    A = 0.8;
                    break;
                case 3:
                    A = 0.7;
                    break;
                default:
                    A = 1;
                    break;
            }
            A = 0.1*A*trackBar1.Value;
            return A;

        }

        private double Solution (double A, double X, double[] Y)
        {
            if (X < Y[0])
            {
                X = Y[1];
            }
            else
            {
                if (X > Y[1])
                {
                    X = 0;
                }
                else
                {
                    X = Y[0] + Y[1] - X;
                }
            }
            X *= A;
            return X;
        }


 // валидация сразу 4х тексбоксов и 1ого ползунка (через конструктор)
        private void textBoxHealth_Validating(object sender, CancelEventArgs e)
        {
            double Z1 = Convert.ToDouble(textBoxHealth.Text);
            double Z2 = Convert.ToDouble(textBoxSex.Text);
            double Z3 = Convert.ToDouble(textBoxSuperman.Text);
            double Z4 = Convert.ToDouble(textBoxBusiness.Text);
            if ((Z1 + Z2 + Z3 + Z4 + trackBar1.Value) > 24)
            {
                button1.Enabled = false;
                textBoxOut.Text = "В сутках 24 часа!)";
            }
            else
            {
                button1.Enabled = true;
            }
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
