using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week2Homework
{
    public class CarListMethods
    {
        public List<CarList> carList { get; set; }
        public CarListMethods()
        {
            carList = new List<CarList>();
        }
        public void AddCar(string choosenBoardName)
        {
            CarList newCar = new CarList();

            newCar.CarBodyType = choosenBoardName;

            Console.WriteLine("Please enter registration number");
            string registrationNumber = Console.ReadLine();
            newCar.RegistrationNumber = registrationNumber;

            Console.WriteLine("Please enter car brand");
            string carBrand = Console.ReadLine();
            newCar.CarBrand = carBrand;

            Console.WriteLine("Please enter car model");
            string carModel = Console.ReadLine();
            newCar.CarModel = carModel;

            Console.WriteLine("Please enter car price");
            string carPrice = Console.ReadLine();
            newCar.CarPrice = carPrice;

            carList.Add(newCar);
        }
        public void DeleteCar()
        {
            CarList carToRemove = new CarList();
            int notFaund = 0;

            Console.WriteLine("Please enter car registration number you want to delete");
            string registrationNumberToDelete = Console.ReadLine();

            foreach (var item in carList)
            {
                if (item.RegistrationNumber == registrationNumberToDelete)
                {
                    notFaund++;
                    carToRemove = item;
                    Console.WriteLine("Car deleted");
                    break;
                }
            }
            if (notFaund == 0)
            {
                Console.WriteLine("Registration number you entered does not exist try agien...");
            }
            carList.Remove(carToRemove);
        }
        public void CheckCar()
        {
            CarList carToCheck = new CarList();
            int notFaund = 0;
            Console.WriteLine("Please enter car registration number you want to check");
            string registrationNumberToCheck = Console.ReadLine();

            foreach (var item in carList)
            {
                if (registrationNumberToCheck == item.RegistrationNumber)
                {
                    notFaund++;
                    carToCheck = item;
                    break;
                }
            }
            if (notFaund == 0)
            {
                Console.WriteLine("Registration number you entered does not exist try agien...");
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Car body type: {carToCheck.CarBodyType}");
                Console.WriteLine($"Car brand: {carToCheck.CarBrand}");
                Console.WriteLine($"Car model: {carToCheck.CarModel}");
                Console.WriteLine($"Car price: {carToCheck.CarPrice}");
                Console.WriteLine("------------------------------");
            }
        }
        public void CheckAllCars()
        {
            Console.WriteLine("------------------------------");
            foreach (var item in carList)
            {
                Console.WriteLine($"Car registration number: {item.RegistrationNumber}");
                Console.WriteLine($"Car body type: {item.CarBodyType}");
                Console.WriteLine($"Car brand: {item.CarBrand}");
                Console.WriteLine($"Car model: {item.CarModel}");
                Console.WriteLine($"Car price: {item.CarPrice}");
                Console.WriteLine("------------------------------");
            }
        }
        public void ChangeCarSettings(string carToChange)
        {
            CarList changedCar = new CarList();

            int notFaund = 0;

            foreach (var item in carList)
            {
                if (item.RegistrationNumber == carToChange)
                {
                    notFaund++;
                    changedCar = item;
                    break;
                }
            }
            if (notFaund == 0)
            {
                Console.WriteLine("Registration number you entered does not exist try agien...");
            }
            carList.Remove(changedCar);
        }
        public void AddChangedCar(string choosenBoardName2, string carToChange)
        {
            CarList changedCar = new CarList();

            changedCar.RegistrationNumber = carToChange;

            changedCar.CarBodyType = choosenBoardName2;

            Console.WriteLine("Please enter car brand");
            string carBrand = Console.ReadLine();
            changedCar.CarBrand = carBrand;

            Console.WriteLine("Please enter car model");
            string carModel = Console.ReadLine();
            changedCar.CarModel = carModel;

            Console.WriteLine("Please enter car price");
            string carPrice = Console.ReadLine();
            changedCar.CarPrice = carPrice;

            carList.Add(changedCar);
        }
        public int CheckPresenceOnList(string carToChange)
        {

            int checkPresence = 0;
            foreach (var item in carList)
            {
                if (item.RegistrationNumber == carToChange)
                {
                    checkPresence++;
                    break;
                }
            }
            return checkPresence;
        }

        public string ChoosenCarToChange()
        {
            Console.WriteLine("Please enter registration number of car you want to change");
            string carToChange = Console.ReadLine();

            return carToChange;
        }
    }
}