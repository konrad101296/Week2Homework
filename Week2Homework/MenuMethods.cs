using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Homework
{
    public class MenuMethods
    {
        List<MenuProperties> menuList;
        public MenuMethods()
        {
            menuList = new List<MenuProperties>();
        }
        
        public void AddNewMenuOption(int id, string name)
        {
            MenuProperties menuOption = new MenuProperties() { Id = id, Name = name };
            menuList.Add(menuOption);
        }
        
        public List<MenuProperties> MenuListOptions()
        {
            Console.WriteLine("Welcome in your used car dealer");
            Console.WriteLine("Choose what you wanna do...");

            foreach (var item in menuList)
            {
                Console.WriteLine($"{item.Id}{"."}{item.Name}");
            }

            Console.WriteLine("Press the apropriate number...");

            return menuList;
        }
    }
}


