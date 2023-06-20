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
    public partial class FormQuestionário : Form
    {
        //Nome do arquivo onde as questões estão armazenadas
        private string arquivoQuestoes = "questoes.txt";
        private int tempoPorMateria = 20; //tempo em minutos por matéria
        private Timer timer;
        private int tempoRestante;

        public FormQuestionário()
        {
            InitializeComponent();
        }

        private void FormQuestionário_Load(object sender, EventArgs e)
        {
            //Preencher a ComboBox com as opções de máteria
            cmbDisciplina.Items.Add("Banco de dados");
            cmbDisciplina.Items.Add("Biologia");
            cmbDisciplina.Items.Add("Ed.Física");
            cmbDisciplina.Items.Add("Eng.software");
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

        private void cmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carregar a primeira questão da matéria selecionada
            CarregarQuestao();

            //Iniciar a contagem de tempo
            IniciarContagemTempo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Carregar a próxima questão
            CarregarQuestao();
        }

        private void CarregarQuestao()
        {
            string materia = cmbDisciplina.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(materia))
                return;

            try
            {
                using (StreamReader sr = new StreamReader(arquivoQuestoes))
                {
                    string line;
                    bool encontrouQuestao = false;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == materia)
                        {
                            //Encontrou uma questão da máteria selecionada
                            encontrouQuestao = true;
                            txtQuestao.Text = sr.ReadLine();
                            rdbA.Text = sr.ReadLine();
                            rdbB.Text = sr.ReadLine();
                            rdbC.Text = sr.ReadLine();
                            rdbD.Text = sr.ReadLine();
                            rdbE.Text = sr.ReadLine();
                            break;
                           
                        }
                    }

                    if (!encontrouQuestao)
                    {
                        MessageBox.Show("Não há mais questões disponíveis para a matéria selecionada.", "Fim das questões", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        PararContagemTempo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar a questão" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LimparCampos()
        {
            txtQuestao.Text = "";
            rdbA.Text = "";
            rdbB.Text = "";
            rdbC.Text = "";
            rdbD.Text = "";
            rdbE.Text = "";
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
            rdbE.Checked = false;
            
        }
        private void IniciarContagemTempo()
        {
            tempoRestante = tempoPorMateria;
            timer = new Timer();
            timer.Interval = 1000; //1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void PararContagemTempo()
        {
            timer.Stop();
            timer.Dispose();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tempoRestante--;
            if (tempoRestante == 0)
            {
                MessageBox.Show("O tempo para a matéria selecionada esgotou.", "Tempo esgotado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                PararContagemTempo();
            }
        }
    }
}
