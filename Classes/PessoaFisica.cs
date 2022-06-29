using UC12_BackEnd.Interfaces;

namespace UC12_BackEnd.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? Cpf { get; set; }

        public string? Name { get; set; }

        public DateTime DataNasc { get; set; }



        public override float pagaImposto(float rendimento)
        {
            // throw new NotImplementedException();

            /*          Pessoa fisica:
                rendimento ate 1500 - insento
                rendimento de 1500 à 3500, 2%
                rendimento de 3501 à 6000, 3,5%
                rendimento acima de 6000, 5%
             */

            if (rendimento <= 1500)
            {
                return 0;
            }else if(rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento / 100) * 2;
                float salario = rendimento - resultado;
                return salario;
            }else if(rendimento > 3500 && rendimento <= 6000)
            {
                float resultado  = (rendimento / 100) * 3.5f;
                float salario = rendimento - resultado;
                return salario;
            } else {
                float resultado =  (rendimento / 100) * 5;
                float salario = rendimento - resultado;
                return salario;
            }
        }

        // implementa uma função de validação de idade.
        public bool validarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }

            return false;
        }

        public bool validarDataNasc(string dataNasc)
        {
            DateTime dataConvertida;

            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }

                return false;
            }
            return false;
        }
    }
}