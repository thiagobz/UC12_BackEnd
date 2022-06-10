using UC12_BackEnd.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.Cpf = "135.752.457-97";
novaPF.Nome = "Thiago Bazani";
novaPF.Endereco = "Rua Roma n 3";
novaPF.DataNasc = new DateTime(1992, 02, 01);

novaPF.validarDataNasc(novaPF.DataNasc);


//Interpolação
Console.WriteLine(
@$"Nome: {novaPF.Nome}
CPF: {novaPF.Cpf}
Endereço: {novaPF.Endereco}
Maior de idade? {novaPF.validarDataNasc(novaPF.DataNasc)}");