using UC12_BackEnd.Interfaces;

namespace UC12_BackEnd.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }
        
        public string? RazaoSocial { get; set; }
        
        public override float pagaImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validaCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}