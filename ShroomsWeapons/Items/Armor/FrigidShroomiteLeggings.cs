using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ShroomsWeapons.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class FrigidShroomiteLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Frigid Shroomite Leggings");
			Tooltip.SetDefault("You feel lingering energy from deep in your sole."
				+ "\n20% increased movement speed");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.20f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShroomiteBar, 20);
			recipe.AddIngredient(ItemID.FrostCore, 2);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}