using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickFix.Util
{
	public class FieldMapComparer : IEqualityComparer<FieldMap>
	{
		public bool Equals(FieldMap x, FieldMap y)
		{
			if (x == null && y == null)
				return true;
			if (x == null | y == null)
				return false;

			// all conditions above need to be true for FieldMaps to be equal
			return new Func<bool>[]
			{
				// Fields in FieldMap - if they have same number of fields it is enough to check equality in one direction
				() => x.Count() == y.Count(),
				() => CompareLeftToRight(x, y),
				// Groups
				() => x.GetGroupTags().Count == y.GetGroupTags().Count,
				() => CompareGroupsLeftToRight(x, y),
			}
			.All(part => part());
		}

		private bool CompareLeftToRight(FieldMap x, FieldMap y)
		{
			foreach (var xfield in x)
			{
				if (!y.IsSetField(xfield.Key))
					return false;

				var xfieldvalue = x.GetField(xfield.Key);
				var yfieldvalue = y.GetField(xfield.Key);
				if (xfieldvalue != yfieldvalue)
					return false;
			}
			return true;
		}

		private bool CompareGroupsLeftToRight(FieldMap x, FieldMap y)
		{
			foreach (var xGroupTag in x.GetGroupTags())
			{
				int xGroupCount = x.GroupCount(xGroupTag);
				if (xGroupCount != y.GroupCount(xGroupTag))
					return false;
				for (int i = 1; i <= xGroupCount; i++)
				{
					var xGroup = x.GetGroup(i, xGroupTag);
					var yGroup = y.GetGroup(i, xGroupTag);
					if (!Equals(xGroup, yGroup))
						return false;
				}
			}
			return true;
		}

		public int GetHashCode(FieldMap obj)
		{
			throw new NotImplementedException();
		}
	}
}