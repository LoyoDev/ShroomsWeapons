using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class Finality : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("If you do not fear death, you will die braver than most.");
		}

		public override void SetDefaults()
		{
			item.damage = 455;
			item.ranged = true;
			item.width = 100;
			item.height = 46;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4f;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item40;
			item.autoReuse = true;
			item.shoot = 616;
			item.shootSpeed = 20f;
		}
		

		public override void AddRecipes()
		{
			Mod CalamityMod = ModLoader.GetMod("CalamityMod");
			ModRecipe recipe = new ModRecipe(mod);
			if (CalamityMod != null)
			{
				recipe.AddIngredient(CalamityMod.ItemType("AuricBar"), 20);
				recipe.AddIngredient(CalamityMod.ItemType("LifeAlloy"), 10);
				recipe.AddIngredient(CalamityMod.ItemType("GalacticaSingularity"), 10);
			}
			else
			{
				recipe.AddIngredient(ModContent.ItemType<ExclusionZone>(), 1);
				recipe.AddIngredient(ModContent.ItemType<ShroomiteSoul>(), 20);
				recipe.AddIngredient(ItemID.LunarBar, 50);
			}
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return Vector2.Zero;
		}
	}
}