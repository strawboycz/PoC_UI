using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveOptionsDialogControler : MonoBehaviour
{
	public GameObject DialogCanvas;
	public GameObject soundVolumeSlider;
	public GameObject musicVolumeSlider;
	public List<GameObject> Toggles;
	public List<GameObject> TabButtons;
	public void showDialog()
  {
	  Canvas c = DialogCanvas.GetComponent<Canvas>();
		soundVolumeSlider.GetComponent<Slider>().interactable = false;
		musicVolumeSlider.GetComponent<Slider>().interactable = false;
	  Toggles.ForEach(x => x.GetComponent<Toggle>().interactable = false);
	  TabButtons.ForEach(x => x.GetComponent<Button>().interactable = false);
		c.sortingOrder = 2;
  }
  public void showDialogIfChanged()
  {
	  showDialog();
  }
  public void hideDialog()
  {
	  Canvas c = DialogCanvas.GetComponent<Canvas>();
	  soundVolumeSlider.GetComponent<Slider>().interactable = true;
	  musicVolumeSlider.GetComponent<Slider>().interactable = true;
	  Toggles.ForEach(x => x.GetComponent<Toggle>().interactable = true);
	  TabButtons.ForEach(x => x.GetComponent<Button>().interactable = true);
		c.sortingOrder = -1;
  }
}
