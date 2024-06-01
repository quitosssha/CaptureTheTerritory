using System.Collections.Generic;

namespace CaptureTheTerritory.Models
{
	public partial class GameState
	{
		private int fieldRadius;
		private Dictionary<PointHexMap, Hexagon> field;

		public GameState(int hexagonMapRadius = 20)
		{
			
		}
	}
}
