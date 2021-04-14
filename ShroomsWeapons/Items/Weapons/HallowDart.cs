using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class HallowDart : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Chases enemies through walls");
		}

		public override void SetDefaults() {
			item.damage = 12;
			item.ranged = true;
			item.width = 14;
			item.height = 14;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = Item.sellPrice(0, 0, 1, 0);
			item.rare = ItemRarityID.Yellow;
			item.shoot = ModContent.ProjectileType<Projectiles.HallowDart>();
			item.ammo = AmmoID.Dart; // The first item in an ammo class sets the AmmoID to it's type
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ectoplasm);
			recipe.AddIngredient(ItemID.Pearlwood);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
