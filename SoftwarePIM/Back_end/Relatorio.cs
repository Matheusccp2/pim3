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

        private int total_respostas;
        private int multi_resposta;
        private int resultado;
        private int soma_idade;

        public static List<int> lista_int_idade = new List<int>();
        public static int media_idade;
        public static int total_menos18;
        public static int total_mais60;
        public static int total_entre18e60;
        public static int media_avaliacao;
        public static string maior_reposta;
        public static int total_muitoruim;
        public static int total_ruim;
        public static int total_regular;
        public static int total_bom;
        public static int total_muitobom;

        public static string Nome;
        private int Idade;
        
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

        public Relatorio(string nome, int Idadei) 
        {
            this.Idade = Idadei;
            Nome = nome;
            lista_int_idade.Add(Idadei);
            calcular_media_idade(); 
        }

        private void calcular_media_idade()
        {       if (this.Idade < 18) total_menos18++;
                if (this.Idade > 60) total_mais60++;
                if (this.Idade < 60 && this.Idade > 18) total_entre18e60++;
            for (int i = 0; i < lista_int_idade.Count; i++) 
            {
                soma_idade = soma_idade + lista_int_idade[i];
            }

            media_idade = soma_idade / lista_int_idade.Count;
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

    }


}
