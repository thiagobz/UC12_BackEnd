using System.Text.RegularExpressions;
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

            }
            else if (rendimento <= 6000)
            {
                return rendimento * .05f;

            }
            else if (rendimento <= 1000)
            {
                return rendimento * .07f;
            }
            else
            {
                return rendimento * .09f;
            }
        }

        public bool validaCnpj(string cnpj)
        {
            // throw new NotImplementedException();    
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");

            if (retornoCnpjValido == true)
            {
                if (cnpj.Length == 18)
                {

                    string subStringCnpj = cnpj.Substring(11, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }

                }
                else if (cnpj.Length == 14)
                {

                    string subStringCnpj = cnpj.Substring(8, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }

                }
            }

            return false;
        }
    }
}