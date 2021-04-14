using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class DartlingGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Uses darts as ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 55;
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
			item.shoot = AmmoID.Dart;
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Dart;        //Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddIngredient(ItemID.ShinyRedBalloon, 1);
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