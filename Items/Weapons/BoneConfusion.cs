using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Edge.Items.Weapons
{
    class BoneConfusion : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bone Confusion";
            item.value = 10000;
            item.useStyle = 4;
            item.useAnimation = 20;
            item.useTime = 20;
            item.consumable = false;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 4;
            item.toolTip = "Fires spectral bones that shatter on impact";
            item.maxStack = 1;
            item.width = 28;
            item.height = 30;
            item.shoot = 1; //wooden arrow - not pernament
            item.shootSpeed = 20;
            item.toolTip2 = "Ancient, forgotten bones are starting to move...";
            item.noMelee = true;
            item.magic = true;
            item.mana = 10;
            item.damage = 10;
            item.knockBack = 10;
            item.glowMask = 90;
            item.stack = 1;
        }
    }
}
