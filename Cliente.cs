using System;
namespace Aula20Dojo3
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string EnderecoAtual {get; set;}

        public Cliente(string _Nome, string _EnderecoAtual){
            this.Nome = _Nome;
            this.EnderecoAtual = _EnderecoAtual;

        }

        public Cliente()
        {
        }
    }
}