using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CampfireBuffs;

public class Config : ModConfig
{
    [DefaultValue(true)]
    public bool ManaRegeneration;

    [DefaultValue(true)]
    public bool HealthRegeneration;

    [DefaultValue(true)]
    public bool Heartreach;

    [DefaultValue(true)]
    public bool Shine;

    public static Config Instance { get; private set; }

    public override ConfigScope Mode => ConfigScope.ServerSide;

    public override void OnLoaded()
    {
        Instance = this;
    }
}
