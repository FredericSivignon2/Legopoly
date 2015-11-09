using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly
{
	[Serializable]
	public class NoMoneyException : Exception
	{
		public NoMoneyException()
		{
		}

		public NoMoneyException(string message)
			: base(message)
		{
		}

		public NoMoneyException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		public NoMoneyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{
		}
	}
}
