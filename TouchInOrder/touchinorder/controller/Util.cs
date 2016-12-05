using System;
using System.Collections.Generic;

namespace de.crazynexus
{
	static class Util
	{
		public static List<T> randomizedList<T>(List<T> list)
		{
			var rnd = new Random();
			List<T> listClone = new List<T>(list);
			List<T> listRandom = new List<T>();

			while (listClone.Count > 0)
			{
				int rndValue = rnd.Next(0, listClone.Count);
				listRandom.Add(listClone[rndValue]);
				listClone.RemoveAt(rndValue);
			}

			return listRandom;
		}
	}
}
