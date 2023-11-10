using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PBL.Telas
{
    public partial class consultar_registros : Form
    {
        Thread t1;

        public consultar_registros()
        {
            InitializeComponent();
        }

        // ABRIR JANELA
        private void abrirJanelaMenu(object obj)
        {
            Application.Run(new Form1());
        }


        // BOTAO MENU
        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanelaMenu);
            t1.Start();
        }
    }
}
