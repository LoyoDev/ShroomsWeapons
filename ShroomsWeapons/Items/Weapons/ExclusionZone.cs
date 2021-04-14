using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class ExclusionZone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Exclusion Zone MK-1");
			Tooltip.SetDefault(@"Automatically seeks out targets. Great for balloons!");
		}

		public override void SetDefaults()
		{
			item.damage = 100;
			item.ranged = true;
			item.width = 100;
			item.height = 46;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5f;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = AmmoID.Dart;
			item.shootSpeed = 18f;
			item.useAmmo = AmmoID.Dart;        //Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<DartlingGun>(), 1);
			recipe.AddIngredient(ItemID.ShroomiteBar, 12);
			recipe.AddIngredient(ItemID.ShinyRedBalloon, 3);
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