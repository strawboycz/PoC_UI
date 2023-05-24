using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuQuitButtonBehavior : MonoBehaviour
{
	[SerializeField] private GameObject SaveGameDialogGameObject;
  void Start()
    {
	    Button btn = transform.GetComponent<Button>();
	    btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
	    SaveGameDialogGameObject.SetActive(true);
	    GameObject myEventSystem = GameObject.Find("EventSystem");
	    myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
    }


}
