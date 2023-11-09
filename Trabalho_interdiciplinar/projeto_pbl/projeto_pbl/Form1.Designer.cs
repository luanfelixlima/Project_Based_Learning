namespace projeto_pbl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_calcular_all = new Button();
            textBox_angulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_calcular_velocidade = new Button();
            velocidade_ideal = new Label();
            error_label = new Label();
            SuspendLayout();
            // 
            // button_calcular_all
            // 
            button_calcular_all.BackColor = Color.Transparent;
            button_calcular_all.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_calcular_all.ForeColor = SystemColors.ActiveCaptionText;
            button_calcular_all.Location = new Point(44, 222);
            button_calcular_all.Name = "button_calcular_all";
            button_calcular_all.Size = new Size(280, 49);
            button_calcular_all.TabIndex = 0;
            button_calcular_all.Text = "Calcular Trajetória";
            button_calcular_all.UseVisualStyleBackColor = false;
            button_calcular_all.Click += button_calcular_all_Click;
            // 
            // textBox_angulo
            // 
            textBox_angulo.BackColor = SystemColors.ButtonFace;
            textBox_angulo.Location = new Point(219, 58);
            textBox_angulo.Name = "textBox_angulo";
            textBox_angulo.Size = new Size(105, 23);
            textBox_angulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(240, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 3;
            label1.Text = "Ângulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 35);
            label2.Name = "label2";
            label2.Size = new Size(128, 17);
            label2.TabIndex = 4;
            label2.Text = "Velocidade ideal";
            // 
            // button_calcular_velocidade
            // 
            button_calcular_velocidade.BackColor = Color.Transparent;
            button_calcular_velocidade.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_calcular_velocidade.ForeColor = Color.Black;
            button_calcular_velocidade.Location = new Point(84, 100);
            button_calcular_velocidade.Name = "button_calcular_velocidade";
            button_calcular_velocidade.Size = new Size(186, 25);
            button_calcular_velocidade.TabIndex = 5;
            button_calcular_velocidade.Text = "Calcular velocidade ideal";
            button_calcular_velocidade.UseVisualStyleBackColor = false;
            button_calcular_velocidade.Click += button_calcular_velocidade_click;
            // 
            // velocidade_ideal
            // 
            velocidade_ideal.AutoSize = true;
            velocidade_ideal.BackColor = Color.SeaShell;
            velocidade_ideal.BorderStyle = BorderStyle.FixedSingle;
            velocidade_ideal.Location = new Point(67, 61);
            velocidade_ideal.Name = "velocidade_ideal";
            velocidade_ideal.Size = new Size(39, 17);
            velocidade_ideal.TabIndex = 6;
            velocidade_ideal.Text = "0 m/s";
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.BackColor = Color.Red;
            error_label.Location = new Point(44, 191);
            error_label.Name = "error_label";
            error_label.Size = new Size(0, 15);
            error_label.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(357, 319);
            Controls.Add(error_label);
            Controls.Add(velocidade_ideal);
            Controls.Add(button_calcular_velocidade);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_angulo);
            Controls.Add(button_calcular_all);
            Name = "Form1";
            Text = "Projeto PBL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_calcular_all;
        private TextBox textBox_angulo;
        private Label label1;
        private Label label2;
        private Button button_calcular_velocidade;
        private Label velocidade_ideal;
        private Label error_label;
    }
}
