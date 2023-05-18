using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menssagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult  RESP;
            RESP = MessageBox.Show
            (
                "Você é honesto?",
                "Uma pergunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
             );
            if (RESP == DialogResult.Yes)
                MessageBox.Show
                (
                    "Parabéns!!!",
                   "Respondeu SIM",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                 );
            else
                MessageBox.Show
                (
                    "Seu Pilantra!!!",
                    "Respondeu Não",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                 );
        }
    }
}
