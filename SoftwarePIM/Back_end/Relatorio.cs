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

        private List<int> lista_int_idade = new List<int>();

        private int media_idade;
        private int total_menos18;
        private int total_mais60;
        private int total_entre18e60;

        private int media_avaliacao;
        private string maior_reposta = "";

        private int total_muitoruim;
        private int total_ruim;
        private int total_regular;
        private int total_bom;
        private int total_muitobom;

        private string Nome = "";
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
        { 
            if (this.Idade < 18) this.total_menos18++;
            if (this.Idade > 60) this.total_mais60++;
            if (this.Idade <= 60 && this.Idade >= 18) this.total_entre18e60++;
            for (int i = 0; i < lista_int_idade.Count; i++) 
            {
                soma_idade = soma_idade + lista_int_idade[i];
            }

            this.media_idade = soma_idade / this.lista_int_idade.Count;
            salvar_estatico();


        }

        #endregion

        #region Metodos
        private void calcular_media()

        {
            this.total_respostas = total_muitoruim + total_ruim + total_regular + total_bom + total_muitobom;

            multi_resposta = (total_muitoruim * 1) + (total_ruim * 2) + (total_regular * 3) + (total_bom * 4) + (total_muitobom * 5);

            resultado = multi_resposta / total_respostas;

            this.media_avaliacao = resultado;

            if (resultado < 2) { this.maior_reposta = "MUITO RUIM";}
            else if (resultado < 3) { this.maior_reposta = "RUIM"; }
            else if (resultado < 4) { this.maior_reposta = "REGULAR"; }
            else if (resultado < 5) { this.maior_reposta = "BOM"; }
            else { this.maior_reposta = "MUITO BOM"; }
            salvar_estatico();

        }
            public void salvar_estatico() { 

            Estaticos.MAIOR_REPOSTA = this.maior_reposta;
            Estaticos.MEDIA_AVALIACAO = this.media_avaliacao;
            Estaticos.TOTAL_MUITORUIM = this.total_muitoruim;
            Estaticos.TOTAL_RUIM = this.total_ruim;
            Estaticos.TOTAL_REGULAR = this.total_regular;
            Estaticos.TOTAL_BOM = this.total_bom;
            Estaticos.TOTAL_MUITOBOM = this.total_muitobom;
            Estaticos.MEDIA_IDADE = this.media_idade;
            Estaticos.TOTAL_MENOS18 = this.total_menos18;
            Estaticos.TOTAL_MAIS60 = this.total_mais60;
            Estaticos.TOTAL_ENTRE18E60 = this.total_entre18e60;
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
