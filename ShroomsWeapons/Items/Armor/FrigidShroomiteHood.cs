using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class FrigidShroomiteHood : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Frigid Shroomite Hood");
			Tooltip.SetDefault("Your mind aches, but you are one with the cold.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 15;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<FrigidShroomiteChestplate>() && legs.type == ModContent.ItemType<FrigidShroomiteLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "You are one with the cold, making you immune to frostfire and granting Ice Barrier.";
			player.buffImmune[BuffID.Frostburn] = true;
			player.AddBuff(62, 2);
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShroomiteBar, 25);
			recipe.AddIngredient(ItemID.FrostCore, 3);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}