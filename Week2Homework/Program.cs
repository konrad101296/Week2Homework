using System.Collections.Generic;
using System.Diagnostics;

namespace Week2Homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuMethods menuMethods = new MenuMethods();

            BodyType bodyType = new BodyType();

            CarListMethods carListMethods = new CarListMethods();

            menuMethods = MenuOptions(menuMethods);

            while (true)
            {
                menuMethods.MenuListOptions();

                string choosenMenuCathegory = Console.ReadLine();

                int parsedMenuCathegory;

                Int32.TryParse(choosenMenuCathegory, out parsedMenuCathegory);

                switch (parsedMenuCathegory)
                {
                    case 1:
                        var boardBodyType = bodyType.BoardBodyType();
                        var parsedChoosenBodyNumber = bodyType.NumberCarBodyType(boardBodyType);
                        var choosenBoardName = bodyType.NameCarBodyType(parsedChoosenBodyNumber, boardBodyType);
                        carListMethods.AddCar(choosenBoardName);
                        break;
                    case 2:
                        carListMethods.DeleteCar();
                        break;
                    case 3:
                        carListMethods.CheckCar();
                        break;
                    case 4:
                        carListMethods.CheckAllCars();
                        break;
                    case 5:
                        var carToChange = carListMethods.ChoosenCarToChange();
                        var checkPresence = carListMethods.CheckPresenceOnList(carToChange);
                        carListMethods.ChangeCarSettings(carToChange);
                        if (checkPresence == 1)
                        {
                            var boardBodyType2 = bodyType.BoardBodyType();
                            var parsedChoosenBodyNumber2 = bodyType.NumberCarBodyType(boardBodyType2);
                            var choosenBoardName2 = bodyType.NameCarBodyType(parsedChoosenBodyNumber2, boardBodyType2);
                            carListMethods.AddChangedCar(choosenBoardName2, carToChange);
                        }
                        break;
                    default:
                        Console.WriteLine("You press wrong key try agien");
                        break;
                }
            }
        }
        public static MenuMethods MenuOptions(MenuMethods menuMethods)
        {
            menuMethods.AddNewMenuOption(1, "Add car");
            menuMethods.AddNewMenuOption(2, "Remove car");
            menuMethods.AddNewMenuOption(3, "Check a specific car");
            menuMethods.AddNewMenuOption(4, "Check your cars");
            menuMethods.AddNewMenuOption(5, "Change car settings");
            return menuMethods;
        }
    }
}
