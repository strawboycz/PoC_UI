using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class AddingPoints : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(AddPoints);
		
	}

	void AddPoints()
	{
		if (IsAnswerCorrect())
		{
			PointsManager.IncrementPoints();
			Debug.Log("correct!");
		}
		Debug.Log("incorrect");
	}

	private bool IsAnswerCorrect()
	{
		return transform.Find("AnswerText").GetComponent<TMP_Text>().text == DisplayingQuestions.newQuestion.options[DisplayingQuestions.newQuestion.correct_answer];
	}
}
