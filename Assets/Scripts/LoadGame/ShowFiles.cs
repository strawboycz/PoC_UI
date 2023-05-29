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
			var michael = newFilebox.transform.Find("Frame").transform.Find("FileName").GetComponent<TMP_Text>().text = file.Name;
		}
	}
}
