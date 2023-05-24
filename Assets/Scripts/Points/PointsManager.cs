using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine;

public static class PointsManager
{
	[SerializeField] private static GameObject pointDisplay = GameObject.Find("PointsDisplay");


	public static PointData data = new PointData(0);
	
	public static string filePath = Application.persistentDataPath + "/points.bin";
	public static void IncrementPoints()
	{
		data.Count++;
		ReloadDisplay();
	}

	public static void ReloadDisplay()
	{
		pointDisplay = GameObject.Find("PointsDisplay");
		pointDisplay.GetComponent<TMP_Text>().text = "Points: " + data.Count;
	}

	public static void SavePoints()
	{
		BinaryFormatter formatter = new BinaryFormatter();
		filePath = Application.persistentDataPath + "/points.bin";
		FileStream fs = new FileStream(filePath, FileMode.Create);
		formatter.Serialize(fs, data);
		fs.Close();
	}
	public static void LoadPoints()
	{

		filePath = Application.persistentDataPath + "/points.bin";
		if (File.Exists(filePath))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream fs = new FileStream(filePath, FileMode.Open);
			data = formatter.Deserialize(fs) as PointData;
			fs.Close();
		}
		else
			data = new PointData(0);


	}
	public static void DeletePointData()
	{
		data.Count = 0;
		filePath = Application.persistentDataPath + "/points.bin";
		if (File.Exists(filePath))
		{
			File.Delete(filePath);
		}
	}

}