using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class GameDataManager
{
	public static GameData data { get; private set; } = new GameData();

	public static string filePath;

	public static void SaveCurrentData()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		filePath = Application.persistentDataPath + "/" + data.gameName  + ".bin";
		Debug.Log("SAVING AS " +filePath + " with type " + data.gameType);
		FileStream fs = new FileStream(filePath, FileMode.Create);
		formatter.Serialize(fs, data);
		fs.Close();
	}
	public static void LoadData(string GameName)
	{

		filePath = Application.persistentDataPath + "/" + GameName;
		
		if (File.Exists(filePath))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream fs = new FileStream(filePath, FileMode.Open);
			data = formatter.Deserialize(fs) as GameData;
			fs.Close();
		}
		else
			data = new GameData();

		Debug.Log("LOADING AS " + filePath + " with type " + data.gameType + "and point count is " + data.pointCount);
	}

	public static void EraseData()
	{
		data = new GameData();
	}

	public static void DeleteData(string GameName)
	{
		EraseData();
		filePath = Application.persistentDataPath + "/" + GameName;
		if (File.Exists(filePath))
		{
			File.Delete(filePath);
		}
	}
}
