namespace CaptureTheTerritory.Models
{
	public class TowerCommon : Building
	{
		public override ResistanceTier ResistanceTier { get; } = ResistanceTier.Tier3;
	}
}
