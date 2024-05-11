using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePIM.Back_End
{
    public class Relatorio : Banco_de_dados
    {

        #region Atributos



        private int media_avaliacao;
        private int total_muitoruim = 0;
        private int total_ruim;
        private int total_regular;
        private int total_bom;
        private int total_muitobom;
        private int media_etaria;

        private List<string> lista_idade_string = new List<string> { };






        public Relatorio(int muitoruim, int ruim, int regular, int bom, int muitobom) : base(muitoruim, ruim, regular, bom, muitobom)
        {
            this.total_muitoruim = Lista_muitoruim.Count;
            this.total_ruim = Lista_ruim.Count;
            this.total_regular = Lista_regular.Count;
            this.total_bom = Lista_bom.Count;
            this.total_muitobom = Lista_muitobom.Count;
        }




        #endregion

        #region Constructor
<<<<<<< Updated upstream
        public Relatorio(int muitoruim, int ruim, int regular, int bom, int muitobom)
=======
        /*public Relatorio(Dictionary<int, string> lista_idade, Dictionary<int, string> lista_alternativa, Dictionary<int, string> lista_muitoruim, Dictionary<int, string> lista_ruim, Dictionary<int, string> lista_regular, Dictionary<int, string> lista_bom, Dictionary<int, string> lista_muitobom)
>>>>>>> Stashed changes
        {
            this.total_muitoruim = muitoruim;
            this.total_ruim += ruim;
            this.total_regular += regular;
            this.total_bom += bom;
            this.total_muitobom += muitobom;
            calcular_media();
        }

<<<<<<< Updated upstream
        public Relatorio() { 
        
        }
=======
        }*/


        public int Total_muitoruim { get => Total_muitoruim;}
        public int Total_ruim { get => Total_ruim; }
        public int Total_regular { get => Total_regular;}
        public int Total_bom { get => Total_bom; }
        public int Total_muitobom { get => Total_muitobom; }
   
>>>>>>> Stashed changes

        #endregion

        #region Metodos
        private void calcular_media()

        {
            

          

        }

        internal string ToString(int total_muitoruim)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region propriedades

        public int Total_muitoruim { get => total_muitoruim; }
        public int Total_ruim { get => total_ruim; }
        public int Total_regular { get => total_regular; }
        public int Total_bom { get => total_bom; }
        public int Total_muitobom { get => total_muitobom; }

        #endregion




    }


}
