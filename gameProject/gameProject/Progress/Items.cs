namespace Pro
{
    internal class Items
    {
        public Dictionary<string, Item> _items;
        public int itemCount = 0;
        public Items()
        {
            _items = new Dictionary<string, Item>();
            start();
        }
        
        public void start()
        {
            HealingPotion();
            AmetystVest();
            TopazAmulet();
            QuartzEnhancer();
            DiamondSharpener();
            FeatherOfHatred();
            Map();
        }
        public void HealingPotion()
        {
            Item pot = new Item();
            pot.name = "Healing Potion";
            pot.description = "This mystic beverage made by possibly living creatures' blood regenerates you instantly when used";
            pot.price = 1150;
            pot.hpRegen = 90;
            _items["1"] = pot;
            itemCount = itemCount + 1;
        }
        public void AmetystVest()
        {
            Item vest = new Item();
            vest.name = "Ametyst Vest";
            vest.description = "The magic of vest will surround you and enhance you";
            vest.price = 12630;
            vest.hpIncrease = 40;
            vest.hpRegen = 40;
            _items["2"] = vest;
            itemCount = itemCount + 1;
        }


        public void TopazAmulet()
        {
            Item tAmu = new Item();
            tAmu.name = "Topaz Amulet";
            tAmu.description = "This amulet enhanced with a topaz crystal will protect you from danger";
            tAmu.price = 4200;
            tAmu.dpIncrease = 6;
            _items["3"] = tAmu;
            itemCount = itemCount + 1;
        }

        public void QuartzEnhancer()
        {
            Item qSharp = new Item();
            qSharp.name = "Quartz Repair Kit";
            qSharp.description = "With this kit applied on your weapon you will use your magic way better";
            qSharp.price = 9600;
            qSharp.spIncrease = 7;
            _items["4"] = qSharp;
            itemCount = itemCount + 1;
        }

        public void DiamondSharpener()
        {
            Item diaS = new Item();
            diaS.name = "Diamond Sharpener";
            diaS.description = "Your weapons will be shinier than even before";
            diaS.price = 16420;
            diaS.apIncrease = 9;
            _items["5"] = diaS;
            itemCount = itemCount + 1;
        }

        public void FeatherOfHatred()
        {
            Item foh = new Item();
            foh.name = "Feather of Hatred";
            foh.description = "A feather of Elder dragon that drove the entire planet into chaos, will be helpful to think fast";
            foh.price = 9400;
            foh.aspeedIncrease = 0.2f;
            _items["6"] = foh;
            itemCount = itemCount + 1;
        }

        public void Map()
        {
            Item map = new Item();
            map.name = "Map";
            map.description = "This is a paper map that tells the spots";
            map.price = 1000;
            _items["7"] = map;
            itemCount = itemCount + 1;
        }

    }
}
