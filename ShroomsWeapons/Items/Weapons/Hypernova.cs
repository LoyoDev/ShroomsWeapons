using ShroomsWeapons.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class Hypernova : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Hypernova");
			Tooltip.SetDefault("Born from the heavens to slaughter the hells.");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.Starfury);
			item.shootSpeed *= 0.75f;
			item.damage = 220;
			item.rare = 14;
			item.useTime = 15;
			item.useAnimation = 15;
			item.autoReuse = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			type = ModContent.ProjectileType<StarProjectile>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Starfury);
			recipe.AddIngredient(ItemID.StarWrath);
			recipe.AddIngredient(ModContent.ItemType<ShroomiteSoul>(), 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}