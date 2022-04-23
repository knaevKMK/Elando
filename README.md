# Elando application v 1.0 that prints out a multiplication table of the first N prime numbers.
* The first row and column of the table have the N primes, with each cell containing the product of the primes for the corresponding row and column.

Example input: 
```
N = 4
```
Example output:
```
    2   3   5   7  
2   4   6   10  14 
3   6   9   15  21 
5   10  15  25  35 
7   14  21  35  49 
```

App use 
## Prime Algorithm: 
``` bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                {
                    {
                        isPrime = false;
                        break;
                    }
                }
            return isPrime;
```

## App works:
 -  "Read" till input valid positive Integer;
 -  Get first N count of Primes;
 -  Generate Matrix and keep all data;
 -  Print data from Matrix;

## Also look
 - [App v 2.0](https://github.com/knaevKMK/Elando/tree/v_2.0): app read N number, get first N count of Primes and print result by Matrix model as example output.

