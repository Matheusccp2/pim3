using SoftwarePIM.Back_end;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePIM.Modelo
{
    internal class Questionario : Abspropriedades
    {
      
        

        public Questionario(int alternativa,int numero_pergunta)
        {
            this.alternativa = alternativa;
            this.numero_pergunta = numero_pergunta;
            Verificar();
        }
        
        private void Verificar()

        {
                   
                switch (alternativa)
                {
                    case 1: this.muito_ruim++; break;
                    case 2: this.ruim++; break;
                    case 3: this.regular++; break;
                    case 4: this.bom++; break;
                    case 5: this.muito_bom++; break;

                }
            
           
            
            
        }

        public int Ruim { get => ruim; }
        public int Regular { get => regular; }
        public int Bom { get => bom; }
        public int Muitobom { get => muito_bom; }
        public int Muitoruim { get => muito_ruim; }
    }
}
