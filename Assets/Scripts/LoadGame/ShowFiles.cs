using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class ShowFiles : MonoBehaviour
{
	[SerializeField]private GameObject Frame;
	[SerializeField]private GameObject FileBox;
	void Start()
	{
		foreach (var file in new DirectoryInfo(Application.persistentDataPath).GetFiles())
		{
			GameObject newFilebox =  Instantiate(FileBox);
			newFilebox.transform.SetParent(Frame.transform);
			newFilebox.transform.Find("Frame").transform.Find("LoadButton").transform.Find("FileName").GetComponent<TMP_Text>().text = file.Name;

			GameDataManager.LoadData(file.Name);
			newFilebox.transform.Find("Frame").transform.Find("GameType").GetComponent<TMP_Text>().text = GameDataManager.data.gameType.ToString();
			newFilebox.transform.Find("Frame").transform.Find("CreationDate").GetComponent<TMP_Text>().text = file.CreationTime.ToShortDateString();

			newFilebox.transform.localScale = new Vector3(1, 1, 1);

			GameDataManager.EraseData();

			
		}
		
	}
}
