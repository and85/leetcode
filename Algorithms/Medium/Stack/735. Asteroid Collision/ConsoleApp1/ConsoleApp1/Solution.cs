using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var asteroidStack = new Stack<int>();
            foreach (int asteroid in asteroids)
            {
                PushToStack(asteroid, asteroidStack);
            }

            var afterColisionArray = asteroidStack.ToArray();
            Array.Reverse(afterColisionArray);
            return afterColisionArray; 
        }

        private void PushToStack(int asteroid, Stack<int> asteroidStack)
        {
            if (asteroidStack.Count != 0)
            {
                if (IsMoveSameDirection(asteroid, asteroidStack))
                    asteroidStack.Push(asteroid);
                else
                    Collide(asteroid, asteroidStack);

            }
            else
                asteroidStack.Push(asteroid);
        }

        private void Collide(int asteroid, Stack<int> asteroidStack)
        {
            if (asteroidStack.Count == 0)
            {
                asteroidStack.Push(asteroid);
                return;
            }

            int peekDirection = Math.Sign(asteroidStack.Peek());
            int asteroidDirection = Math.Sign(asteroid);

            if ((peekDirection == -1 && asteroidDirection == 1) 
                || (peekDirection == asteroidDirection))
            {
                asteroidStack.Push(asteroid);
                return;
            }

            int peekAbs = Math.Abs(asteroidStack.Peek());
            int asteroidAbs = Math.Abs(asteroid);

            // destroy next asteroid
            if (peekAbs > asteroidAbs)
                return;

            // destroy two 
            if (peekAbs == asteroidAbs)
                asteroidStack.Pop();

            // destroy stack and substitute by next asteroid
            if (peekAbs < asteroidAbs)
            {
                asteroidStack.Pop();
                Collide(asteroid, asteroidStack);
            }

        }

        private bool IsMoveSameDirection(int asteroid, Stack<int> asteroidStack)
        {
            return Math.Sign(asteroid) == Math.Sign(asteroidStack.Peek());
        }
    }
}
