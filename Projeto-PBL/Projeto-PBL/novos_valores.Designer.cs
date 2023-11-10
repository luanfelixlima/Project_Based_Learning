namespace Projeto_PBL.Telas
{
    partial class novos_valores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox_angulo = new TextBox();
            label1 = new Label();
            button_calcular_velocidade = new Button();
            label_status = new Label();
            button_calcular = new Button();
            label2 = new Label();
            label_velocidade = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 372);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "🠔 MENU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_menu_Click;
            // 
            // textBox_angulo
            // 
            textBox_angulo.BackColor = SystemColors.Menu;
            textBox_angulo.Cursor = Cursors.IBeam;
            textBox_angulo.Location = new Point(139, 37);
            textBox_angulo.Name = "textBox_angulo";
            textBox_angulo.Size = new Size(100, 23);
            textBox_angulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 2;
            label1.Text = "Preencher Ângulo";
            // 
            // button_calcular_velocidade
            // 
            button_calcular_velocidade.BackColor = Color.Moccasin;
            button_calcular_velocidade.Cursor = Cursors.Hand;
            button_calcular_velocidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_calcular_velocidade.Location = new Point(74, 66);
            button_calcular_velocidade.Name = "button_calcular_velocidade";
            button_calcular_velocidade.Size = new Size(233, 29);
            button_calcular_velocidade.TabIndex = 3;
            button_calcular_velocidade.Text = "Calcular Velocidade Ideal";
            button_calcular_velocidade.UseVisualStyleBackColor = false;
            button_calcular_velocidade.Click += button_calcular_velocidade_Click;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.BackColor = Color.Yellow;
            label_status.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_status.Location = new Point(116, 259);
            label_status.Name = "label_status";
            label_status.Size = new Size(157, 17);
            label_status.TabIndex = 4;
            label_status.Text = "Status: Faltando Valores";
            // 
            // button_calcular
            // 
            button_calcular.BackColor = Color.Yellow;
            button_calcular.Cursor = Cursors.Hand;
            button_calcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_calcular.Location = new Point(21, 293);
            button_calcular.Name = "button_calcular";
            button_calcular.Size = new Size(346, 60);
            button_calcular.TabIndex = 5;
            button_calcular.Text = "Calcular Trajetória";
            button_calcular.UseVisualStyleBackColor = false;
            button_calcular.Click += button_calcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(116, 173);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 6;
            label2.Text = "Velocidade Ideal";
            // 
            // label_velocidade
            // 
            label_velocidade.AutoSize = true;
            label_velocidade.BackColor = Color.White;
            label_velocidade.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_velocidade.Location = new Point(162, 207);
            label_velocidade.Name = "label_velocidade";
            label_velocidade.Size = new Size(43, 17);
            label_velocidade.TabIndex = 7;
            label_velocidade.Text = "0 m/s";
            // 
            // novos_valores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(390, 407);
            Controls.Add(label_velocidade);
            Controls.Add(label2);
            Controls.Add(button_calcular);
            Controls.Add(label_status);
            Controls.Add(button_calcular_velocidade);
            Controls.Add(label1);
            Controls.Add(textBox_angulo);
            Controls.Add(button1);
            Name = "novos_valores";
            Text = "PBL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox_angulo;
        private Label label1;
        private Button button_calcular_velocidade;
        private Label label_status;
        private Button button_calcular;
        private Label label2;
        private Label label_velocidade;
    }
}