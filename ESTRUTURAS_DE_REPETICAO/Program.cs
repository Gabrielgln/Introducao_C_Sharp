//Estrutura de repetição WHILE (Enquanto):

int indice = 0;
string[] versoes = new[]{"1.0", "1.1", "1.2", "1.3"};

while(indice < versoes.Length){
    Console.WriteLine(versoes[indice]);
    indice++;
}

int contador = 1;
while(contador < 10){
    Console.WriteLine(contador);
    contador++;
}

//Estrutura de repetição DO-WHILE (Faça enquanto):

// var contador = 10;

// do{
//     Console.WriteLine(contador);
//     contador++;
// }while(contador < 10);

// //======================================================================
// var opcao = "";

// do{
//     Console.WriteLine("Digite uma opção:");
//     Console.WriteLine("1 - Saque | 2 - Depósito | 3 - Saldo | 0 - Sair");
//     opcao = Console.ReadLine();

//     switch(opcao){
//         case "1":
//             Console.WriteLine("Saque realizado.");
//             break;
//         case "2":
//             Console.WriteLine("Depósito realizado.");
//             break;
//         case "3":
//             Console.WriteLine("Saldo disponível: R$ 100,00");
//             break;    
//     }
// }while(opcao != "0");

// //======================================================================

// int soma = 0, numero = 0;

// do{
//     Console.WriteLine("Digite um numero (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
// }while(numero != 0);
// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

//Estrutura de repetição FOR (Para):

// for(var indice = 0; indice < 5; indice++){
//     Console.WriteLine(indice);
// }

// for(var indice = 5; indice > 0; indice--){
//     Console.WriteLine(indice);
// }

// var numeros = new[]{1, 2, 100, 1000};
// for(var indice = 0; indice < numeros.Length; indice++){
//     Console.WriteLine(numeros[indice]);
// }

//Estrutura de repetição FOREACH (Para cada):

﻿var nomes = new[]{"Gabriel", "Verônica", "Marquin", "João"};

foreach(var nome in nomes){
    Console.WriteLine(nome);
}

//Continue:

// foreach(var nome in nomes){
//     if(nome == "Gabriel")
//         continue;
//     Console.WriteLine(nome);
// }

//Break:

// foreach(var nome in nomes){
//     if(nome == "Marquin")
//         break;
//     Console.WriteLine(nome);
// }



