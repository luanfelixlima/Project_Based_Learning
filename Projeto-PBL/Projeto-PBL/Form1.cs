using Projeto_PBL.Telas;
using System.Threading;
using System.Xml.Serialization;

namespace Projeto_PBL
{
    public partial class Form1 : Form
    {

        Thread t1;

        // ABRIR JANELAS
        private void abrirJanela_Novos_Valores(object obj)
        {
            Application.Run(new novos_valores());
        }
        private void abrirJanela_Consultar_Registros(object obj)
        {
            Application.Run(new consultar_registros());
        }
        public Form1()
        {
            InitializeComponent();
        }
        // ABRIR JANELAS - INSERIR NOVOS VALORES
        private void button_novos_valores_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanela_Novos_Valores);
            t1.Start();
        }
        // ABRIR JANELAS - CONSULTAR REGISTROS
        private void button_consultar_registros_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanela_Consultar_Registros);
            t1.Start();
        }

        // JANELA - APAGAR DADOS
        private void button_apagar_dados_Click(object sender, EventArgs e)
        {
            dados_apagados tela = new dados_apagados();
            tela.ShowDialog();
        }

        // BOTÃO SAIR
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
