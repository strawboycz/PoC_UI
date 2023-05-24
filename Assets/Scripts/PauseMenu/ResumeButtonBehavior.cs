using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButtonBehavior : MonoBehaviour
{
	[SerializeField] private GameObject pauseMenuGameObject;
	void Start()
    {
        Button btn = transform.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

	void TaskOnClick()
	{
		pauseMenuGameObject.SetActive(false);
		GameObject myEventSystem = GameObject.Find("EventSystem");
		myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
	}
}
