using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SolutionAttempt2
    {
        int _primeCounter = 0;
        int[] _primes = new int[30000];

        public int CountPrimes(int n)
        {
            _primes[_primeCounter++] = 2;
            _primes[_primeCounter++] = 3;
            _primes[_primeCounter++] = 5;
            _primes[_primeCounter++] = 7;
            _primes[_primeCounter++] = 11;
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i)) count++;
            }

            return count;
        }

        //List<int> _primes = new List<int>() { 2, 3, 5, 7, 11};
        

        private bool IsPrime(int num)
        {
            if (num <= 11)
            {
                if (_primes.Contains(num))
                    return true;
                else 
                    return false;
            }            
            
            for (int p = 0; p < _primeCounter; p++)
            {                
                if (num % _primes[p] == 0) return false;
            }


            //_primes.Add(num);
            _primes[_primeCounter++] = num;
            return true;

        }


        private bool IsPrimeSlow(int num)
        {
            if (num == 1) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false; 
            }

            return true;

        }
    }
}
