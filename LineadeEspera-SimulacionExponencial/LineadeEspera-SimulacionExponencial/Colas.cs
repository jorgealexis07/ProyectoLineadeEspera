using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineadeEspera_SimulacionExponencial
{
    class Colas
    {
            private int frente;
            private int atras;
            public double[] lacola;
            private int maximo;

            public Colas() { }
            public Colas(int max)
            {
                frente = -1;
                atras = -1;
                maximo = max;
                lacola = new double[maximo];
            }

            public Boolean cola_llena()
            {
                if (atras == maximo - 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public Boolean cola_vacia()
            {
                if (frente == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void agregar_cola(double Ei)
            {
                if (cola_llena() == true)
                {
                    MessageBox.Show("Cola llena");
                }
                else
                {
                    atras++;
                    lacola[atras] = Ei;
                    if (atras == 0)
                    {
                        frente = 0;
                    }
                }
            }

            public int del_cola()
            {
                int n = -666;
                if (cola_vacia() == true)
                {
                    MessageBox.Show("Cola vacia");
                }

                else
                {
                    n = Convert.ToInt32( lacola[frente]);
                    if (frente == atras)
                    {
                        frente = -1;
                        atras = -1;
                    }
                    else
                    {
                        frente++;
                    }
                }
                return n;
            }
        public void SumaTx()
        {

        }
    }
}
