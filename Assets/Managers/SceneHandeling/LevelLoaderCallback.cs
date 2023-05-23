using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoaderCallback : MonoBehaviour
{
	private bool isFirstFrame = true;

	void Update()
	{
		if (isFirstFrame)
		{
			isFirstFrame = false;
			LevelLoader.LevelLoaderCallback();
		}
	}
}
