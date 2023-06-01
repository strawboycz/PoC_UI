using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SortManager
{
	public static bool sortedByNameAsc = false;
	public static bool sortedByNameDesc = false;
	public static bool sortedByTypeAsc = false;
	public static bool sortedByTypeDesc = false;
	public static bool sortedByDateAsc = false;
	public static bool sortedByDateDesc = false;

	public static void setEverythingFalse()
	{
		sortedByNameAsc = false;
		sortedByNameDesc = false;
		sortedByTypeAsc = false;
		sortedByTypeDesc = false;
		sortedByDateAsc = false;
		sortedByDateDesc = false;
	}
}