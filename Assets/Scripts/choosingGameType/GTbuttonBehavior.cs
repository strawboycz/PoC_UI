using System.Collections;
using System.Collections.Generic;
using Assets.Managers.GameDataHandling;
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
      Debug.Log("Game type set to " + GameDataManager.data.gameType);
      LevelLoader.load(LevelLoader.Scene.ChooseGameNameScene);
    }


}
