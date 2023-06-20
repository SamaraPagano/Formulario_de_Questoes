using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Ranking
    {
        private List<Usuario> usuarios;

        public Ranking()
        {
            usuarios = new List<Usuario>();
        }

        public void AdicionarUsuario(string nome, int pontos)
        {
            Usuario usuario = new Usuario(nome, pontos);
            usuario.Add(usuario);
        }

        public List<Usuario> ObterUsuariosOrdenadosPorPontos()
        {
            List<Usuario> usuariosOrdenados = usuarios.OrderByDescending ( u => u.Pontos).ToList();
            return usuariosOrdenados;
        }
    }
}

