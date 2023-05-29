using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PrintAllFiles : MonoBehaviour
{
	void Start()
	{
		Button btn = transform.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	void TaskOnClick()
	{
		foreach (var file in new DirectoryInfo(Application.persistentDataPath).GetFiles())
		{
			Debug.Log(file.Name);
		}
	}

}
