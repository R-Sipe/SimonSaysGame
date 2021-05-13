using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysGame
{
    public enum Directions { Up = 0, Right = 1, Down = 2, Left = 3, Unknown = 4}
    public class SimonGame
    {
        public bool GameOver { get; private set; }

        //constructor

        //properties
        public List<int> _gamePattern = new List<int> { };  


        public int _scoreCounter = -1;
        private int guessPosition = 0;

        //methods
        public void GenerateNextNumber()
        {
            Random rand = new Random();
            int nextNum = rand.Next(4);
            _gamePattern.Add(nextNum);
            guessPosition = 0;
            _scoreCounter++;
        }

        public void CheckGuess(Directions input)
        {
            if (_gamePattern[guessPosition] == (int)input)
            {
                guessPosition++;
            }
            else
            {
                GameOver = true;
            }
        }
        //method to receive and convert input

        public Directions InputDirection()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    return Directions.Up;
                case ConsoleKey.RightArrow:
                    return Directions.Right;
                case ConsoleKey.DownArrow:
                    return Directions.Down;
                case ConsoleKey.LeftArrow:
                    return Directions.Left;
                default:
                    return Directions.Unknown;
            }
        }

        public List<int> ReturnGamePattern()
        {
            return _gamePattern;
        } 

        public int ReturnScoreCounter()
        {
            return _scoreCounter;
        }

        //method to playback current game pattern (Simon's turn)






        //method to playback user input in real time DO LATER
        //Keep DPad visible during flash and user input



    }
}