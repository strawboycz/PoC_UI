using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneInitialization : MonoBehaviour
{
	void Start()
	{
		PointsManager.data.Count = GameDataManager.data.pointCount;
      PointsManager.ReloadDisplay();  
      Debug.Log("Curent name: " + GameDataManager.data.gameName);
      Debug.Log("Curent type: " + GameDataManager.data.gameType);
    }

}
