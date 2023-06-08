using System.Collections;
using System.Collections.Generic;
using Assets.Managers.GameDataHandling;
using UnityEngine;

[System.Serializable]
public class GameData
{
	public int pointCount;
	public GameType gameType;
	public string gameName;

	public GameData(int pointcount, GameType gametype,string gamename)
	{
		pointCount = pointcount;
		gameType = gametype;
		gameName = gamename;
	}
	public GameData()
	{
		pointCount = 0;
		gameType = GameType.None;
		gameName = "";
	}

}
