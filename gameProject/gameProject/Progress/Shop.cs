using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Shop : Game 
    {
        string[] itemsForSale = {"Healing Potion", "Offensive Upgrade","Defensive Upgrade", "Attack Speed Upgrade", };
        Items items = new Items();

        public Shop()
        {

        }
        
        public void print()
        {
            wr.n();
            Console.WriteLine("These are the items on sale");

            for (int i = 1; i <= items.itemCount; i = i + 1)
            {
                string qi = i.ToString(); 
                items._items.TryGetValue(qi, out Item aytım);
                Console.WriteLine($"{i} - {aytım.name}");
            }
            Console.WriteLine("Type 'quit' or '0' to quit the shop");
            getItem();
        }
        
        void getItem()
        {
            string q1;

            while (true)
            {
                q1 = wr.read();
                if (items._items.TryGetValue(q1, out Item aytım))
                {
                    if (aytım.price <= Money)
                    {
                        Console.WriteLine($"You have purchased {aytım.name} successfuly");
                        Hp = Hp + aytım.hpIncrease;
                        effects.healing(aytım.hpRegen);
                        Ap = Ap + aytım.apIncrease;
                        Sp = Sp + aytım.spIncrease;
                        Dp = Dp + aytım.dpIncrease;
                        ASpeed = ASpeed + aytım.aspeedIncrease;
                        Money = Money - aytım.price;

                        break;
                    }
                    else
                    {
                        wr.n();
                        Console.WriteLine("You have not enough money for that item");
                    }

                }
                else if (q1 == "quit" || q1 == "Quit" || q1 == "0" ) 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("No item selected");
                }
                
            }
        }
    }
}

