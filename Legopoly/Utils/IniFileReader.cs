using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Utils
{
	public class IniFileReader
	{
		public IniFileReader()
		{
		}

		public Dictionary<string, IniSection> Sections { get; } = new Dictionary<string, IniSection>();

		public void Load(string filePath)
		{
			string[] lines = File.ReadAllLines(filePath);
			int lineNumber = 0;
			IniSection curSection = null;

			foreach (string line in lines)
			{
				lineNumber++;

				if (string.IsNullOrWhiteSpace(line))
					continue;

				string pline = line.TrimStart(new char[] { ' ', '\t' });
				if (pline.StartsWith("#") || pline.StartsWith(";"))
					continue; // skip comments;

				if (pline.StartsWith("["))
				{
					int endIndex = pline.IndexOf("]");
					if (endIndex == -1)
						throw new Exception(string.Format("Invalid section definition at line {0}!", lineNumber));

					string sectionName = pline.Substring(1, endIndex - 1);

					curSection = new IniSection();
                    Sections.Add(sectionName, curSection);
				}
				else
				{
					if (curSection == null)
						throw new Exception(string.Format("Missing section definition at line {0}!", lineNumber));

					int equalOp = pline.IndexOf('=');
					if (equalOp == -1)
						throw new Exception(string.Format("No equal character at line {0}!", lineNumber));

					string key = pline.Substring(0, equalOp - 0).Trim();
					string value = pline.Substring(equalOp + 1, pline.Length - equalOp - 1).Trim();

					curSection.KeyValues.Add(key, value);
				}
			}
		}
	}


	public class IniSection
	{
		public Dictionary<string, string> KeyValues { get; } = new Dictionary<string, string>();
	}
}
