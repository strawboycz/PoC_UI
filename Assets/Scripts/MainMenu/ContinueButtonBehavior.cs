using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButtonBehavior : MonoBehaviour
{
	Button btn ;
	[SerializeField] private GameObject text;
	void Start()
	{
		btn = transform.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void Update()
	{
		if (File.Exists(PointsManager.filePath))
		{
			btn.interactable = true;
			
			text.GetComponent<TMP_Text>().color = new Color32(245, 246, 250,255);
		}
		else
		{
			btn.interactable = false;
			text.GetComponent<TMP_Text>().color = new Color32(47, 54, 64,183);
		}
	}
	void TaskOnClick()
	{
		PointsManager.LoadPoints();
		LevelLoader.load(LevelLoader.Scene.GameScene);
	}
}
