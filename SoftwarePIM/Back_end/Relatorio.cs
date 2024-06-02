using SoftwarePIM.Back_end;
using SoftwarePIM.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePIM.Back_End
{
    public class Relatorio : Abspropriedades
    {

        #region Atributos

         public static int total_respostas;
         public static int multi_resposta;
         public static int resultado;
         public static int soma_idade;
         public static int numero_pessoas;     
         public static int total_menos18;
         public static int total_mais60;
         public static int total_entre18e60;
         public static int Idade;
         public static int media_avaliacao;
         public static string maior_reposta = "";
         public static int total_muitoruim;
         public static int total_ruim;
         public static int total_regular;
         public static int total_bom;
         public static int total_muitobom;
         public static int media_idade;

        public List<int> lista_int_idade = new List<int>();

        private string Nome = "";

        
        #endregion

        #region Constructor
        public Relatorio(int muitoruim, int ruim, int regular, int bom, int muitobom)
        {
            total_muitoruim += muitoruim;
            total_ruim += ruim;
            total_regular += regular;
            total_bom += bom;
            total_muitobom += muitobom;
            Relatorio.numero_pessoas++;
            calcular_media_idade();
            calcular_media();
            

        }

        public Relatorio(string nome, int Idadei) 
        {
            Idade = Idadei;
            Nome = nome;
           
        }

        private void calcular_media_idade()
        { 
            if (Idade < 18) total_menos18++;
            if (Idade > 60) total_mais60++;
            if (Idade <= 60 && Idade >= 18) total_entre18e60++;
            
            soma_idade = soma_idade + Idade;           
            media_idade = soma_idade / numero_pessoas;
            
        }

        #endregion

        #region Metodos
        private void calcular_media()

        {
            total_respostas = total_muitoruim + total_ruim + total_regular + total_bom + total_muitobom;

            multi_resposta = (total_muitoruim * 1) + (total_ruim * 2) + (total_regular * 3) + (total_bom * 4) + (total_muitobom * 5);

            resultado = multi_resposta / total_respostas;

            media_avaliacao = resultado;

            if (resultado < 2) { maior_reposta = "MUITO RUIM";}
            else if (resultado < 3) { maior_reposta = "RUIM"; }
            else if (resultado < 4) { maior_reposta = "REGULAR"; }
            else if (resultado < 5) { maior_reposta = "BOM"; }
            else { maior_reposta = "MUITO BOM"; }
            


        }
        //    //public void salvar_estatico() { 

        //    Estaticos.MAIOR_REPOSTA = this.maior_reposta;
        //    Estaticos.MEDIA_AVALIACAO = this.media_avaliacao;
        //    Estaticos.TOTAL_MUITORUIM = this.total_muitoruim;
        //    Estaticos.TOTAL_RUIM = this.total_ruim;
        //    Estaticos.TOTAL_REGULAR = this.total_regular;
        //    Estaticos.TOTAL_BOM = this.total_bom;
        //    Estaticos.TOTAL_MUITOBOM = this.total_muitobom;
        //    Estaticos.MEDIA_IDADE = this.media_idade;
        //    Estaticos.TOTAL_MENOS18 = this.total_menos18;
        //    Estaticos.TOTAL_MAIS60 = this.total_mais60;
        //    Estaticos.TOTAL_ENTRE18E60 = this.total_entre18e60;
        //}

        internal new string ToString()
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

        public Frm_Relatorio Frm_Relatorio
        {
            get => default;
            set
            {
            }
        }
    }


}
