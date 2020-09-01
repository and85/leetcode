using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private const string ZeroStr = "Zero";
        private const string BillionStr = "Billion";
        private const string MillionStr = "Million";
        private const string ThousandStr = "Thousand";
        private const string HundredStr = "Hundred";

        private const int BillionInt = 1000_000_000;
        private const int MillionInt = 1000_000;
        private const int ThousandInt = 1000;
        private const int HundredInt = 100;
        private const int TenInt = 10;
        private const int NonRecursiveNumber = 21;

        Dictionary<int, string> _wordsMap = new Dictionary<int, string>()
        {
            { 0, ZeroStr },
            { 1, "One" },
            { 2, "Two" },
            { 3, "Three" },
            { 4, "Four" },
            { 5, "Five" },
            { 6, "Six" },
            { 7, "Seven" },
            { 8, "Eight" },
            { 9, "Nine" },
            { 10, "Ten" },
            { 11, "Eleven" },
            { 12, "Twelve" },
            { 13, "Thirteen" },
            { 14, "Fourteen" },
            { 15, "Fifteen" },
            { 16, "Sixteen" },
            { 17, "Seventeen" },
            { 18, "Eighteen" },
            { 19, "Nineteen" },
            { 20, "Twenty" },
            { 30, "Thirty" },
            { 40, "Forty" },
            { 50, "Fifty" },
            { 60, "Sixty" },
            { 70, "Seventy" },
            { 80, "Eighty" },
            { 90, "Ninety" },
        };


        public string NumberToWords(int num)
        {
            string result;
            string endingZero = $" {ZeroStr}";

        // recursively devide input number until we reach the biggest number that could be get without recursion 
        if (num >= BillionInt)
        {
            result = NumberToWords(num / BillionInt) + $" {BillionStr} " + NumberToWords(num % BillionInt);
            return result.Replace(endingZero, string.Empty);
        }
        if (num >= MillionInt)
            {
                result = NumberToWords(num / MillionInt) + $" {MillionStr} " + NumberToWords(num % MillionInt);
                return result.Replace(endingZero, string.Empty);
            }
            if (num >= ThousandInt)
            {
                result = NumberToWords(num / ThousandInt) + $" {ThousandStr} " + NumberToWords(num % ThousandInt);
                return result.Replace(endingZero, string.Empty);
            }
            if (num >= HundredInt)
            {
                result = NumberToWords(num / HundredInt) + $" {HundredStr} " + NumberToWords(num % HundredInt);
                return result.Replace(endingZero, string.Empty);
            }
            if (num >= NonRecursiveNumber)
            {
                result = _wordsMap[num / TenInt * TenInt] + " " + _wordsMap[num % TenInt];
                return result.Replace(endingZero, string.Empty);
            }

            return _wordsMap[num];
        }
    }
}
