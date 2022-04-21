using IO;
using Generator;


var console= new AppConsole();
var primeNumbersGenerator = new PrimeNumbersGenerator();
var multiplicationTabelGenerator = new MultiplicationTableGenerator();


int n = console.Read();

var primeNUmbers = primeNumbersGenerator.Generate(n);
var matrix = multiplicationTabelGenerator.Generate(primeNUmbers);

AppConsole.Print(primeNUmbers);




