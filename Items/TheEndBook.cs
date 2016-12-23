
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Edge.Items
{
    public class TheEndBook : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "The End Book";
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("You Will Need This Book All The Way Through The Game");
            item.value = 100;
            item.rare = 1;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine line = new TooltipLine(mod, "TheEndBook", "DON'T LOSE THIS!!!");
            line.overrideColor = new Color(140, 1, 1);
            tooltips.Add(line);
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
                }
            }
        }
    }
}