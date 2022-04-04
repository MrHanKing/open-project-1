using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Tables;

namespace UnityEditor.Localization
{
	public class NormalTableCollection : LocalizationTableCollection
	{
		protected override Type TableType => typeof(NormalTable);

		protected override Type RequiredExtensionAttribute => typeof(StringTableCollectionExtensionAttribute);

		protected override string DefaultGroupName => "Normal Table";

		public override void RemoveEntry(TableEntryReference entryReference)
		{
			throw new NotImplementedException();
		}
	}
}


