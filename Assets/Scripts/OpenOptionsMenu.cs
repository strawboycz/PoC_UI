using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class OpenOptionsMenu : MonoBehaviour
{
  public GameObject optionsCanvas;
  public List<GameObject> MenuButtons;

  public void showOptios()
  {
	  Canvas c = optionsCanvas.GetComponent<Canvas>();
    MenuButtons.ForEach(x=> x.GetComponent<Button>().interactable = false);
    c.sortingOrder= 1;
  }
  public void hideOptios()
  {
	  Canvas c = optionsCanvas.GetComponent<Canvas>();
	  MenuButtons.ForEach(x => x.GetComponent<Button>().interactable = true);
    c.sortingOrder = -1;
  }
}
