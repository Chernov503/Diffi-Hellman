using System;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger a = int.Parse(AlicePrivate.Text);
            BigInteger g = int.Parse(GroundNumber.Text);
            BigInteger p = int.Parse(SimpleNumber.Text);
            BigInteger alicePublic = BigInteger.ModPow(g,(int)a,p);
            AlicePublic.Text = alicePublic.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BigInteger a = int.Parse(BobPrivate.Text);
            BigInteger g = int.Parse(GroundNumber.Text);
            BigInteger p = int.Parse(SimpleNumber.Text);
            BigInteger bobPublic = BigInteger.ModPow(g, (int)a, p);
            BobPublic.Text = bobPublic.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BigInteger B = int.Parse(BobPublic.Text); // Публичный ключ Боба
            BigInteger A = int.Parse(AlicePublic.Text); // Публичный ключ Алисы
            BigInteger a = int.Parse(AlicePrivate.Text); // Приватный ключ Алисы
            BigInteger b = int.Parse(BobPrivate.Text); // Приватный ключ Боба
            BigInteger p = int.Parse(SimpleNumber.Text); //Общее простое число

            BigInteger aliceSecret = BigInteger.ModPow(B, (int)a, p);
            BigInteger bobSecret = BigInteger.ModPow(A, (int)b, p);

            AliceSecret.Text = aliceSecret.ToString();
            BobSecret.Text = bobSecret.ToString();

        }
    }
}
