// Tipos de dados

string nome = "Felipe";
Console.WriteLine($"O nome do usuário é: {nome}");

int idade = 22;
//Console.WriteLine("A idade do usuário é: " + idade + "anos");
Console.WriteLine($"A idade do usuário é: {idade} anos");

float carteira = 2.63f;

char classificacao = 'A';
Console.WriteLine($"O cliente é do tipo {classificacao}");

bool dinheironaconta = true;
Console.WriteLine(dinheironaconta);

double limiteCredito = 2000.0;
Console.WriteLine("Seu limite de crédito é: " + limiteCredito);

string sobrenome = " Souza";

string nomecompleto = nome + sobrenome;
Console.WriteLine(nomecompleto);

double valorconta = 53.73;
Console.WriteLine($"Ovalor na conta é: {valorconta}");

double limitetotal = valorconta + limiteCredito;
Console.WriteLine($"O saldo + limite é {limitetotal}");
