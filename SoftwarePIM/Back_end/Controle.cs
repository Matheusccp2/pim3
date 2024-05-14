using SoftwarePIM.Back_End;
using SoftwarePIM.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePIM.Back_end

{
    internal class Controle : Abspropriedades
    {




        public Controle(int alternativa, int numero_pergunta)

        {
            this.alternativa = alternativa;
            this.numero_pergunta = numero_pergunta;
            Questionario questionario = new Questionario(alternativa, numero_pergunta);

            this.muito_ruim = questionario.Muitoruim;
            this.ruim = questionario.Ruim;
            this.regular = questionario.Regular;
            this.bom = questionario.Bom;
            this.muito_bom = questionario.Muitobom;

            Executar_questionario();
        }

        public Controle(string nome, string idade)

        {
            this.nome = nome;
            this.idade = idade;

        }

        private void Executar(){
          
            
        }

        private void Executar_questionario(){

           
            Relatorio relatorio = new Relatorio(this.muito_ruim, this.ruim, this.regular, this.bom, this.muito_bom);
            

                  
        }

        private void Executar(string nome,string idade)

        {
            Validacao validacao = new Validacao(nome,idade);


        }
        public int Alternativa { get => alternativa; }
        public int Numero_pergunta { get => numero_pergunta; }
    }
}

