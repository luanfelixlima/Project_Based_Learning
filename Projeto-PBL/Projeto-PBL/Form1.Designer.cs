namespace Projeto_PBL
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
            label_menu_principal = new Label();
            button_novos_valores = new Button();
            button_consultar_registros = new Button();
            button_apagar_dados = new Button();
            button_exit = new Button();
            label1 = new Label();
            label2 = new Label();
            button_ajuda = new Button();
            SuspendLayout();
            // 
            // label_menu_principal
            // 
            label_menu_principal.AutoSize = true;
            label_menu_principal.BackColor = Color.Gray;
            label_menu_principal.BorderStyle = BorderStyle.Fixed3D;
            label_menu_principal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_menu_principal.ForeColor = SystemColors.ButtonHighlight;
            label_menu_principal.Location = new Point(24, 19);
            label_menu_principal.Name = "label_menu_principal";
            label_menu_principal.Size = new Size(715, 47);
            label_menu_principal.TabIndex = 0;
            label_menu_principal.Text = "Calcular Trajetória de Projetil - Menu Principal";
            // 
            // button_novos_valores
            // 
            button_novos_valores.BackColor = Color.LightSteelBlue;
            button_novos_valores.Cursor = Cursors.Hand;
            button_novos_valores.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_novos_valores.Location = new Point(241, 108);
            button_novos_valores.Name = "button_novos_valores";
            button_novos_valores.Size = new Size(246, 64);
            button_novos_valores.TabIndex = 1;
            button_novos_valores.Text = "Inserir novos Valores";
            button_novos_valores.UseVisualStyleBackColor = false;
            button_novos_valores.Click += button_novos_valores_Click;
            // 
            // button_consultar_registros
            // 
            button_consultar_registros.BackColor = Color.LightSteelBlue;
            button_consultar_registros.Cursor = Cursors.Hand;
            button_consultar_registros.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_consultar_registros.Location = new Point(241, 209);
            button_consultar_registros.Name = "button_consultar_registros";
            button_consultar_registros.Size = new Size(246, 64);
            button_consultar_registros.TabIndex = 2;
            button_consultar_registros.Text = "Consultar Registros";
            button_consultar_registros.UseVisualStyleBackColor = false;
            button_consultar_registros.Click += button_consultar_registros_Click;
            // 
            // button_apagar_dados
            // 
            button_apagar_dados.BackColor = Color.LightSteelBlue;
            button_apagar_dados.Cursor = Cursors.Hand;
            button_apagar_dados.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_apagar_dados.Location = new Point(241, 306);
            button_apagar_dados.Name = "button_apagar_dados";
            button_apagar_dados.Size = new Size(246, 64);
            button_apagar_dados.TabIndex = 3;
            button_apagar_dados.Text = "Apagar dados da Base";
            button_apagar_dados.UseVisualStyleBackColor = false;
            button_apagar_dados.Click += button_apagar_dados_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.IndianRed;
            button_exit.Cursor = Cursors.Hand;
            button_exit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.ForeColor = SystemColors.ButtonHighlight;
            button_exit.Location = new Point(12, 394);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(150, 44);
            button_exit.TabIndex = 4;
            button_exit.Text = "Sair";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(529, 426);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 426);
            label2.Name = "label2";
            label2.Size = new Size(233, 15);
            label2.TabIndex = 6;
            label2.Text = "Faculdade Engenheiro Salvador Arena 2023";
            // 
            // button_ajuda
            // 
            button_ajuda.BackColor = Color.LightSteelBlue;
            button_ajuda.Cursor = Cursors.Hand;
            button_ajuda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_ajuda.Location = new Point(329, 394);
            button_ajuda.Name = "button_ajuda";
            button_ajuda.Size = new Size(75, 23);
            button_ajuda.TabIndex = 7;
            button_ajuda.Text = "Ajuda";
            button_ajuda.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(762, 450);
            Controls.Add(button_ajuda);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_exit);
            Controls.Add(button_apagar_dados);
            Controls.Add(button_consultar_registros);
            Controls.Add(button_novos_valores);
            Controls.Add(label_menu_principal);
            Name = "Form1";
            Text = "PBL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_menu_principal;
        private Button button_novos_valores;
        private Button button_consultar_registros;
        private Button button_apagar_dados;
        private Button button_exit;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button button_ajuda;
    }
}