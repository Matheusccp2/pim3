using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePIM.Back_End
{
    public class Relatorio
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







        #endregion

        #region Constructor
        public Relatorio(int muitoruim, int ruim, int regular, int bom, int muitobom)
        {
            this.total_muitoruim = muitoruim;
            this.total_ruim += ruim;
            this.total_regular += regular;
            this.total_bom += bom;
            this.total_muitobom += muitobom;
            calcular_media();
        }

        public Relatorio() { 
        
        }

        #endregion

        #region Metodos
        private void calcular_media()

        {
            

          

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
