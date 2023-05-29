using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadButtonBehavior : MonoBehaviour
{
	private Button btn;
	[SerializeField] private GameObject fileNameGameObject;
	void Start()
	{
		btn = transform.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	void TaskOnClick()
	{
		string filename = fileNameGameObject.GetComponent<TMP_Text>().text;
		GameDataManager.LoadData(filename);
		LevelLoader.load(LevelLoader.Scene.GameScene);
	}
}
