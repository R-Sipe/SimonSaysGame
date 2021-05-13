using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimonSaysGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSaysGame.Tests
{
    [TestClass()]
    public class SimonDisplayTests
    {
        [TestMethod()]
        public void DisplayDpadTest()
        {
            SimonDisplay newDisplay = new SimonDisplay();
            newDisplay.DisplayDpad();
            Console.ReadLine();
        }
    }
}