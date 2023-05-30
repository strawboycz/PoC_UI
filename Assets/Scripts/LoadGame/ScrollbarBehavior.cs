using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarBehavior : MonoBehaviour
{
	
	void Start()
	{
		transform.GetComponent<Scrollbar>().onValueChanged.AddListener((float val) => ScrollbarCallback(val));
	}

	void ScrollbarCallback(float value)
	{
		GameObject myEventSystem = GameObject.Find("EventSystem");
		myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
	}
}
