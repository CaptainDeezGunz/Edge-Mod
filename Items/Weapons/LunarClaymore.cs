using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Edge.Items.Weapons
{
    public class LunarClaymore : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Lunar Claymore";     //Sword name
            item.damage = 120;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 68;              //Sword width
            item.height = 68;             //Sword height
            item.toolTip = "All the power is in your hand.";  //Item Description
            item.useTime = 10;          //how fast 
            item.useAnimation = 25;
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 8;      //Sword knockback
            item.value = 100;
            item.expert = true;
            item.UseSound = SoundID.Item1;        //1 is the sound of the sword
            item.autoReuse = true;   //if it's capable of autoswing.
            item.useTurn = true;
            item.shoot = mod.ProjectileType("LunarClaymore");
            item.shootSpeed = 8f;                //projectile speed                 
        }
        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar, 10);   //you need 1 DirtBlock
            recipe.AddIngredient(ItemID.FragmentStardust, 10);
            recipe.AddIngredient(ItemID.FragmentVortex, 10);
            recipe.AddIngredient(ItemID.FragmentNebula, 10);
            recipe.AddTile(TileID.AdamantiteForge);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

