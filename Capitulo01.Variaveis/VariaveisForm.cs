using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo01.Variaveis
{
    public partial class VariaveisForm : MetroFramework.Forms.MetroForm
    {
        int _x = 32;
        int _w = 45;
        int _y = 16;
        int _z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void ResultadoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void aritimeticaSubMenu_Click(object sender, EventArgs e)
        {

            //string nomeCliente = "Manuel";
            //bool habilitado = false;

            //DateTime date = new DateTime();
            //var @class = " 2 Ano";

            //dados considerados tipos primitivos
            int a = 23;
            int c = 30;
            int d = 34;

            ResultadoListBox.Items.Add("O Resultado do A é " + a).ToString();
            NovaLinha();

            NovaLinha();
            //concatenando as Variaveis
            //Duplicando o (-) para 500
            NovaLinha();

            ResultadoListBox.Items.Add($"O Resultado do D é {d} ");
            NovaLinha();

            //somando as Variaveis 

            ResultadoListBox.Items.Add("C * D =" + (c * d));
            ResultadoListBox.Items.Add("C % A =" + (c % a));
            ResultadoListBox.Items.Add("D + A =" + (a + d));
            ResultadoListBox.Items.Add("C - D =" + (c - d));
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            ResultadoListBox.Items.Add("X =" + x);
            //x = x - 3; ou 
            x -= 3;
            ResultadoListBox.Items.Add("X  =" + x);
        }

        private void operadoresIncrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int incremental;
            incremental = 5;
            ResultadoListBox.Items.Add("Pre-incremental");
            NovaLinha();

            ResultadoListBox.Items.Add("incremental = " + incremental);
            ResultadoListBox.Items.Add("2 + ++ incremental = " + (2 + ++incremental));
            ResultadoListBox.Items.Add("2 Pos Incremental = " + (+incremental));
            NovaLinha();

            incremental = 5;
            ResultadoListBox.Items.Add("Pos-incremental");
            NovaLinha();
            ResultadoListBox.Items.Add("incremental = " + incremental);
            ResultadoListBox.Items.Add("2 + ++ incremental = " + (2 + incremental++));
            ResultadoListBox.Items.Add("2 Pos Incremental = " + (+incremental));
            NovaLinha();
        }

        public void NovaLinha()
        {
            ResultadoListBox.Items.Add(new string('-', 500));

        }

        private void boolenasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVariaveis();

        }

        //para criar um metado automatico, basta seleceionar o que precisas inserir ou criar o metodo, com os atalhos do teclado ctr+r+m ele
        //    criar o metdo para voce so basta renomear o metodo

        private void MostrarVariaveis()
        {
            ResultadoListBox.Items.Add("valor de X = " + _x);
            ResultadoListBox.Items.Add("valor de w = " + _w);
            ResultadoListBox.Items.Add("valor de Y = " + _y);
            ResultadoListBox.Items.Add("valor de Z " + _z);
            NovaLinha();

            ResultadoListBox.Items.Add("W <= X + " + (_w <= _x));
            ResultadoListBox.Items.Add("X == Z + + " + (_z == _x));
            ResultadoListBox.Items.Add("X != Z + + " + (_z != _x));
            NovaLinha();
        }
         
        private void logícaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultadoListBox.Items.Add(" Verdadeiro ou Falso");
            NovaLinha();

            MostrarVariaveis();
            ResultadoListBox.Items.Add("_W <= _X || (ou) _Y == 16 " +(_w <=_x || _y == 16) );
            ResultadoListBox.Items.Add("_X == _Z  &&  _Z != _X  " + (_x <= _z && _z != _x));
            ResultadoListBox.Items.Add("!(_Y > _W) = " + (!(_y > _w)));

        }

        

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;
            ano = 2014;
            ResultadoListBox.Items.Add("Ano" + ano);
            //concatenar string if ternario
            ResultadoListBox.Items.Add(string.Format ("O Ano {0} é Bisexto? {1}.",ano,
               DateTime.IsLeapYear(2014)? "SIM":"NÂO"));

            //if (ano% 4 == 0)
            //
            //    MessageBox.Show("O Ano é Bisexto");
            //}
            //else
            //{
            //    MessageBox.Show("O Ano não é Bisexto");
            //}

            NovaLinha();
             ano = 2016;
            ResultadoListBox.Items.Add("Ano" + ano);
            //concatenar string if ternario
            ResultadoListBox.Items.Add(string.Format("O Ano {0} é Bisexto? {1}.", ano,
                               DateTime.IsLeapYear(2016) ? "SIM" : "NÂO"));

            //ano % 4 == 0 ? "SIM" : "NÂO"));
        }
    }
}
