namespace Projeto_PBL.Telas
{
    partial class dados_apagados
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
            label_dados_apagados = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_dados_apagados
            // 
            label_dados_apagados.AutoSize = true;
            label_dados_apagados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_dados_apagados.Location = new Point(12, 37);
            label_dados_apagados.Name = "label_dados_apagados";
            label_dados_apagados.Size = new Size(244, 21);
            label_dados_apagados.TabIndex = 0;
            label_dados_apagados.Text = "Dados Apagados com Sucesso!";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(90, 85);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dados_apagados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(261, 120);
            Controls.Add(button1);
            Controls.Add(label_dados_apagados);
            Cursor = Cursors.Hand;
            ForeColor = Color.Black;
            Name = "dados_apagados";
            Text = "dados_apagados";
            Load += dados_apagados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_dados_apagados;
        private Button button1;
    }
}