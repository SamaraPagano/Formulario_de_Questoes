using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class FormNovaQuestão : Form
    {
        //Nome do arquivo para rmazernar as questões
        private string arquivoQuestoes = "questoes.txt";
        public FormNovaQuestão()
        {
            InitializeComponent();
        }

        private void FormQuestao_Load(object sender, EventArgs e)
        {
            //Preencher a ComboBox com as opções de matéria
            cmbDisciplina.Items.Add("Banco de dados");
            cmbDisciplina.Items.Add("Biologia");
            cmbDisciplina.Items.Add("Ed.Física");
            cmbDisciplina.Items.Add("Eng.Sotfware");
            cmbDisciplina.Items.Add("Desenho");
            cmbDisciplina.Items.Add("Filosofia");
            cmbDisciplina.Items.Add("Física");
            cmbDisciplina.Items.Add("Geografia");
            cmbDisciplina.Items.Add("História");
            cmbDisciplina.Items.Add("ICC");
            cmbDisciplina.Items.Add("inglês");
            cmbDisciplina.Items.Add("Lingaugem de Programação");
            cmbDisciplina.Items.Add("Literatura");
            cmbDisciplina.Items.Add("Matemática");
            cmbDisciplina.Items.Add("Português");
            cmbDisciplina.Items.Add("Redação");
            cmbDisciplina.Items.Add("Sociologia");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string materia = cmbDisciplina.SelectedItem.ToString();
            string questao = txtEnunciado.Text;

            if (string.IsNullOrWhiteSpace(questao) || cmbDisciplina.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //Escrever a nova questão no arquivo
                using (StreamWriter sw = new StreamWriter(arquivoQuestoes, true))
                {
                    sw.WriteLine(materia);
                    sw.WriteLine(questao);
                    //Adicionar uma linha em branco para separar as questões
                    sw.WriteLine();
                }
                MessageBox.Show("Questão adicionada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpar os campos após adicionar a questão
                cmbDisciplina.SelectedIndex = -1;
                txtEnunciado.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao adicionar a questão:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
