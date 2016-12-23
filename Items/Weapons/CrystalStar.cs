using Terraria.ID;
using Terraria.ModLoader;

namespace Edge.Items.Weapons
{
    public class CrystalStar : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Crystal Star";
            item.damage = 7;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.toolTip = "A star made out of crystals!";
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("CrystalStar");
            item.shootSpeed = 16f;
            item.ammo = ProjectileID.FallingStar;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddIngredient(ItemID.CrystalShard, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }
}