using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class PointsManager
{
	public static int pointCount;

	[SerializeField] static GameObject pointDisplay = GameObject.Find("PointsDisplay");

	public static void IncrementPoints()
	{
		pointCount++;
		ReloadDisplay();
	}

	private static void ReloadDisplay()
	{
		pointDisplay.GetComponent<TMP_Text>().text = "Points: " + pointCount;
	}
}
