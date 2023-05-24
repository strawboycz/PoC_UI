using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteGameData : MonoBehaviour
{
  void Start()
  {
	  Button btn = transform.GetComponent<Button>();
	  btn.onClick.AddListener(TaskOnClick);
  }

  void TaskOnClick()
  {
	  GameObject myEventSystem = GameObject.Find("EventSystem");
	  myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
	  PointsManager.DeletePointData();
  }
}
