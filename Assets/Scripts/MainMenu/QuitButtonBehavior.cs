using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonBehavior : MonoBehaviour
{
	public void quitGame()
	{
		UnityEditor.EditorApplication.isPlaying = false;
		Application.Quit();
	}
}
