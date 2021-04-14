using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class BunnyCannon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Bunny Cannon");
			Tooltip.SetDefault("This is for you Mech!");
		}

		public override void SetDefaults()
		{
			item.damage = 100;
			item.ranged = true;
			item.width = 100;
			item.height = 46;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4f;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 281;
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddIngredient(ModContent.ItemType<ShroomiteSoul>(), 20);
			recipe.AddIngredient(ItemID.BunnyCannon, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void ModifyWeaponDamage(Player player, ref float add, ref float mult, ref float flat)
		{
			// Here we use the multiplicative damage modifier because Terraria does this approach for Ammo damage bonuses. 
			mult *= player.bulletDamage;
		}

		public override Vector2? HoldoutOffset()
		{
			return Vector2.Zero;
		}
	}
}