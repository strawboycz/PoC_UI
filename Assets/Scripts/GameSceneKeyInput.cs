using UnityEngine;

public class GameSceneKeyInput : MonoBehaviour
{
	[SerializeField] private GameObject pauseMenuGameObject;
	[SerializeField] private GameObject SaveGameDialogGameObject;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SaveGameDialogGameObject.SetActive(false);
			if (pauseMenuGameObject.activeSelf)
				pauseMenuGameObject.SetActive(false);
			else
				pauseMenuGameObject.SetActive(true);
		}
	}
}