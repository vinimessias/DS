using System;

namespace WFRestaurante
{
    public class Categoria
    {
        public int ID { get; set; }
        public String Descrição { get; set; }

        public void Add(Categoria categoria)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }
        public Categoria ConsultarId(int idcategoria)
        {
            Categoria categoria = new Categoria();
            /* falta codigo*/
            return categoria;
        }

    }
}
