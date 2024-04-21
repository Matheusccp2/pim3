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
        private int total_muitoruim;
        private int total_ruim;
        private int total_regular;
        private int total_bom;
        private int total_muitobom;
        private int media_etaria;
        
        Dictionary<int, string> lista_idade = new Dictionary<int, string>();
        private List<string> lista_idade_string = new List<string> { };
        Dictionary<int, string> lista_alternativa = new Dictionary<int, string>();
        private List<string> lista_alternativa_string = new List<string> { };


        #endregion

        #region Constructor
        public Relatorio(Dictionary<int, string> lista_idade, Dictionary<int, string> lista_alternativa, Dictionary<int, string> lista_muitoruim, Dictionary<int, string> lista_ruim, Dictionary<int, string> lista_regular, Dictionary<int, string> lista_bom, Dictionary<int, string> lista_muitobom)
        {
            this.lista_idade = lista_idade;           
            this.lista_alternativa = lista_alternativa;

            this.total_muitoruim = lista_muitoruim.Count;
            this.total_ruim = lista_ruim.Count;
            this.total_regular = lista_regular.Count;
            this.total_bom = lista_bom.Count;
            this.total_muitobom = lista_muitobom.Count;

            calcular_media(lista_idade, lista_alternativa);
            
        }
        
        #endregion

        #region Metodos
        private void calcular_media(Dictionary<int, string> lista_idade,Dictionary<int, string> lista_alternativa)

        {
            int soma_idade;

            for (int i = 0; i < lista_idade.Count || i < lista_alternativa.Count; i++) {

                this.lista_idade_string[i] = lista_idade[i];
                this.lista_alternativa_string[i] = lista_alternativa[i];

                List<int> listaInt = lista_idade_string.ConvertAll(int.Parse);

                soma_idade = listaInt[i] + listaInt[-i];
                
            }

        }
        #endregion

        #region propriedades

        

        #endregion




    }


}
