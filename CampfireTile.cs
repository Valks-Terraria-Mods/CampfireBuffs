namespace CampfireBuffs;

public class CampfireTile : GlobalTile
{
    public override void NearbyEffects(int i, int j, int type, bool closer) 
    {
        Player p = Main.LocalPlayer;

        if (type == TileID.Campfire) 
        {
            if (closer)
            {
                if (Main.tile[i, j].TileFrameY < 36) // Is the campfire lit?
                {
                    if (Config.Instance.HealthRegeneration)
                    {
                        p.AddBuff(BuffID.Regeneration, 10);
                    }

                    if (Config.Instance.ManaRegeneration)
                    {
                        p.AddBuff(BuffID.ManaRegeneration, 10);
                    }

                    if (Config.Instance.Heartreach)
                    {
                        p.AddBuff(BuffID.Heartreach, 10);
                    }
                    
                    if (Config.Instance.Shine)
                    {
                        p.AddBuff(BuffID.Shine, 10);
                    }
                }
            }
        }
    }
}
