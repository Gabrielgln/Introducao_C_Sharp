//Operadores aritméticos:
//===================================================================

int a = 7;
var b = 3;

//var b = 3.0m;

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

//Operadores de atribuição aritméticos:
//===================================================================

// var a = 5;
// var b = 5;
// var c = 5;
// var d = 5;
// var e = 5;

// a += 2; //a = a + 2;
// b -= 2; //b = b - 2;
// c *= 2; //c = c * 2;
// d /= 2; //d = d / 2;
// e %= 2; //e = e % 2;
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(d);
// Console.WriteLine(e);


//Operadores unários de incremento e decremento:
//===================================================================

// var a = 5;
// var b = 5;


//Pós fixada:
// a++; //a = a + 1
// b--; //b = b - 1
// Console.WriteLine(a);
// Console.WriteLine(b);

//Pré fixada:
// var c = 4;
// var d = 4;
// Console.WriteLine(++c);
// Console.WriteLine(++d);


//Operadores de comparação:
//===================================================================

// ﻿Console.WriteLine(2 == 2);
// var a = 2;
// var b = 3;
// var iguais = a == b;
// var diferentes = a != b;
// var maior = a > b;
// var menor = a < b;
// var maiorOuIgual = a >= b;
// var menorOuIgual = a <= b;


// Console.WriteLine(iguais);
// Console.WriteLine(diferentes);
// Console.WriteLine(maior);
// Console.WriteLine(menor);
// Console.WriteLine(maiorOuIgual);
// Console.WriteLine(menorOuIgual);

// Console.WriteLine(a == b);

//Operadores lógicos:
//===================================================================

// var ativo = true;
// Console.WriteLine(ativo);
// var a = 3;
// var b = 6;

//      OPERADOR NOT (NÃO)

// bool choveu = true;
// bool estaTarde = false;

// if(!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar");
// }else{
//     Console.WriteLine("Vou pedalar um outro dia");
// }

// Console.WriteLine(!ativo);
// Console.WriteLine(!(a > b)); //a não é maior que b



//      OPERADOR AND (E)
//--------------------------|
//OP1   | OP2   | RESULTADO |
//--------------------------|
//True  | True  | True      |
//True  | False | False     |
//False | True  | False     |
//False | False | False     |
//--------------------------|

// Console.WriteLine(ativo == true && a > b);

// bool possuiPresencaMininma = false;
// double media = 7.5;

// if(possuiPresencaMininma && media >= 7){
//     Console.WriteLine("Aprovado");
// }else{
//     Console.WriteLine("Reprovado");
// }

//      OPERADOR OR (OU)
//--------------------------|
//OP1   | OP2   | RESULTADO |
//--------------------------|
//True  | True  | True      |
//True  | False | True      |
//False | True  | True      |
//False | False | False     |
//--------------------------|

// Console.WriteLine(ativo == true || a < b);

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel){
//     Console.WriteLine("Entrada liberada");
// }else{
//     Console.WriteLine("Entrada não liberada");
// }