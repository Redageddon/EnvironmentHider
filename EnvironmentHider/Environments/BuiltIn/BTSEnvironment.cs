namespace EnvironmentHider.Environments.BuiltIn;

public class BTSEnvironment : Environment
{
    public BTSEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("TrackMirror"),
            new("Construction"),
            new("PlayersPlace"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("MagicDoorSprite"),
            new("NarrowGameHUD"),
            new("DustPS"),
            new("Clouds"),
            new("StarHemisphere"),
            new("PillarTrackLaneRingsR"),
            new("PillarTrackLaneRingsR (1)"),
            new("PillarsMovementEffect"),
            new("PillarPair"),
            new("SmallPillarPair"),
            new("PillarPair (1)"),
            new("SmallPillarPair (1)"),
            new("PillarPair (2)"),
            new("SmallPillarPair (2)"),
            new("PillarPair (3)"),
            new("SmallPillarPair (3)"),
            new("PillarPair (4)"),
            new("StarEmitterPS"),
            new("BTSStarTextEffectEvent"),
            new("BTSEnvironmentCharacterSpawner"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("LightWithIdManager"),
            new("LightEffects"),
            new("CoreLighting"),
            new("GradientBackground"),
            new("GlowLineL"),
            new("GlowLineR"),
            new("GlowLineC"),
            new("GlowLineH"),
            new("GlowLineH (2)"),
            new("LaserL"),
            new("LaserR"),
            new("BottomGlow"),
            new("SideLaser"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}