using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class RayOfDoom : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ray of Doom");
			Tooltip.SetDefault(@"Anihilates anything in its path!");
		}

		public override void SetDefaults()
		{
			item.damage = 160;
			item.magic = true;
			item.width = 100;
			item.height = 46;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5f;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item33;
			item.autoReuse = true;
			item.shoot = 88;
			item.shootSpeed = 18f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<DartlingGun>(), 1);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.ShinyRedBalloon, 3);
			recipe.AddIngredient(ItemID.Diamond, 10);
			recipe.AddIngredient(ItemID.LargeRuby, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return Vector2.Zero;
		}
	}
}