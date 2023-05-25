using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTbuttonBehavior : MonoBehaviour
{
    [SerializeField] private GameType gameType;
    void Start()
    {
	    Button btn = GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
	    GameDataManager.data.gameType = gameType;
      LevelLoader.load(LevelLoader.Scene.ChooseGameNameScene);
    }


}
