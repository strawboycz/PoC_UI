using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SortByGameType : MonoBehaviour
{
	[SerializeField] private GameObject parentGameObject;
	public GameObject[] childObjects;
	[SerializeField] private Sprite ImgNotSorted;
	[SerializeField] private Sprite ImgAsc;
	[SerializeField] private Sprite ImgDesc;
	void Start()
	{
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(sortByGameType);
	}


	void Update()
	{
		if (!SortManager.sortedByTypeAsc && !SortManager.sortedByTypeDesc)
		{
			var img = transform.Find("Image").GetComponent<Image>().sprite = ImgNotSorted;
		}
		if (SortManager.sortedByTypeAsc)
		{
			var img = transform.Find("Image").GetComponent<Image>().sprite = ImgAsc;
		}
		if (SortManager.sortedByTypeDesc)
		{
			var img = transform.Find("Image").GetComponent<Image>().sprite = ImgDesc;
		}
	}


	void sortByGameType()
	{
		GameObject myEventSystem = GameObject.Find("EventSystem");
		myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
		childObjects = new GameObject[parentGameObject.transform.childCount];
		for (int i = 0; i < parentGameObject.transform.childCount; i++)
		{
			childObjects[i] = parentGameObject.transform.GetChild(i).gameObject;
		}


		if (!SortManager.sortedByTypeAsc && !SortManager.sortedByTypeDesc) //not sorted
		{
			Debug.Log("desc");
			SortManager.setEverythingFalse();
			System.Array.Sort(childObjects, CompareDesc); //sorts desc
			SortManager.sortedByTypeDesc = true;

		}
		else if (SortManager.sortedByTypeDesc) //sorted desc
		{
			Debug.Log("asc");
			SortManager.setEverythingFalse();
			System.Array.Sort(childObjects, CompareAsc); //sorts asc
			SortManager.sortedByTypeAsc = true;
		}
		else if (SortManager.sortedByTypeAsc) //sorted asc
		{
			Debug.Log("desc");
			SortManager.setEverythingFalse();
			System.Array.Sort(childObjects, CompareDesc); //sorts desc
			SortManager.sortedByTypeDesc = true;
		}


		for (int i = 0; i < childObjects.Length; i++)
		{
			childObjects[i].transform.SetSiblingIndex(i);
		}
	}
	private int CompareDesc(GameObject obj1, GameObject obj2)
	{
		var text1 = getDataForSort(obj1, obj2, out var text2);
		return string.Compare(text1, text2);
	}
	private int CompareAsc(GameObject obj1, GameObject obj2)
	{
		var text1 = getDataForSort(obj1, obj2, out var text2);
		return string.Compare(text2, text1);
	}

	private static string getDataForSort(GameObject obj1, GameObject obj2, out string text2)
	{
		string text1 = obj1.transform.Find("Frame").transform.Find("GameType").GetComponent<TMP_Text>().text;
		text2 = obj2.transform.Find("Frame").transform.Find("GameType").GetComponent<TMP_Text>().text;
		return text1;
	}
}
