using UC12_BackEnd.Classes;
using UC12_BackEnd.Interfaces;


Console.Clear();
Console.WriteLine(
    @$"
===============================================
|                                             |
|     Bem-vindo ao sistema de cadastro de     |
|      Pessoa Física e Pessoa Juridica        |
|                                             |
===============================================
"
);

Console.WriteLine($"Iniciando");
for (var contador = 0; contador <10; contador++)
{
    Console.Write(".");
    Thread.Sleep(300);
}

string? opcao;

do
{
    Console.Clear();

    Console.WriteLine(
        @$"
    ===============================================
    |       Escolha uma das opções a baixo        |
    |---------------------------------------------|
    |             1- Pessoa Fisica                |
    |             2- Pessoa Juridica              |
    |                                             |
    |             0- Cancelar                     |
    ===============================================
    "
    );
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPF = new PessoaFisica();
            PessoaFisica metodoPF = new PessoaFisica();
            Endereco novoEndPF = new Endereco();

            novaPF.Cpf = "135.752.457-97";
            novaPF.Nome = "Thiago Bazani";
            novaPF.DataNasc = new DateTime(1992, 02, 01);
            novaPF.Rendimento = 3500;

            novoEndPF.logradouro = "Rua Roma";
            novoEndPF.numero = 3;
            novoEndPF.complemento = "Casa";
            novoEndPF.endComercial = true;

            novaPF.Endereco = novoEndPF;

            novaPF.validarDataNasc(novaPF.DataNasc);
            Console.WriteLine(
            @$"Nome: {novaPF.Nome}
            CPF: {novaPF.Cpf}
            Endereço: {novaPF.Endereco.logradouro}, {novaPF.Endereco.numero}
            Complemento: {novaPF.Endereco.complemento}
            Endereço Comercial: {(novaPF.Endereco.endComercial ? "Sim" : "Não")}
            Maior de idade: {(metodoPF.validarDataNasc(novaPF.DataNasc) ? "Sim" : "Não")}
            salário deduzido: {novaPF.pagaImposto(novaPF.Rendimento).ToString("C")}
            ");

            Console.WriteLine($"Aperte Enter para continuar.");
            Console.ReadLine();
            
            break;
        case "2":
            PessoaJuridica novoPJ = new PessoaJuridica();
            PessoaJuridica metodoPJ = new PessoaJuridica();
            Endereco novoEndPJ = new Endereco();

            novoPJ.RazaoSocial = "Senai Cursos São Paulo";
            novoPJ.Cnpj = "11.111.111/0001.11";

            novoEndPJ.logradouro = "Rua das flores";
            novoEndPJ.numero = 1235;
            novoEndPJ.complemento = "Ao lado da SmartFit";
            novoEndPJ.endComercial = true;

            novoPJ.Endereco = novoEndPJ;


            Console.WriteLine(
                @$"Razão Social: {novoPJ.RazaoSocial}
                CNPJ: {novoPJ.Cnpj}
                Endereço: {novoPJ.Endereco.logradouro}, {novoPJ.Endereco.numero}
                Complemento: {novoPJ.Endereco.complemento}
                Endereço Comercial: {(novoPJ.Endereco.endComercial ? "Sim" : "Não")}
                ");

                Console.WriteLine($"Aperte Enter para continuar.");
                Console.ReadLine();
            break;
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar o nosso sistema!");
            Thread.Sleep(3000);
            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção inválida, porfavor digite uma opçãa válida");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");





/* using UC12_BackEnd.Classes;

PessoaFisica novaPF = new PessoaFisica();
PessoaFisica metodoPf= new PessoaFisica();

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
Maior de idade? {metodoPf.validarDataNasc(novaPF.DataNasc)}");

Console.WriteLine(metodoPf.validarDataNasc(novaPF.DataNasc)); */
