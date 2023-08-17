using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMaiorIdade
{
    public class Pessoa
    {
        //variavel privada que vai armazenar o valor
        private string nomePessoa;

        //Propriedades publicas acessiveis 

        //propriedade full 
        public string NomePessoa
        {
            get { return nomePessoa; }
            set { nomePessoa = value.ToUpper(); }
        }

        private int idadePessoa;
        public int IdadePessoa 
        {
            get { return idadePessoa;  } 
            set
            {
                //tratando idade negativa
                if(value >= 0)
                {
                    idadePessoa = value;
                }
                else
                {
                    idadePessoa = 0;
                }
            } 
        }


        //Construtor
        public Pessoa(string nome, int idade)
        {
            NomePessoa = nome;
            IdadePessoa = idade;
        }

        //Métodos 
        public void ExibirDados()
        {
            Console.WriteLine(NomePessoa);
            Console.WriteLine(IdadePessoa);
        }
    }
}
