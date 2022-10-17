using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Menu
{
    [XmlType("food")]
    public class Food
    {
        public static List<Food> BreakfastMenu = new List<Food>();

        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("price")]
       public string Price { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("calories")]
        public int Calories { get; set; }

        public static void AddToMenu(Food food)
        {
            BreakfastMenu.Add(food);
            XmlHelper.SaveMenuItems(BreakfastMenu);
        }

        public static void LoadMenu()
        {
            BreakfastMenu.AddRange(XmlHelper.LoadMenuItems());
        }
    }
}
