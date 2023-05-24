using UnityEngine;
using UnityEngine.UI;

public class PointButtonBehavior : MonoBehaviour
{
	private void Start()
	{
		var btn = transform.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	private void TaskOnClick()
	{
		PointsManager.IncrementPoints();
	}
}