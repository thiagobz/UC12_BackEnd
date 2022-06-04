using UC12_BackEnd.Interfaces;

namespace UC12_BackEnd.Classes
{
    public class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        public float Rendimento { get; set; }
        public string? Endereco { get; set; }

        public float PagarImpostos(float rendimento)
        {
            throw new NotImplementedException();

        }
    }
}