# Elando application
---
## About: 
Applicaiton prints out a multiplication table of the first N prime numbers. The first row and column of the table have the N primes, with each cell containing the product of the primes for the corresponding row and column.

#### Example input: 
```
N = 5
```
#### Example output:
```
┌────┬────┬────┬────┬────┬─────┐
│    │ 2  │ 3  │ 5  │ 7  │ 11  │
├────┼────┼────┼────┼────┼─────┤
│ 2  │ 4  │ 6  │ 10 │ 14 │ 22  │
├────┼────┼────┼────┼────┼─────┤
│ 3  │ 6  │ 9  │ 15 │ 21 │ 33  │
├────┼────┼────┼────┼────┼─────┤
│ 5  │ 10 │ 15 │ 25 │ 35 │ 55  │
├────┼────┼────┼────┼────┼─────┤
│ 7  │ 14 │ 21 │ 35 │ 49 │ 77  │
├────┼────┼────┼────┼────┼─────┤
│ 11 │ 22 │ 33 │ 55 │ 77 │ 121 │
└────┴────┴────┴────┴────┴─────┘
```
---
<br/>
<div align="right">
    <b><a href="#----">↥ back to top</a></b>
</div>
<br/>

## App use 
#### Table Console View
Use [ConsoleTable](https://github.com/BrunoVT1992/ConsoleTable) code.

#### Prime Algorithm: 
"...A simple but slow method of checking the primality of a given number N, called trial division, tests whether N is a multiple of any integer between 2 and  Math.Sqrt(N)..."  get from [Wikipedia Prime Number](https://en.wikipedia.org/wiki/Prime_number)
``` 
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(N); i++)
                if (N % i == 0)
                {
                    {
                        isPrime = false;
                        break;
                    }
                }
            return isPrime;
```
---
<br/>
<div align="right">
    <b><a href="#----">↥ back to top</a></b>
</div>
<br/>

## Built With:
 - Console Applicaion net6.0
 - MSTest
---
<br/>
<div align="right">
    <b><a href="#----">↥ back to top</a></b>
</div>
<br/>
 
## App works:
 -  "Read" till input valid positive Integer;
 -  Get first N count of Primes;
 -  Print table view result by Matrix model as example output;
---
 <br/>
<div align="right">
    <b><a href="#----">↥ back to top</a></b>
</div>
<br/>
                                                                                    
## App has 2 versions:
---
 - [v 1.0](https://github.com/knaevKMK/Elando/tree/v_1.0): app read N number, get first N count of Primes, generate Matrix and print it;
 - [v 2.0](https://github.com/knaevKMK/Elando/tree/v_2.0): app read N number, get first N count of Primes and print result by Matrix model as example output.
 - [current v 2.1](https://github.com/knaevKMK/Elando/tree/v_2.1): app read N number, get first N count of Primes and print table-view result by Matrix model as example output.

---
<br/>
<div align="right">
    <b><a href="#----">↥ back to top</a></b>
</div>
<br/>
