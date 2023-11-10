using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PBL.Telas
{
    public partial class novos_valores : Form
    {
        string unidade_velocidade = " m/s";
        Thread t1;


        // ABRIR JANELA

        private void abrirJanelaMenu(object obj)
        {
            Application.Run(new Form1());
        }

        public novos_valores()
        {
            InitializeComponent();
        }

        // BOTÃO PARA VOLTAR PARA O MENU
        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanelaMenu);
            t1.Start();
        }


        // BOTÃO CALCULAR TRAJETÓRIA
        private void button_calcular_Click(object sender, EventArgs e)
        {
            button_calcular.BackColor = label_status.BackColor;
            // SE STATUS ESTIVER OK
            if (button_calcular.BackColor == Color.Green)
            {
            }
        }

        // BOTÃO CALCULAR VELOCIDADE
        private void button_calcular_velocidade_Click(object sender, EventArgs e)
        {
            // SE ANGULO PREENCHIDO
            if (textBox_angulo.Text != "")
            {
                label_status.Text = "Status: ok";
                label_status.BackColor = Color.Green;
                button_calcular.BackColor = Color.Green;

                label_velocidade.Text = textBox_angulo.Text + unidade_velocidade;
            }
            // SE ANGULO NÃO PREENCHIDO
            else if (textBox_angulo.Text == "")
            {
                label_status.Text = "Status: Faltando Valores";
                label_status.BackColor = Color.Yellow;
                button_calcular.BackColor = Color.Yellow;
            }
            // SE ANGULO NÃO É POSSÍVEL ATINGIR O ALVO
            else if (false)
            {

            }
        }
    }
}
