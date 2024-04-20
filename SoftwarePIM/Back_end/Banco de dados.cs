using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SoftwarePIM.Back_End
{
    public class Banco_de_dados
    {

        Dictionary<int, string> lista_idade = new Dictionary<int, string>();
        Dictionary<int, string> lista_nome = new Dictionary<int, string>();
        Dictionary<int, string> lista_muitoruim = new Dictionary<int, string>();
        Dictionary<int, string> lista_ruim = new Dictionary<int, string>();
        Dictionary<int, string> lista_regular = new Dictionary<int, string>();
        Dictionary<int, string> lista_bom = new Dictionary<int, string>();
        Dictionary<int, string> lista_muitobom = new Dictionary<int, string>();
        private List<int> lista_id_visitante = new List<int> { };

        private int id_visitante;
        private string nome;
        private int idade;
        private int total_mais18;
        private int total_menos18;
        private int total_mais60;

        public Banco_de_dados(string nome, int idade, int muitoruim, int ruim, int regular, int bom, int muitobom)

        {
            if (idade < 18) this.total_menos18++;
            if (idade > 18) this.total_mais18++;
            if (idade > 18) this.total_mais60++;

            this.nome = nome;
            this.idade = idade;
            Armazenar_nome_idade(nome,idade);
            Armazenar_alternativas(muitoruim,ruim, regular, bom, muitobom);

        }

        private void Armazenar_id_visitante() {

            for (int i = 0; i < this.lista_id_visitante.Count; i++) {

                this.lista_id_visitante.Add(this.lista_id_visitante[i] + 1);
                this.id_visitante = this.lista_id_visitante.Count - 1;

            }
        }

        private void Armazenar_nome_idade(string nome, int idade) {

            
            
            this.lista_nome.Add(this.id_visitante,nome);
            this.lista_idade.Add(this.id_visitante, Convert.ToString(idade));
                          
        }

        private void Armazenar_alternativas(int muitoruim, int ruim, int regular, int bom, int muitobom) {

            if (muitoruim != 0) lista_muitoruim.Add(this.id_visitante, Convert.ToString(muitoruim));
            if (ruim != 0) lista_ruim.Add(this.id_visitante, Convert.ToString(ruim));
            if (regular != 0) lista_regular.Add(this.id_visitante, Convert.ToString(regular));
            if (bom != 0) lista_bom.Add(this.id_visitante, Convert.ToString(bom));
            if (muitobom != 0) lista_muitobom.Add(this.id_visitante, Convert.ToString(muitobom));

        
        
        }
    }
}
