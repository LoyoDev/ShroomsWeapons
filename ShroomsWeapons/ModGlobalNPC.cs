using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShroomsWeapons
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(10) == 0)
            {
                if (npc.type == NPCID.AnomuraFungus)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ShroomiteSoul"));
                }
                if (npc.type == NPCID.MushiLadybug)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ShroomiteSoul"));
                }
                if (npc.type == NPCID.GiantFungiBulb)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ShroomiteSoul"));
                }
            }
        }
    }
}