using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseGame : MonoBehaviour
{
  [SerializeField] private GameObject pauseMenuGameObject;
  [SerializeField] private GameObject saveMenuDialoGameObject;
		void Start()
    {
	    Button btn = transform.GetComponent<Button>();
      btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
	    pauseMenuGameObject.SetActive(false);
      saveMenuDialoGameObject.SetActive(false);
	    GameObject myEventSystem = GameObject.Find("EventSystem");
	    myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
      LevelLoader.load(LevelLoader.Scene.MenuScene);
  }


}
