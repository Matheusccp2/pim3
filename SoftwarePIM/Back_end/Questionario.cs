using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePIM.Modelo
{
    internal class Questionario
    {

        private int muitoruim;
        private int ruim;
        private int regular;
        private int bom;
        private int muitobom;
        private int alternativa;
        private int numero_pergunta;
        

        public Questionario(int alternativa,int nuemro_pergunta)
        {
            this.alternativa = alternativa;
            this.numero_pergunta = nuemro_pergunta;
            Verificar();
        }



        private void Verificar()

        {
            
                switch (alternativa)
                {
                    case 1: this.muitoruim++; break;
                    case 2: this.ruim++; break;
                    case 3: this.regular++; break;
                    case 4: this.bom++; break;
                    case 5: this.muitobom++; break;

                }
            
           
            
            
        }
        public int Muitoruim { get => muitoruim;}
        public int Ruim { get => ruim; }
        public int Regular { get => regular; }
        public int Bom { get => bom; }
        public int Muitobom { get => muitobom; }

    }
}
