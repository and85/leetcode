using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class StockSpanner
    {
        public class Price
        {
            public Price(int value, int lessCounter)
            {
                Value = value;
                LessCounter = lessCounter;
            }

            public int Value { get; set; }
            public int LessCounter { get; set; }
        }

        private Stack<Price> _mainStack = new Stack<Price>();

        public StockSpanner()
        {

        }

        public int Next(int price)
        {
            if (_mainStack.Count == 0)
            {
                _mainStack.Push(new Price(price, 1));
                return 1;
            }

            if (_mainStack.Peek().Value > price)
            {
                _mainStack.Push(new Price(price, 1));
                return 1;
            }

            int lessCounter = 0;
            while (_mainStack.Count > 0 && _mainStack.Peek().Value <= price)
            {
                Price popPrice =_mainStack.Pop();
                lessCounter += popPrice.LessCounter;
            }
        
            _mainStack.Push(new Price(price, ++lessCounter));

            return lessCounter;
        }
    }
}
