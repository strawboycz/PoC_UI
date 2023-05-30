using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeleteButtonBehavior : MonoBehaviour
{
	private Button btn;
	[SerializeField] private GameObject fileNameGameObject;
	[SerializeField] private GameObject fileBoxGameObject;
	void Start()
	{
		btn = transform.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	void TaskOnClick()
	{
		string filename = fileNameGameObject.GetComponent<TMP_Text>().text;
		Destroy(fileBoxGameObject);
		GameDataManager.DeleteData(filename);
	}
}
