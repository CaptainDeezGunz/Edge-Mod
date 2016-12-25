﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EdgeMod.Items.Weapons
{
    //imported from my tAPI mod because I'm lazy
    public class ButterflyStaff : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Butterfly Staff";
            item.damage = 5;
            item.summon = true;
            item.mana = 10;
            item.width = 88;
            item.height = 88;
            item.toolTip = "Butterflies!! Yaaaay!";
            item.useTime = 36;
            item.useAnimation = 36;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 30, 0, 0);
            item.rare = 9;
            item.UseSound = SoundID.Item44;
            item.shoot = mod.ProjectileType("PurityWisp");
            item.shootSpeed = 10f;
            item.buffType = mod.BuffType("PurityWisp");
            item.buffTime = 3600;
        }
    }
}