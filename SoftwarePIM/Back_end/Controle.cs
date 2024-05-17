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
        public Controle(int muito_ruim, int ruim,int regular,int bom,int muito_bom, int numero_pergunta)

        {            
            this.muito_ruim = muito_ruim;
            this.ruim = ruim;
            this.regular = regular;
            this.bom = bom;
            this.muito_bom = muito_bom;
            Executar_questionario();
        }

        public Controle(string nome, string idade)
        {
            this.nome = nome;
            this.idade = idade;

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

