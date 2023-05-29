using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class continueButton : MonoBehaviour
{
		[SerializeField] private GameObject textGameObject;
    void Start()
    {
	    Button btn = GetComponent<Button>();
	    btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
	    GameDataManager.data.gameName = textGameObject.GetComponent<TMP_Text>().text;
      Debug.Log("Game name set to " + GameDataManager.data.gameName);
	    LevelLoader.load(LevelLoader.Scene.GameScene);
    }
}
