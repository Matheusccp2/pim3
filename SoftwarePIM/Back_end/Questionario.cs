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
        
        

<<<<<<< Updated upstream
        public Questionario(int alternativa,int nuemro_pergunta)
        {
            this.alternativa = alternativa;
            this.numero_pergunta = nuemro_pergunta;
            Verificar();
=======
        public Questionario(char alternativa, int numero_pergunta)
        {
            
            Verificar(alternativa,numero_pergunta);
>>>>>>> Stashed changes
        }



<<<<<<< Updated upstream
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
            
           
            
            
=======
        private void Verificar(char alternativa, int numero_pergunta)

        {
            if (numero_pergunta <= 5)
            {
                switch (alternativa)
                {
                    case '1': this.muitoruim++; break;
                    case '2': this.ruim++; break;
                    case '3': this.regular++; break;
                    case '4': this.bom++; break;
                    case '5': this.muitobom++; break;

                }
            }

            else {
                this.muitoruim = 0;
                this.ruim = 0;
                this.regular = 0;
                this.bom = 0;
                this.muitobom = 0;
            }
>>>>>>> Stashed changes
        }
        public int Muitoruim { get => muitoruim;}
        public int Ruim { get => ruim; }
        public int Regular { get => regular; }
        public int Bom { get => bom; }
        public int Muitobom { get => muitobom; }

    }
}
