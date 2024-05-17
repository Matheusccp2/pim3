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

        private int total_respostas;
        private int multi_resposta;
        private int resultado;
        public static int media_avaliacao;
        public static string maior_reposta;


        public static int total_muitoruim;
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
            total_muitoruim += muitoruim;
            total_ruim += ruim;
            total_regular += regular;
            total_bom += bom;
            total_muitobom += muitobom;
            calcular_media();

        }

        public Relatorio() { 

            
        
        }

        #endregion

        #region Metodos
        private void calcular_media()

        {
            this.total_respostas = total_muitoruim + total_ruim + total_regular + total_bom + total_muitobom;

            multi_resposta = (total_muitoruim * 1) + (total_ruim * 2) + (total_regular * 3) + (total_bom * 4) + (total_muitobom * 5);

            resultado = multi_resposta / total_respostas;

            media_avaliacao = resultado;

            if (resultado < 2) { maior_reposta = "MUITO RUIM";}
            else if (resultado < 3) { maior_reposta = "RUIM"; }
            else if (resultado < 4) { maior_reposta = "REGULAR"; }
            else if (resultado < 5) { maior_reposta = "BOM"; }
            else { maior_reposta = "MUITO BOM"; }
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
