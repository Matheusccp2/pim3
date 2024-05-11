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
<<<<<<< Updated upstream
        private int alternativa;
=======
        private char alternativa;
>>>>>>> Stashed changes
        private int numero_pergunta;
        private int muitoruim;
        private int ruim;
        private int regular;
        private int bom;
        private int muitobom;
<<<<<<< Updated upstream

        

        public Controle(int alternativa, int numero_pergunta)
=======
        private string nome;
        private string idade;



        public Controle(char alternativa, int numero_pergunta)
>>>>>>> Stashed changes

        {
            this.alternativa = alternativa;
            this.numero_pergunta = numero_pergunta;

<<<<<<< Updated upstream
            Executar_questionario();
        }
        public Controle() { 
        
=======
            Executar();
>>>>>>> Stashed changes
        }
        public Controle(string nome, string idade)

        {
            this.nome = nome;
            this.idade = idade;

        }

        private void Executar(){

            if (numero_pergunta <= 5) {
                Questionario questionario = new Questionario(alternativa, numero_pergunta);
                this.muitoruim = questionario.Muitoruim;
                this.ruim = questionario.Ruim;
                this.regular = questionario.Regular;
                this.bom = questionario.Bom;
                this.muitobom = questionario.Muitobom;

            }

            Banco_de_dados bd = new Banco_de_dados(this.muitoruim,this.ruim,this.regular,this.bom,this.muitobom);
            
        }

<<<<<<< Updated upstream
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

=======
>>>>>>> Stashed changes
        private void Executar(string nome,string idade)

        {
            Validacao validacao = new Validacao(nome,idade);


        }
        public int Alternativa { get => alternativa; }
        public int Numero_pergunta { get => numero_pergunta; }
    }
}
