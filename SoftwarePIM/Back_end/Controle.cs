using SoftwarePIM.Back_End;
using SoftwarePIM.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePIM.Back_end
{
    internal class Controle
    {
        private char alternativa;
        private char numero_pergunta;

        public Controle(char alternativa)

        {
            this.alternativa = alternativa;

            Executar(alternativa);
        }
        public Controle(string nome, string idade)

        {
            

        }

        private void Executar(char alternativa){

            Questionario questionario = new Questionario(alternativa);
            Banco_de_dados bd = new Banco_de_dados(questionario.Muitoruim,questionario.Ruim, questionario.Regular,questionario.Bom,questionario.Muitobom);
                  
        }
        private void Executar(string nome,string idade)
        {

            Validacao validacao = new Validacao(nome,idade);

        }
    }
}
