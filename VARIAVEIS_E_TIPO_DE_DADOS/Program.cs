//Declaração de variáveis:
   
short idadeShort = 1; //16 bits
int idadeInt = 2; //32 bits
long idadeLong = 3; //64 bits

float valorFloat; //4 bytes
double valorDouble;   //8 bytes
decimal ValorDecimal; //16 bytes

bool ehVerdadeiro; //1 bit

char sim = 's'; //2 bytes
string texto = "Gabriel"; //2 bytes por caractere
Console.WriteLine(texto);

//Inferência de tipo:

string sobrenome = "Gabriel";
var nome = "Lira";
//var nomeSemAtribuirOValor;

//Conversões de tipos:

//Conversão implícita:

//Jeito certo:
int ano = 2020;
float ano2 = ano;
Console.WriteLine(ano2);

//Jeito errado:
//double mes = 12;
//int mes2 = mes;

//Conversão explícita:

//Jeito certo:
double mes = 12;
int mes2 = (int)mes;
Console.WriteLine(mes2);

//Jeito errado:
//double mes = 12;
//string mes2 = (string)mes;

//Conversão para string:
double dia = 12;
string dia2 = dia.ToString();

DateTime data = DateTime.Now;
string data2 = data.ToString();

//Conversão com Parse:

string resposta = "12";
int anos = int.Parse(resposta);

//Conversão com Convert:

string resposta2 = "11";
int anos2 = Convert.ToInt32(resposta2);

//O tipo String:

// var nome = "Gabriel";
// var sobrenome = "Lira";

// var nomeCompleto = nome + " " + sobrenome;
// var nomeCompletoInterpolado = $"{nome} {sobrenome}.";
// Console.WriteLine(nomeCompleto);
// Console.WriteLine(nomeCompletoInterpolado);
// //Caixa alta, caixa menor:
// Console.WriteLine(nomeCompleto.ToUpper());
// Console.WriteLine(nomeCompleto.ToLower());
// //Pegar uma parte da string:
// Console.WriteLine(nomeCompleto.Substring(8));
// Console.WriteLine(nomeCompleto.Substring(8, 4));
// //Se contém na string:
// Console.WriteLine(nomeCompleto.Contains('o'));
// Console.WriteLine(nomeCompleto.Contains("Li"));
// //Se começa com ou se termina com:
// Console.WriteLine(nomeCompleto.StartsWith("G"));
// Console.WriteLine(nomeCompleto.EndsWith("e"));
// //Primeira posição de um determinado caractere:
// Console.WriteLine(nomeCompleto.IndexOf("i"));
// //Ultima posição de um determinado caractere:
// Console.WriteLine(nomeCompleto.LastIndexOf("i"));

//O tipo DateTime:

// var hoje = DateTime.Today;
// var agora = DateTime.Now;
// Console.WriteLine(hoje);
// Console.WriteLine(agora);

// var data1 = new DateTime(2020, 03, 11);
// var data2 = new DateTime(2023, 11, 30, 11, 20, 11);
// var data3 = DateTime.Parse("15/11/2023 12:43:50");
// Console.WriteLine(data1);
// Console.WriteLine(data2);
// Console.WriteLine(data3);

// Console.WriteLine(data3.Day);
// Console.WriteLine(data3.Month);
// Console.WriteLine(data3.Year);
// Console.WriteLine(data3.Hour);
// Console.WriteLine(data3.Second);

// Console.WriteLine(data3.AddDays(5));
// Console.WriteLine(data3.AddMonths(-1));

// Console.WriteLine(data3.ToLongDateString());
// Console.WriteLine(data3.ToLongTimeString());
// Console.WriteLine(data3.ToShortDateString());
// Console.WriteLine(data3.ToShortTimeString());


//Array:

// int[] numeros = new int[3];
// numeros[0] = 10;
// numeros[1] = 20;
// numeros[2] = 30;

// Console.WriteLine(numeros[0]);
// Console.WriteLine(numeros[1]);
// Console.WriteLine(numeros[2]);

// int[] pares = new int[3] {2, 4, 6};
// Console.WriteLine(pares[0]);
// Console.WriteLine(pares[1]);
// Console.WriteLine(pares[2]);

// int[] impares = new int[] {3, 5, 7, 9};
// Console.WriteLine(impares[0]);
// Console.WriteLine(impares[1]);
// Console.WriteLine(impares[2]);
// Console.WriteLine(impares[3]);

// string[] nomes = new [] {"Gabriel", "Verônica", "João"};
// Console.WriteLine(nomes[0]);
// Console.WriteLine(nomes[1]);
// Console.WriteLine(nomes[2]);

// string[] paises = {"Brasil", "EUA", "França"};
// Console.WriteLine(paises[0]);
// Console.WriteLine(paises[1]);
// Console.WriteLine(paises[2]);

// var cidades = new [] {"Patos", "Sousa", "João Pessoa", "Pombal"};
// Console.WriteLine(cidades[0]);
