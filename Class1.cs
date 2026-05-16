using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets;
using osu.Framework.Localisation;

namespace osu.Mod.MehDrainsHealth2
{
    public class ModMehDrainsHealth : osu.Game.Rulesets.Mods.Mod, IApplicableToHealthProcessor
    {
        public override string Name => "Meh Drains Health";
        public override string Acronym => "MDH";

        public override LocalisableString Description => "Lose health whenever you hit a Meh.";
        public override double ScoreMultiplier => 1.0;

        public void ApplyToHealthProcessor(HealthProcessor healthProcessor)
        {
            healthProcessor.NewJudgement += judgement =>
            {
                if (judgement.Type == HitResult.Meh)
                    healthProcessor.Health.Value -= 0.05;
            };
        }
    }
}
