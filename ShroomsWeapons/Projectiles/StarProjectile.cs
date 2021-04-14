using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Projectiles
{
	public class StarProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Starfury V2");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.StarWrath);
			aiType = ProjectileID.StarWrath;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.StarWrath;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, ProjectileID.StarWrath, (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
}