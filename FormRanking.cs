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
    public partial class FormRanking : Form
    {
        //Nome do arquivo para armazenar o ranking
        private string arquivoRanking = "ranking.txt";
        private List<Usuario> usuarios;

        public FormRanking()
        {
            InitializeComponent();
        }

        private void FormRanking_Load(object sender, EventArgs e)
        {
            CarregarRanking();
        }
        private void CarregarRanking()
        {
            usuarios = new List<Usuario>();

            try
            {
                using (StreamReader sr = new StreamReader(arquivoRanking))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] partes = line.Split(':');

                        if(partes.Length == 2)
                        {
                            string nome = partes[0];
                            int pontos = int.Parse(partes[1]);

                            Usuario usuario = new Usuario(nome, pontos);
                            usuarios.Add(usuario);
                        }
                    }
                }
                //Classificar os usuários por pontos em ordem decrescente
                usuarios.Sort((u1, u2) => u2.Pontos.CompareTo(u1.Pontos));

                //Exibir o ranking no DataGridView
                dataGridView1.Rows.Clear();

                foreach(Usuario usuario in usuarios)
                {
                    dataGridView1.Rows.Add(usuario.Nome, usuario.Pontos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Occoreu um erro ao carregar o rankin:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    public class Usuario
    {
        public string Nome { get;set; }
        public int Pontos { get;set; }

        public Usuario(string nome, int pontos)
        {
            Nome = nome;
            Pontos = pontos;
        }

        internal void Add(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
