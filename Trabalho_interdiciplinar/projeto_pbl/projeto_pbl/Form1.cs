using System.Security.Cryptography.X509Certificates;

namespace projeto_pbl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CLICK CALCULAR VELOCIDADE IDEAL
        private void button_calcular_velocidade_click(object sender, EventArgs e)
        {
            double angulo_teta;
            try
            {
                angulo_teta = Double.Parse(textBox_angulo.Text);
                velocidade_ideal.Text = $"{angulo_teta}" + " m/s";
                error_label.Text = "Ok";
                error_label.BackColor = Color.Green;
            }
            catch 
            {
                error_label.Text = "Error";
                error_label.BackColor = Color.Red;
            }
            
        }

        // CLICK CALCUALR TRAJETÓRIA
        private void button_calcular_all_Click(object sender, EventArgs e)
        {
            if (velocidade_ideal.Text == "0 m/s")
            {
                error_label.Text = "Error";
                error_label.BackColor = Color.Red;
            }
            else
            {
                error_label.Text = "Ok";
                error_label.BackColor = Color.Green;
            }

        }
    }
}
