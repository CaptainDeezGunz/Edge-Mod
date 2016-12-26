using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Edge.Items
{
    public class DuckCall : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.name = "Duck Call";
            item.width = 28;
            item.height = 28;
            item.toolTip = "Summons a pet Duck that will follow you.";
            item.shoot = mod.ProjectileType("Duck");
            item.buffType = mod.BuffType("DuckBuff");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}
