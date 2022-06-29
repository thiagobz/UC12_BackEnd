using UC12_BackEnd.Interfaces;

namespace UC12_BackEnd.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }
        
        public string? RazaoSocial { get; set; }
        
        public override float pagaImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;

            }else if (rendimento <= 6000)
            {
                return rendimento  * .05f;

            }else if (rendimento <= 1000)
            {
                return rendimento * .07f;
            } else {
                return rendimento * .09f;
            }
        }

        public bool validaCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}