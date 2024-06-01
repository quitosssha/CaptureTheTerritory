using System;

namespace CaptureTheTerritory.Models
{
	public struct PointHexMap
	{
		public int X { get; }
		public int Y { get; }
		public int Z { get; }
		public PointHexMap(int x, int y, int z)
		{
			if (x + y + z != 0)
				throw new ArgumentException("Sum of coordinates (x, y, z) must be equal to 0.");
			X = x;
			Y = y;
			Z = z;
		}

		public static bool operator ==(PointHexMap left, PointHexMap right) =>
			left.X == right.X && left.Y == right.Y && left.Z == right.Z;

		public static bool operator !=(PointHexMap left, PointHexMap right) =>
			!(left == right);

		public override bool Equals(object obj)
		{
			if (!(obj is PointHexMap other)) return false;
			return this == other;
		}

		public override int GetHashCode()
		{
			int hashCode = -307843816;
			hashCode = hashCode * -1521134295 + X.GetHashCode();
			hashCode = hashCode * -1521134295 + Y.GetHashCode();
			hashCode = hashCode * -1521134295 + Z.GetHashCode();
			return hashCode;
		}
	}
}
