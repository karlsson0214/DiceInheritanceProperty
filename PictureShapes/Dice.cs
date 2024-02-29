using System;

namespace DiceApp
{
    class Dice
    {
        private Square dice;
        // din kod här

        // number of dots to display
        private int number;

        private static Random randomGenerator;

        public Dice()
        {
            
            randomGenerator = new Random();
            // din kod här
        }
        

        /// <summary>
        /// Roll the die. The new value is displayed.
        /// </summary>
        public void Roll()
        {
            // din kod här
        }

        private bool IsOdd(int number)
        {
            return number % 2 == 1;
        }


    }
}
