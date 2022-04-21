using IO;
using Generator;


var console= new AppConsole();
var primeNumbersGenerator = new PrimeNumbersGenerator();
var multiplicationTabelGenerator = new MultiplicationTableGenerator();


int n = console.ReadNum();

var primeNUmbers = primeNumbersGenerator.Generate(n);
var matrix = multiplicationTabelGenerator.Generate(primeNUmbers);

AppConsole.PrintMatrix(matrix);




