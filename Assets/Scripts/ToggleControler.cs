using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleControler : MonoBehaviour
{
  public Toggle toggle;
  public TextMeshProUGUI textToToggle;

  private void Start()
  {
	  toggle.onValueChanged.AddListener(OnToggleValueChanged);
  }

  private void OnToggleValueChanged(bool isOn)
  {
    Debug.Log("toggle");
    if (textToToggle.text == "On")
	  {
		  textToToggle.SetText("Off");
	  }
    else textToToggle.SetText("On");
  }
}
