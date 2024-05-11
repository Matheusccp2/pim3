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
        private int alternativa;
        private int numero_pergunta;
        private int muitoruim;
        private int ruim;
        private int regular;
        private int bom;
        private int muitobom;

        

        public Controle(int alternativa, int numero_pergunta)

        {
            this.alternativa = alternativa;
            this.numero_pergunta = numero_pergunta;

            Executar_questionario();
        }
        public Controle() { 
        
        }
        public Controle(string nome, string idade)

        {
            

        }

        private void Executar_questionario(){

            if (Numero_pergunta <= 5)
            {
                Questionario questionario = new Questionario(Alternativa,Numero_pergunta);
                this.muitoruim = questionario.Muitoruim;
                this.ruim = questionario.Ruim;
                this.regular = questionario.Regular;
                this.bom = questionario.Bom;
                this.muitoruim = questionario.Muitobom;
                Relatorio relatorio = new Relatorio(5, this.ruim, this.regular, this.bom, this.muitobom);
            }
            else {

                  
            }

                  
        }

        private void Executar(string nome,string idade)

        {

            Validacao validacao = new Validacao(nome,idade);

        }
        public int Alternativa { get => alternativa; }
        public int Numero_pergunta { get => numero_pergunta; }
    }
}
