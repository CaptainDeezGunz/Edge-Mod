using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Edge.Projectiles.Pets
{
    public class Duck : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            projectile.name = "Duck";
            aiType = ProjectileID.ZephyrFish;
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false; // Relic from aiType
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
            if (player.dead)
            {
                modPlayer.Duck = false;
            }
            if (modPlayer.Duck)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}