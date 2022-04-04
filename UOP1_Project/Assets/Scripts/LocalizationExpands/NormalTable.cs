using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Localization.Tables
{
	public class NormalTableEntry : TableEntry
	{

	}

	/// <summary>
	/// 表格存储了很多Entry 每个Entry可以看做一行的数据
	/// </summary>
	public class NormalTable : DetailedLocalizationTable<NormalTableEntry>
	{
		public override NormalTableEntry CreateTableEntry()
		{
			throw new System.NotImplementedException();
		}
	}

}

