using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show
            (
                "Mensagem",
                "Título",
                MessageBoxButtons.OKCancel

            OK  CANCELAR

             );*/

            /*MessageBox.Show
            (
                "Mensagem",
                "Título",
                MessageBoxButtons.AbortRetryIgnore

                ANULAR REPETIR IGNORAR

             );*/

            /*MessageBox.Show
            (
                "Mensagem",
                "Título",
                MessageBoxButtons.YesNoCancel

                SIM NÃO CANCELAR

             );*/

            /*MessageBox.Show
            (
                "Mensagem",
                "Título",
                MessageBoxButtons.YesNo

                SIM NÃO
             );*/

            /* MessageBox.Show
             (
                 "Mensagem",
                 "Título",
                 MessageBoxButtons.RetryCancel

                 REPETIR CANCELAR

              );*/

            /* MessageBox.Show
             (
                 "Mensagem",
                 "Título",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error

                 Mensagem de ERRO
                 OK

              );*/

            /* MessageBox.Show
             (
                 "Mensagem",
                 "Título",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Question

              //Mensagem de Pergunta
              //OK

              );*/

            /*MessageBox.Show
            (
                "Mensagem",
                "Título",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning

             //Mensagem de Alerta
             //OK

             );*/

            MessageBox.Show
            (
                "Mensagem",
                "Título",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information

             //Mensagem de Informação
             //OK

             );

            MessageBox.Show
            (
                "Mensagem",
                "Título",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button3,
                MessageBoxOptions.RightAlign

                //Mensagem de ERRO
                //OK

             );
        }
    }
}
