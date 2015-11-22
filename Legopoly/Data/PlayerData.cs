using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data
{
	[DataContract]
	public class PlayerData
	{
		[DataMember]
		public int DefaultCapital { get; set; }
	}
}
