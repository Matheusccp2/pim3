using SoftwarePIM.Back_end;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePIM.Back_End
{
    public class Relatorio : Abspropriedades
    {

        #region Atributos



        private int media_avaliacao;
        public  static int total_muitoruim;
        public static int total_ruim;
        public static int total_regular;
        public static int total_bom;
        public static int total_muitobom;
        private int media_etaria;

        private List<string> lista_idade_string = new List<string> { };


        

        #endregion

        #region Constructor
        public Relatorio(int muitoruim, int ruim, int regular, int bom, int muitobom)
        {
            total_muitoruim = muitoruim;
            total_ruim = ruim;
            total_regular = regular;
            total_bom = bom;
            total_muitobom = muitobom;
            calcular_media();
        }

        public Relatorio() { 

            
        
        }

        #endregion

        #region Metodos
        private void calcular_media()

        {
            

          

        }

        internal string ToString()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region propriedades

        
        public int Total_ruim { get => total_ruim; }
        public int Total_regular { get => total_regular; }
        public int Total_bom { get => total_bom; }
        public int Total_muitobom { get => total_muitobom; }

        #endregion




    }


}
