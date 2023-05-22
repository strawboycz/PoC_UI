using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OpenOptionsMenu : MonoBehaviour
{
  public GameObject optionsCanvas;

  public void showOptios()
  {
    Canvas c = optionsCanvas.GetComponent<Canvas>();
	  c.sortingOrder= 1;
  }
  public void hideOptios()
  {
	  Canvas c = optionsCanvas.GetComponent<Canvas>();
	  c.sortingOrder = -1;
  }
}
