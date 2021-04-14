using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class FrigidShroomiteChestplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Frigid Shroomite Chestplate");
			Tooltip.SetDefault("Let instinct take over, claim it"
				+ "\nImmunity to 'On Fire!'"
				+ "\n+60 max mana and +3 max minions");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 20;
		}

		public override void UpdateEquip(Player player) {
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 60;
			player.maxMinions += 3;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShroomiteBar, 30);
			recipe.AddIngredient(ItemID.FrostCore, 4);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}