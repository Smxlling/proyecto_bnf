using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analizador
{
    public partial class Form1 : Form
    {
        List<string> reservadas = new List<string>();

        string cadena = " ";
        int tam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reservadas.Add("int");
            reservadas.Add("string");
            reservadas.Add("public");
            reservadas.Add("if");
            reservadas.Add("}");
            reservadas.Add("{");
            reservadas.Add("(");
            reservadas.Add(")");
            reservadas.Add("while");
        }

        public Boolean palabrasReservadas(String palabra)

        {




            for (int i = 0; i < reservadas.Count(); i++)
            {
                if (palabra == reservadas[i]) {



                    dgvInfo.Rows.Add("reservada", palabra);

                }
            }




            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean tokenFinalizado = false;
            int t = 0;
            char[] arreglo = txtEditor.Text.ToCharArray();
            string[] cadena = new string[t];
            List<String> sinta = new List<string>();


            string palabra = "";
            dgvInfo.Rows.Clear();
            dgvInfo.Refresh();
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == ' ')
                {
                    palabrasReservadas(palabra);

                    sinta.Add(palabra);

                    palabra = "";
                }
                else if (arreglo[i] == '(' || arreglo[i] == ')' || arreglo[i] == '}' || arreglo[i] == '{')
                {
                    sinta.Add(arreglo[i].ToString());
                }
                else
                {
                    palabra += arreglo[i];

                }

                
            }
            if (arreglo[arreglo.Length-1]!=';') {
                MessageBox.Show("Token no finalizado");
            }

            sinta.Add(palabra);
            palabrasReservadas(palabra);
            for(int i=0;i < arreglo.Length;i++)
            {
              
            }
            

        }

       


    }
}
