using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numeros = new int[50];
        int indice = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            ModalIngNumero modalIngNumero = new ModalIngNumero();
            
            for(int i = 0; i<10; i++)
            {
                modalIngNumero.ShowDialog();

                if (modalIngNumero.DialogResult == DialogResult.OK && indice < 50)
                {
                    int num = Convert.ToInt32(modalIngNumero.tbNumIng.Text);
                    numeros[indice] = num;
                    indice++;
                }
            }

        }

        private void btnModalListado_Click(object sender, EventArgs e)
        {
            ModalVistas modalVistas = new ModalVistas();
            for (int i = 0; i < indice; i++)
            {
                modalVistas.listBox1.Items.Add(numeros[i].ToString());
            }       
            modalVistas.ShowDialog();
        }

        private void btnModalPromedio_Click(object sender, EventArgs e)
        {
            ModalVistas modalVistas = new ModalVistas();
            modalVistas.listBox1.Items.Add($"Promedio {CalcPromedio(numeros):f2}");
            modalVistas.ShowDialog();
        }

        private double CalcPromedio(int[] vector)
        {
            double acum = 0, promedio;
            for (int i = 0; i < indice; i++)
            {
                acum += vector[i];
            }
            promedio = acum / indice;
            return promedio;
        }

        private void rbBinaria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSecuencial_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
