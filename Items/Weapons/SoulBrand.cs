using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace Edge.Items.Weapons
{
    public class SoulBrand : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Soul Brand";     //Sword name
            item.damage = 40;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 59;              //Sword width
            item.height = 60;             //Sword height
            item.toolTip = "Gostly souls are contained in this sword.";  //Item Description
            item.useTime = 9;          //how fast 
            item.useAnimation = 25;
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 8;      //Sword knockback
            item.value = 1000;
            item.expert = true;
            item.UseSound = SoundID.Item1;    //1 is the sound of the sword
            item.autoReuse = true;   //if it's capable of autoswing.
            item.useTurn = true;
            item.shoot = mod.ProjectileType("GostlySoul");
            item.shootSpeed = 4f;                //projectile speed                 
        }
        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Keybrand, 1);  
            recipe.AddIngredient(ItemID.SpectreBar, 4);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddTile(TileID.MythrilAnvil); 
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
