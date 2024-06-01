using System;

namespace CaptureTheTerritory.Models
{
	public partial class GameState
    {
        public void AddHexagon(PointHexMap point)
        {
            if (field.ContainsKey(point))
                throw new Exception($"Hexagon at {point} is already exists.");
            field[point] = new Hexagon();
        }
    }
}
