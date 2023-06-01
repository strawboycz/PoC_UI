using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SortByDate : MonoBehaviour
{
	[SerializeField] private GameObject parentGameObject;
	[SerializeField] private Sprite ImgNotSorted;
	[SerializeField] private Sprite ImgAsc;
	[SerializeField] private Sprite ImgDesc;
	public GameObject[] childObjects;
	private Button btn;
	void Start()
	{
		btn = GetComponent<Button>();
		btn.onClick.AddListener(sortByDate);
		sortByDate();
	}

	void Update()
	{
		if (!SortManager.sortedByDateAsc && !SortManager.sortedByDateDesc)
		{
			var img = transform.Find("Image").GetComponent<Image>().sprite = ImgNotSorted;
		}
		if (SortManager.sortedByDateAsc)
		{
			var img = transform.Find("Image").GetComponent<Image>().sprite = ImgAsc;
		}
		if (SortManager.sortedByDateDesc)
		{
			var img = transform.Find("Image").GetComponent<Image>().sprite = ImgDesc;
		}
	}
	public void sortByDate()
	{
		GameObject myEventSystem = GameObject.Find("EventSystem");
		myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
		childObjects = new GameObject[parentGameObject.transform.childCount];
		for (int i = 0; i < parentGameObject.transform.childCount; i++)
		{
			childObjects[i] = parentGameObject.transform.GetChild(i).gameObject;
		}

		if (!SortManager.sortedByDateAsc && !SortManager.sortedByDateDesc) //not sorted
		{
			Debug.Log("desc");
			SortManager.setEverythingFalse();
			System.Array.Sort(childObjects, CompareDesc); //sorts desc
			SortManager.sortedByDateDesc = true;
			
		}
		else if (SortManager.sortedByDateDesc) //sorted desc
		{
			Debug.Log("asc");
			SortManager.setEverythingFalse();
			System.Array.Sort(childObjects, CompareAsc); //sorts asc
			SortManager.sortedByDateAsc = true;
		}
		else if (SortManager.sortedByDateAsc) //sorted asc
		{
			Debug.Log("desc");
			SortManager.setEverythingFalse();
			System.Array.Sort(childObjects, CompareDesc); //sorts desc
			SortManager.sortedByDateDesc = true;
		}

		for (int i = 0; i < childObjects.Length; i++)
		{
			childObjects[i].transform.SetSiblingIndex(i);
		}
	}
	private int CompareAsc(GameObject obj1, GameObject obj2)
	{
		var date1 = getDataForSort(obj1, obj2, out var date2);

		return DateTime.Compare( date2,date1 );
	}
	private int CompareDesc(GameObject obj1, GameObject obj2)
	{
		var date1 = getDataForSort(obj1, obj2, out var date2);

		return DateTime.Compare(date1, date2);
	}

	private static DateTime getDataForSort(GameObject obj1, GameObject obj2, out DateTime date2)
	{
		string text1 = obj1.transform.Find("Frame").transform.Find("CreationDate").GetComponent<TMP_Text>().text;
		string[] separated = text1.Split('.');
		DateTime date1 = new DateTime(int.Parse(separated[2]), int.Parse(separated[1]), int.Parse(separated[0]));
		string text2 = obj2.transform.Find("Frame").transform.Find("CreationDate").GetComponent<TMP_Text>().text;
		separated = text2.Split('.');
		date2 = new DateTime(int.Parse(separated[2]), int.Parse(separated[1]), int.Parse(separated[0]));
		return date1;
	}
}
