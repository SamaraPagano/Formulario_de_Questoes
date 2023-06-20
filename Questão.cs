using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Questão
    {
        public string Materia { get; set; }
        public string Pergunta { get; set; }
        public string RespostaCorreta { get; set; }
        public int Pontuacao { get; set; }

        public Questão(string materia,string pergunta, string respostaCorreta, int pontuacao)
        {
            Materia = materia;
            Pergunta = pergunta;
            RespostaCorreta = respostaCorreta;
            Pontuacao = pontuacao;
        }
    }
}
