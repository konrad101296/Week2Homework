using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Homework
{
    public class BodyType
    {
        public string[] ArrayBodyType()
        {
            string[] arrayBodyType = { "Small Car", "City Car", "Coupe", "Convertible", "Estate", "Compact", "Minivan", "Saloon", "SUV" };

            return arrayBodyType;
        }

        public int NumberCarBodyType(string[] arrayBodyType)
        {
            int parsedChoosenBodyNumber = 0;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Please enter body type, press the appropriate number...");

                int order = 0;
                foreach (var item in arrayBodyType)
                {
                    order++;
                    Console.WriteLine(order + " " + item);
                }
                var choosenBodyType = Console.ReadLine();

                Int32.TryParse(choosenBodyType, out parsedChoosenBodyNumber);
                if (parsedChoosenBodyNumber < 1 || parsedChoosenBodyNumber > 9)
                {
                    Console.WriteLine("You chose a bad number try agien...");
                    i--;
                }
            }
            return parsedChoosenBodyNumber;
        }

        public string NameCarBodyType(int parsedChoosenBodyType, string[] arrayBodyType)
        {
            int arrayCountdown = 0;
            string choosenArrayName = null;
            foreach (var item in arrayBodyType)
            {
                arrayCountdown++;
                if (arrayCountdown == parsedChoosenBodyType)
                {
                    choosenArrayName = item;
                    break;
                }
            }
            return choosenArrayName;
        }
    }
}
