using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CampfireBuffs
{
    class CampfireTile : GlobalTile
    {
        public override void NearbyEffects(int i, int j, int type, bool closer) {
            Player p = Main.LocalPlayer;
            if (type == TileID.Campfire) {
                if (closer)
                {
                    if (Main.tile[i, j].frameY < 36)// Is the campfire lit?
                    {
                        p.AddBuff(BuffID.Regeneration, 10);
                        p.AddBuff(BuffID.ManaRegeneration, 10);
                        p.AddBuff(BuffID.Heartreach, 10);
                        p.AddBuff(BuffID.Shine, 10);
                    }
                }
            }
        }
    }
}