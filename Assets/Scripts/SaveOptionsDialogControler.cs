using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveOptionsDialogControler : MonoBehaviour
{
	public GameObject DialogCanvas;
  public void showDialog()
  {
	  Canvas c = DialogCanvas.GetComponent<Canvas>();
	  c.sortingOrder = 2;
  }
  public void showDialogIfChanged()
  {
	  showDialog();
  }
  public void hideDialog()
  {
	  Canvas c = DialogCanvas.GetComponent<Canvas>();
	  c.sortingOrder = -1;
  }
}
