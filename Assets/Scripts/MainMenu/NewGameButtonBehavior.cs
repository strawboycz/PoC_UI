using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGameButtonBehavior : MonoBehaviour
{
	void Start()
	{
		Button btn = transform.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	void TaskOnClick()
	{
		LevelLoader.load(LevelLoader.Scene.GameScene);
		PointsManager.DeletePointData();
	}
}
