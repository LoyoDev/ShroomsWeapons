using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
	public class MidasGrasp : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Midas Grasp");
			Tooltip.SetDefault(@"Decimate their greed, and claim what is yours.");
		}

		public override void SetDefaults()
		{
			item.damage = 1000;
			item.ranged = true;
			item.width = 100;
			item.height = 49;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5f;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = ItemRarityID.Quest;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = AmmoID.Dart;
			item.shootSpeed = 22f;
			item.useAmmo = AmmoID.Dart;        //Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
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
				recipe.AddIngredient(ModContent.ItemType<ExclusionZone>(), 1);
				recipe.AddIngredient(ItemID.GoldBar, 99);
				recipe.AddIngredient(ModContent.ItemType<ShroomiteSoul>(), 10);
			}
			else
			{
				recipe.AddIngredient(ModContent.ItemType<ExclusionZone>(), 1);
				recipe.AddIngredient(ItemID.GoldBar, 999);
				recipe.AddIngredient(ModContent.ItemType<ShroomiteSoul>(), 99);
			}
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