namespace CaptureTheTerritory.Models
{
	public class Village : Building
	{
		public override ResistanceTier ResistanceTier { get; } = ResistanceTier.Tier1;
	}
}
