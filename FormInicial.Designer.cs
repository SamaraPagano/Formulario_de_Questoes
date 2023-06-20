namespace Trabalho
{
    partial class FormInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovaQuestao = new System.Windows.Forms.Button();
            this.btnQuestionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaQuestao
            // 
            this.btnNovaQuestao.Location = new System.Drawing.Point(29, 54);
            this.btnNovaQuestao.Name = "btnNovaQuestao";
            this.btnNovaQuestao.Size = new System.Drawing.Size(134, 49);
            this.btnNovaQuestao.TabIndex = 0;
            this.btnNovaQuestao.Text = "Inserir Nova questão";
            this.btnNovaQuestao.UseVisualStyleBackColor = true;
            this.btnNovaQuestao.Click += new System.EventHandler(this.btnNovaQuestao_Click);
            // 
            // btnQuestionario
            // 
            this.btnQuestionario.Location = new System.Drawing.Point(205, 54);
            this.btnQuestionario.Name = "btnQuestionario";
            this.btnQuestionario.Size = new System.Drawing.Size(134, 49);
            this.btnQuestionario.TabIndex = 1;
            this.btnQuestionario.Text = "Questionário";
            this.btnQuestionario.UseVisualStyleBackColor = true;
            this.btnQuestionario.Click += new System.EventHandler(this.btnQuestionario_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 166);
            this.Controls.Add(this.btnQuestionario);
            this.Controls.Add(this.btnNovaQuestao);
            this.Name = "FormInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovaQuestao;
        private System.Windows.Forms.Button btnQuestionario;
    }
}

