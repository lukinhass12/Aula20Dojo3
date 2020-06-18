namespace Aula20Dojo3
{
    public class Pedido
    {
        public string Item{ get; set;}
        public string cliente{get; set;}
        public string restaurante {get; set;}
        public string Pagamento {get;set;}
        public bool PedidoPago {get; set;}
        public Pedido(string Item, string cliente, string restaurante, string Pagamento, bool PedidoPago){
            this.Item= Item;
            this.cliente = cliente;
            this.restaurante = restaurante;
            this.Pagamento = Pagamento;
        }
        public Pedido(string v1, string v2, string v3, string v4)
        {
        }

        public Pedido()
        {
        }
    }

        }
    

