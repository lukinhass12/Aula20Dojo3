namespace Aula20Dojo3
{
    public class Restaurante
    {
        public string NomeFantasia{get; set;}
        public string Endereco{ get; set;}
        public Restaurante(string _NomeFantasia, string _Endereco){
            this.Endereco = _Endereco;
            this.NomeFantasia = _NomeFantasia;
        }

        public Restaurante()
        {
        }
    }
}