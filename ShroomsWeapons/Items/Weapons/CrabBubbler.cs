using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class CrabBubbler : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Crab people, crab people");
		}

		public override void SetDefaults()
		{
			item.damage = 85;
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
			item.UseSound = SoundID.Item11;
			item.shoot = ProjectileID.FlaironBubble;
			item.autoReuse = true;
			item.shootSpeed = 16f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShroomiteBar, 20);
			recipe.AddIngredient(ModContent.ItemType<ShroomiteSoul>(), 10);
			recipe.AddIngredient(ItemID.IllegalGunParts, 4);
			recipe.AddIngredient(ItemID.BubbleMachine, 1);
			recipe.AddIngredient(ItemID.BubbleGun, 1);
			recipe.AddTile(TileID.Autohammer);
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