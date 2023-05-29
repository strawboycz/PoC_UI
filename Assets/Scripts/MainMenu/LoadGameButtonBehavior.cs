using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameButtonBehavior : MonoBehaviour
{
  Button btn;
  void Start()
  {
	  btn = transform.GetComponent<Button>();
	  btn.onClick.AddListener(TaskOnClick);
  }
  void TaskOnClick()
  {
	  LevelLoader.load(LevelLoader.Scene.LoadGameScene);
  }
}
