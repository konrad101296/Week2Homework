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

            bool exit = true;

            while (exit)
            {
                menuMethods.MenuListOptions();

                string choosenMenuCathegory = Console.ReadLine();

                int parsedMenuCathegory;

                Int32.TryParse(choosenMenuCathegory, out parsedMenuCathegory);

                switch (parsedMenuCathegory)
                {
                    case 1:
                        var arrayBodyType = bodyType.ArrayBodyType();
                        var parsedChoosenBodyNumber = bodyType.NumberCarBodyType(arrayBodyType);
                        var choosenArrayName = bodyType.NameCarBodyType(parsedChoosenBodyNumber, arrayBodyType);
                        carListMethods.AddCar(choosenArrayName);
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
                            var arrayBodyType2 = bodyType.ArrayBodyType();
                            var parsedChoosenBodyNumber2 = bodyType.NumberCarBodyType(arrayBodyType2);
                            var choosenArrayName2 = bodyType.NameCarBodyType(parsedChoosenBodyNumber2, arrayBodyType2);
                            carListMethods.AddChangedCar(choosenArrayName2, carToChange);
                        }
                        break;
                    case 6:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("You pressed a wrong key try agien");
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
            menuMethods.AddNewMenuOption(6, "Exit from application");
            return menuMethods;
        }
    }
}
