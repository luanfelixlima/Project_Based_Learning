namespace Projeto_PBL.Telas
{
    partial class consultar_registros
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
            label1 = new Label();
            button_sair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.BlanchedAlmond;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 0;
            label1.Text = "Valores já registrados";
            // 
            // button_sair
            // 
            button_sair.BackColor = Color.PaleGoldenrod;
            button_sair.Cursor = Cursors.Hand;
            button_sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_sair.Location = new Point(12, 398);
            button_sair.Name = "button_sair";
            button_sair.Size = new Size(75, 23);
            button_sair.TabIndex = 1;
            button_sair.Text = "🠔 MENU";
            button_sair.UseVisualStyleBackColor = false;
            button_sair.Click += button_sair_Click;
            // 
            // consultar_registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(625, 433);
            Controls.Add(button_sair);
            Controls.Add(label1);
            Name = "consultar_registros";
            Text = "PBL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_sair;
    }
}