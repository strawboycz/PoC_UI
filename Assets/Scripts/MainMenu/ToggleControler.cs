using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleControler : MonoBehaviour
{
  public Toggle toggle;
  public TextMeshProUGUI textToToggle;

  private void FixedUpdate()
  {
	  toggle.onValueChanged.AddListener(OnToggleValueChanged);
	  if (toggle.isOn == true)
	  {
		  textToToggle.SetText("On");
	  }
	  else
	  {
		  textToToggle.SetText("Off");
	  }
  }

  private void OnToggleValueChanged(bool isOn)
  {
    Debug.Log("toggle");
   
  }
}
