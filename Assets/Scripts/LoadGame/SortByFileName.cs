using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SortByFileName : MonoBehaviour
{
	[SerializeField] private GameObject parentGameObject;
	public GameObject[] childObjects;
	[SerializeField] private Sprite ImgNotSorted;
	[SerializeField] private Sprite ImgAsc;
	[SerializeField] private Sprite ImgDesc;
	void Start()
    {
    Button btn = GetComponent<Button>();
    btn.onClick.AddListener(sortByFilename);
  }


  void Update()
  {
	  if (!SortManager.sortedByNameAsc && !SortManager.sortedByNameDesc)
	  {
		  var img = transform.Find("Image").GetComponent<Image>().sprite = ImgNotSorted;
	  }
	  if (SortManager.sortedByNameAsc)
	  {
		  var img = transform.Find("Image").GetComponent<Image>().sprite = ImgAsc;
	  }
	  if (SortManager.sortedByNameDesc)
	  {
		  var img = transform.Find("Image").GetComponent<Image>().sprite = ImgDesc;
	  }
  }

	void sortByFilename()
  {
	  GameObject myEventSystem = GameObject.Find("EventSystem");
	  myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
		childObjects = new GameObject[parentGameObject.transform.childCount];
	  for (int i = 0; i < parentGameObject.transform.childCount; i++)
	  {
		  childObjects[i] = parentGameObject.transform.GetChild(i).gameObject;
	  }
		if (!SortManager.sortedByNameAsc && !SortManager.sortedByNameDesc) //not sorted
		{
			Debug.Log("desc");
			SortManager.setEverythingFalse();
			System.Array.Sort(childObjects, CompareDesc); //sorts desc
			SortManager.sortedByNameDesc = true;

		}
		else if (SortManager.sortedByNameDesc) //sorted desc
		{
			Debug.Log("asc");
			SortManager.setEverythingFalse();
			System.Array.Sort(childObjects, CompareAsc); //sorts asc
			SortManager.sortedByNameAsc = true;
		}
		else if (SortManager.sortedByNameAsc) //sorted asc
		{
			Debug.Log("desc");
			SortManager.setEverythingFalse();
			System.Array.Sort(childObjects, CompareDesc); //sorts desc
			SortManager.sortedByNameDesc = true;
		}
		for (int i = 0; i < childObjects.Length; i++)
	  {
		  childObjects[i].transform.SetSiblingIndex(i);
	  }
  }
  private int CompareDesc(GameObject obj1, GameObject obj2)
  {
	  var text1 = getSortData(obj1, obj2, out var text2);
	  return string.Compare(text1, text2);
  }

  private int CompareAsc(GameObject obj1, GameObject obj2)
  {
	  var text1 = getSortData(obj1, obj2, out var text2);
	  return string.Compare(text2, text1);
  }

	private static string getSortData(GameObject obj1, GameObject obj2, out string text2)
  {
	  string text1 = obj1.transform.Find("Frame").transform.Find("LoadButton").transform.Find("FileName")
		  .GetComponent<TMP_Text>().text;
	  text2 = obj2.transform.Find("Frame").transform.Find("LoadButton").transform.Find("FileName").GetComponent<TMP_Text>()
		  .text;
	  return text1;
  }
}
