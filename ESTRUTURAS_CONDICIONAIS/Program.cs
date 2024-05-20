//Estrutura condicional IF:

if(3 > 2)
    Console.WriteLine("É maior");

var ativo = true;
if(3 > 2 && ativo == true){
    Console.WriteLine("É maior");
    Console.WriteLine("Verdadeiro");
}
Console.WriteLine("Final");

//Estrutura condicional IF-ELSE:

// ﻿var idade = 16;
// var nota = 7;

// if(idade >= 18){
//     Console.WriteLine("Maior de idade");
//     Console.WriteLine("Cadastro autorizado");
// }
// else if(idade >= 16){
//     Console.WriteLine("Menor de idade, maior que 16 anos");
//     Console.WriteLine("Cadastro autorizado com responsáveis");
// }else{
//     Console.WriteLine("Menor de idade");
//     Console.WriteLine("Cadastro não autorizado");
// }

// bool aprovado = nota >= 7;

// if(aprovado){
//     Console.WriteLine("Aprovado");
// }else{
//     Console.WriteLine("Reprovado");
// }

// Console.WriteLine("Finalizado");

//Operador ternário:

// var mensagem = "";
// var nota = 5;
// var idade = 18;

// if(nota > 7){
//     mensagem = "Aprovado";
// }else{
//     mensagem = "Reprovado";
// }

// CONDIÇÃO ? VALOR SE VERDADEIRO : VALOR SE FALSO
// mensagem = nota >= 7 ? "Aprovado" : "Reprovado";

// Console.WriteLine(mensagem);


//Estrutura condicional SWITCH:

// ﻿Console.WriteLine("Digite um opção:");
// var opcao = Console.ReadLine();

// switch(opcao){
//     case "1":
//         Console.WriteLine("Seu saldo é R$ 100,00");
//         break;
//     case "2":
//         Console.WriteLine("Informe o valor do depósito");
//         break;
//     case "3":
//         Console.WriteLine("Informe o valor do saque");
//         break;
//     default:
//         Console.WriteLine("Opção inválida");
//         break;
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch(letra.ToLower()){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }
