using System;

namespace WFRestaurante
{
    public abstract class Pessoa
    {
        public Pessoa() { }
        public Pessoa(String nome)
        {
            this.Nome = nome;
        }
        public Pessoa(String nome, String nascimento)
        {
            this.Nome = nome;
            this.Nascimento = DateTime.Parse(nascimento);
        }
        public Pessoa(DateTime nascimento)
        {
            this.Nascimento = nascimento;
            
        }

        public String Nome { get; set; } //c#
        public DateTime Nascimento { get; set; }
        public String Endereço { get; set; }

    }
}
