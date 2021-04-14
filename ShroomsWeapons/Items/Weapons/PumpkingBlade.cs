using System;
using ShroomsWeapons.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons.Items.Weapons
{
    public class PumpkingBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pumpking Blade");
            Tooltip.SetDefault(@"They don't know it's the spooky month. Enlighten them.");
        }
        public override void SetDefaults()
        {
            item.damage = 500;
            item.melee = true;
            item.width = 58;
            item.height = 66;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 100;
            item.rare = ItemRarityID.Red;
            item.UseSound = SoundID.Item7;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = ModContent.ProjectileType<PumpkingBladeProjectile>();
            item.shootSpeed = 12f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TheHorsemansBlade, 1);
            recipe.AddIngredient(ItemID.DeathSickle, 1);
            recipe.AddIngredient(ModContent.ItemType<ShroomiteSoul>(), 30);
            recipe.AddIngredient(ItemID.ExplosiveJackOLantern, 25);
            recipe.AddIngredient(ItemID.ShroomiteBar, 10);
            recipe.AddTile(TileID.Autohammer);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int a = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
            Main.projectile[a].friendly = true;
            Main.projectile[a].hostile = false;
            return true;
        }
    }
}