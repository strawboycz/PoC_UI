using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
	void Start()
	{
		Button button = GetComponent<Button>();
		button.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		GameDataManager.data.pointCount = PointsManager.data.Count;
		GameDataManager.SaveCurrentData();
	}
}
