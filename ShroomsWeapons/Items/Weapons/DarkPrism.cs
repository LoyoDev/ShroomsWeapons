using ShroomsWeapons.Projectiles;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class DarkPrism : ModItem
	{
		// You can use a vanilla texture for your item by using the format: "Terraria/Item_<Item ID>".
		public override string Texture => "Terraria/Item_" + ItemID.LastPrism;
		public static Color OverrideColor = new Color(122, 173, 255);
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Prism");
			Tooltip.SetDefault(@"Weaponizing the immortal.");
		}

		public override void SetDefaults()
		{
			// Start by using CloneDefaults to clone all the basic item properties from the vanilla Last Prism.
			// For example, this copies sprite size, use style, sell price, and the item being a magic weapon.
			item.CloneDefaults(ItemID.LastPrism);
			item.mana = 4;
			item.damage = 170;
			item.shoot = ModContent.ProjectileType<DarkPrismHoldout>();
			item.shootSpeed = 30f;

			// Change the item's draw color so that it is visually distinct from the vanilla Last Prism.
			item.color = OverrideColor;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LastPrism, 1);
			recipe.AddIngredient(ItemID.LunarBar, 20);
			recipe.AddIngredient(ItemID.SoulofFright, 20);
			recipe.AddIngredient(ItemID.SoulofNight, 50);
			recipe.AddIngredient(ItemID.FrostCore, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		// Because this weapon fires a holdout projectile, it needs to block usage if its projectile already exists.
		public override bool CanUseItem(Player player) => player.ownedProjectileCounts[ModContent.ProjectileType<DarkPrismHoldout>()] <= 0;
	}
}
