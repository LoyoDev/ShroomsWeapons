using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class LightspeedRound : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("You'll never see it coming!");
		}

		public override void SetDefaults() {
			item.damage = 20;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = ItemRarityID.Blue;
			item.shoot = ModContent.ProjectileType<Projectiles.LightspeedRound>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EmptyBullet, 100);
			recipe.AddIngredient(ItemID.ShroomiteBar, 3);
			recipe.AddIngredient(ItemID.LightDisc, 1);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}
