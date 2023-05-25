using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class GameDataManager
{
	public static GameData data = new GameData();

	public static string filePath;

	public static void SaveCurrentData()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		filePath = Application.persistentDataPath + "/saves/" + data.gameName;
		FileStream fs = new FileStream(filePath, FileMode.Create);
		formatter.Serialize(fs, data);
		fs.Close();
	}
	public static void LoadData(string GameName)
	{

		filePath = Application.persistentDataPath + "/saves/" + GameName;
		if (File.Exists(filePath))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream fs = new FileStream(filePath, FileMode.Open);
			data = formatter.Deserialize(fs) as GameData;
			fs.Close();
		}
		else
			data = new GameData();


	}
	public static void DeleteData(string GameName)
	{
		data = new GameData();
		filePath = Application.persistentDataPath + "/saves/" + GameName;
		if (File.Exists(filePath))
		{
			File.Delete(filePath);
		}
	}
}
