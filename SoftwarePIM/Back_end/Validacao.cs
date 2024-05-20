﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftwarePIM.Modelo
{
    internal class Validacao
    {
        #region Propriedades

        private int idadei;
        private string mensagem;
        private string nome;
        private string idade;

        #endregion
        #region Construtor

        public Validacao(string nome, string idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.Validar(nome, idade);
        }

        #endregion
        #region Metodos

        private void Validar(string nome, string idade)
        {
            this.mensagem = "ok";
            int contadorEspacos = 1;
            char i = '0';

            try
            {
                if (idade == "") {idade = "0";}
                this.idadei = Convert.ToInt32(idade);
                //string pattern = @"[^\w\s]"; // Identifica qualquer caracter que não seja alfanumérico

                //if (Regex.IsMatch(nome, pattern))
                //{
                //    this.mensagem = "O nome não pode conter caracteres especiais.";
                //}

                foreach (char c in nome) //Verifica se esta sendo acrescido 2 espaços entre os caracteres
                {
                    if (c == ' ' && i == ' ')
                    {
                        contadorEspacos++;

                        if (contadorEspacos >= 1)
                        {
                            this.mensagem = "Existem 2 ou mais espaços entre os caracteres";
                        }
                    }
                    else
                    {
                        contadorEspacos = 0;
                    }
                    i = c;
                }

                if (nome.Length > 255 || nome.Length < 3)
                {
                    this.mensagem = "O nome deve conter entre 3 a 255 caracteres";
                }

                else if (this.idadei < 1 || this.idadei > 110)
                {
                    this.mensagem = "Digite a sua idade.                                          (Valores permitidos de 1 a 110 anos)";
                }
            }

            catch (Exception)
            {
                this.mensagem = "Digite dados válidos";
            }
        }

        #endregion
        #region Encapsulamento

        public string Mensagem
        {
            get { return this.mensagem; }
        }
        public int Idadei
        {
            get { return this.idadei; }
        }

        #endregion
    }
}