﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5___Herança
{
    class Pessoa
    {
        private string nome;
        private string endereco;
        private string telefone;

        public Pessoa(string NOME, string ENDERECO, string TELEFONE)
        {
            this.nome = NOME;
            this.endereco = ENDERECO;
            this.telefone = TELEFONE;

        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }


        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }


        }
    }
}
    

