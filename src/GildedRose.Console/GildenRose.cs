using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public static class GildenRose
    {
        public static void UpdateQuality(IList<Item> Items)
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if((Items[i].Name == "Aged Brie") 
                || (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert"))
                {
                    if(Items[i].SellIn > 0)
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality++;
                        }

                        if (Items[i].SellIn < 11)
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality++;
                            }
                        }

                        if (Items[i].SellIn < 6)
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality++;
                            }
                        }
                    }
                    else
                    {
                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            Items[i].Quality = 0;
                        }
                    }
                }
                else if(Items[i].Name == "Conjured Mana Cake")
                {
                    if (Items[i].Quality > 0)
                    {
                        Items[i].Quality -= 2;
                        if(Items[i].Quality < 0) 
                        { 
                            Items[i].Quality = 0; 
                        }
                    }
                }
                else if(Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    if(Items[i].Quality > 0)
                    {
                        Items[i].Quality--;
                    }     
                }

                if ((Items[i].SellIn < 0) && (Items[i].Quality > 0))
                {
                    Items[i].Quality--;
                }

                Items[i].SellIn--;
            }
        }
    }
}
