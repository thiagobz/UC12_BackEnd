using UC12_BackEnd.Interfaces;

namespace UC12_BackEnd.Classes

// Classe abstrata -> https://www.macoratti.net/12/06/c_caip1.htm

{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
       
        public float Rendimento { get; set; }
        
        public string? Endereco { get; set; }

        public abstract float pagaImposto(float rendimento);
    }
}