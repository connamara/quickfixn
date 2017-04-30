using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFix.Util
{
	public class MessageComparer : IEqualityComparer<Message>
	{
		public bool Equals(Message x, Message y)
		{
			if (x == null && y == null)
				return true;
			if (x == null | y == null)
				return false;

			var fieldComparer = new FieldMapComparer();
			
			// all conditions above need to be true for FieldMaps to be equal
			return new Func<bool>[]
			{
				() => fieldComparer.Equals(x.Header, y.Header),
				() => fieldComparer.Equals(x, y),
				() => fieldComparer.Equals(x.Trailer, y.Trailer),
			}
			.All(part => part());
		}

		public int GetHashCode(Message obj)
		{
			throw new NotImplementedException();
		}
	}
}
