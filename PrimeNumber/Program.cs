using System;
using PrimeNumber.Models;
using System.Collections.Generic;

namespace PrimeNumber
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a Number:");
            int enteredInt = int.Parse(Console.ReadLine());
            PrimeNum newPrime = new PrimeNum();
            Dictionary<int, string> allNumbers = new Dictionary<int, string>() { };
            allNumbers = newPrime.GenNumber(enteredInt);
            List<int> primeNumbers = new List<int> { };
            List<int> compositeNumbers = new List<int> { };
            int counter = 0;
            int currentKey = 0;
            int init = 1;
            for (int i = 2; i <= enteredInt; i++)
            {
                counter = 0;
                currentKey = i;
                init = init + 1;
                for (int k = init; k <= allNumbers.Count; k++)
                //a) IF Loop: you are marking VERY FIRST ENTRY as "prime" (if its NOT already marked as "composite") 
                //b) iterate thru rest of entries identify multiples and mark them as "composite"
                {
                    if ((counter == 0) && (allNumbers[k] == "unProcessed"))
                    {
                        primeNumbers.Add(k);
                        allNumbers[k] = "Prime";
                        counter = 1;
                        // Console.WriteLine(k + " is a Prime");

                    }
                    else
                    {
                        if (((k % currentKey) == 0))
                        {
                            allNumbers[k] = "composite";
                            compositeNumbers.Add(k);
                            // Console.WriteLine(k + " is a composite");
                        }
                        else
                        {
                            // Console.WriteLine(k + " remains unprocessed");
                        }
                    }
                }
            }
            Console.WriteLine("Prime numbers are ...");
            Console.WriteLine(String.Join(", ", primeNumbers));
            Console.WriteLine("Composite numbers are ...");
            Console.WriteLine(String.Join(", ", compositeNumbers));
        }
    }
}
