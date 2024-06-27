using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Homework
{
    public class BodyType
    {
        public string[] BoardBodyType()
        {
            string[] boardBodyType = { "Small Car", "City Car", "Coupe", "Cabriolet", "Combi", "Compact", "Minivan", "Sedan", "SUV" };

            return boardBodyType;
        }
        public int NumberCarBodyType(string[] boardBodyType)
        {
            int parsedChoosenBodyNumber = 0;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Please enter body type, press the appropriate number...");

                int order = 0;
                foreach (var item in boardBodyType)
                {
                    order++;
                    Console.WriteLine(order + " " + item);
                }
                var choosenBodyType = Console.ReadLine();

                Int32.TryParse(choosenBodyType, out parsedChoosenBodyNumber);
                if (parsedChoosenBodyNumber < 1 || parsedChoosenBodyNumber > 9)
                {
                    Console.WriteLine("You choosen bad number try agien...");
                    i--;
                }
            }
            return parsedChoosenBodyNumber;
        }
        public string NameCarBodyType(int parsedChoosenBodyType, string[] boardBodyType)
        {
            int boardCountdown = 0;
            string choosenBoardName = null;
            foreach (var item in boardBodyType)
            {
                boardCountdown++;
                if (boardCountdown == parsedChoosenBodyType)
                {
                    choosenBoardName = item;
                    break;
                }
            }
            return choosenBoardName;
        }
    }
}