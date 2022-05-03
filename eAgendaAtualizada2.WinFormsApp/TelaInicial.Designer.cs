namespace EAgenda.WinApp
{
    partial class TelaInicial
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
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTarefas
            // 
            this.btnTarefas.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTarefas.Location = new System.Drawing.Point(40, 47);
            this.btnTarefas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(119, 40);
            this.btnTarefas.TabIndex = 1;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContatos.Location = new System.Drawing.Point(40, 95);
            this.btnContatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(119, 36);
            this.btnContatos.TabIndex = 2;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCompromissos.Location = new System.Drawing.Point(40, 139);
            this.btnCompromissos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(119, 42);
            this.btnCompromissos.TabIndex = 3;
            this.btnCompromissos.Text = "Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deseja Cadastrar:";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompromissos);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.btnTarefas);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnCompromissos;
        private System.Windows.Forms.Label label1;
    }
}
