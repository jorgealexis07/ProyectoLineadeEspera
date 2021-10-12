using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineadeEspera_SimulacionExponencial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Colas x = new Colas();
        double n;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
            x = new Colas(Convert.ToInt16(n));
            MessageBox.Show("Cola Creada");
            int numInt;
            string numStr="";
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                double na;
                na = rnd.NextDouble();

                double Ei = (Math.Log(1 - na) * -int.Parse(Lambda.Text));
                
                x.agregar_cola(Ei);
                
                ListViewItem lista = new ListViewItem(Convert.ToString(i + 1));
                lista.SubItems.Add(Convert.ToString(na));
                
                lista.SubItems.Add(Convert.ToString(Ei));

                numStr = Convert.ToString(x.lacola[i]);
                numInt = int.Parse(numStr.Split('.')[0]);
                double dec = (x.lacola[i] - numInt)*60;
                int tr = Convert.ToInt32(dec);
                string Tr = Convert.ToString(numInt + "." + tr);
                double valorConvrt = Convert.ToDouble(Tr);
                listView1.Items.Add(Convert.ToString(valorConvrt));
                lista.SubItems.Add(Tr);
                listView3.Items.Add(lista);
                
            listView2.Items.Add(Convert.ToString(numInt));
            }
            MessageBox.Show("Valores agregados");
            Lambda.Clear();
            Lambda.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double na;
            na = rnd.NextDouble();
            double Ei = (Math.Log(1 - na) * -int.Parse(Lambda.Text));
            x.agregar_cola(Ei);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n;
            n = x.del_cola();
            if (n == -666)
            {
                MessageBox.Show("Cola sin valores");
            }
            else
            {
                MessageBox.Show("salio" + n);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            double X = 0;
            string numStr="";
            int numInt;
            listView2.Items.Clear();
            for (i = 0;i <= n - 1;i++) {
                X = X + x.lacola[i];
            }
            label5.Text = Convert.ToString(X);
            numStr = Convert.ToString(X);
            numInt = int.Parse(numStr.Split('.')[0]);
            double dec = (X - numInt) * 60;
            int tr = Convert.ToInt32(dec);
            label3.Text = Convert.ToString(numInt+ "´:" + tr+"´´");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listView3.Items.Clear();
        }
    }
}
