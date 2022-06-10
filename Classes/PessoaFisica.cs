using UC12_BackEnd.Interfaces;

namespace UC12_BackEnd.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? Cpf { get; set; }

        public string? Name { get; set; }

        public PessoaFisica(DateTime dataNasc)
        {
            this.DataNasc = dataNasc;

        }
        public DateTime DataNasc { get; set; }



        public override float pagaImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

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

            if (DateTime.TryParse(dataNasc, out dataConvertida);)
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }

                return false;
            }
        }
    }
}