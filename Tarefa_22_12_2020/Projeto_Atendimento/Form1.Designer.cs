namespace Projeto_Atendimento
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.lblSenhas = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSelecionaGuiche = new System.Windows.Forms.TextBox();
            this.btnChamar = new System.Windows.Forms.Button();
            this.lblGuiches = new System.Windows.Forms.ListBox();
            this.btnListarAtendimentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(80, 25);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(89, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.Location = new System.Drawing.Point(62, 244);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(132, 27);
            this.btnListarSenhas.TabIndex = 1;
            this.btnListarSenhas.Text = "Listar Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            // 
            // lblSenhas
            // 
            this.lblSenhas.FormattingEnabled = true;
            this.lblSenhas.ItemHeight = 15;
            this.lblSenhas.Location = new System.Drawing.Point(12, 66);
            this.lblSenhas.Name = "lblSenhas";
            this.lblSenhas.Size = new System.Drawing.Size(253, 169);
            this.lblSenhas.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(299, 181);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantidades de Guichês";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContador.Location = new System.Drawing.Point(313, 124);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(45, 54);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Guichê";
            // 
            // txtSelecionaGuiche
            // 
            this.txtSelecionaGuiche.Location = new System.Drawing.Point(487, 26);
            this.txtSelecionaGuiche.Name = "txtSelecionaGuiche";
            this.txtSelecionaGuiche.Size = new System.Drawing.Size(100, 23);
            this.txtSelecionaGuiche.TabIndex = 7;
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(628, 26);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(75, 23);
            this.btnChamar.TabIndex = 8;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            // 
            // lblGuiches
            // 
            this.lblGuiches.FormattingEnabled = true;
            this.lblGuiches.ItemHeight = 15;
            this.lblGuiches.Location = new System.Drawing.Point(425, 66);
            this.lblGuiches.Name = "lblGuiches";
            this.lblGuiches.Size = new System.Drawing.Size(302, 169);
            this.lblGuiches.TabIndex = 9;
            // 
            // btnListarAtendimentos
            // 
            this.btnListarAtendimentos.Location = new System.Drawing.Point(487, 250);
            this.btnListarAtendimentos.Name = "btnListarAtendimentos";
            this.btnListarAtendimentos.Size = new System.Drawing.Size(172, 23);
            this.btnListarAtendimentos.TabIndex = 10;
            this.btnListarAtendimentos.Text = "Lista de Atendimentos";
            this.btnListarAtendimentos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 287);
            this.Controls.Add(this.btnListarAtendimentos);
            this.Controls.Add(this.lblGuiches);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.txtSelecionaGuiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblSenhas);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.btnGerar);
            this.Name = "Form1";
            this.Text = "Guichês";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.ListBox lblSenhas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSelecionaGuiche;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.ListBox lblGuiches;
        private System.Windows.Forms.Button btnListarAtendimentos;
    }
}

