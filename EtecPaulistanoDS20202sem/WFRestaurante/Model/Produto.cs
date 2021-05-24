using System;

namespace WFRestaurante
{
    public class Produto
    {
        public String Codigo{ get; set; }
        public String Descrição { get; set; }
        public Decimal Preço { get; set; }
        public Categoria Categoria { get; set; }
        public Boolean Cancelado { get; set; }

        public void Add(Produto produto)
        { 
        
        }

    }
}
