using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class DisplayingQuestions : MonoBehaviour
{
	[SerializeField] private GameObject Canvas;
	[SerializeField] private GameObject prefab;
	public static Question newQuestion;

	void Start()
	{
		Canvas = GameObject.Find("Canvas");
		prefab = (GameObject)Resources.Load("QuestionPrefab", typeof(GameObject));
		try
		{
			Button btn = GetComponent<Button>();
			btn.onClick.AddListener(DisplayQuestion);
		}
		catch
		{
			DisplayQuestion();
		}
	}

	void DisplayQuestion()
	{
		try
		{
			GameObject OldQuestion = GameObject.Find("QuestionPrefab(Clone)");
			Destroy(OldQuestion);
		}
		finally
		{
			Random random = new Random(System.DateTime.Now.Millisecond);
			newQuestion = GetQuestionsFromJson.GetGeographyQuestions()[random.Next(0, GetQuestionsFromJson.GetGeographyQuestions().Count)];
			GameObject newQuestionObject = Instantiate(prefab);
			newQuestionObject.transform.name = "QuestionPrefab(Clone)";
			newQuestionObject.transform.SetParent(Canvas.transform.Find("Frame"));
			GameObject QuestionTitle = newQuestionObject.transform.Find("QuestionTitle").gameObject;
			QuestionTitle.GetComponent<TMP_Text>().text = newQuestion.question;
			GameObject Answer1 = newQuestionObject.transform.Find("ButtonField").transform.Find("Answer1Button").transform.Find("AnswerText").gameObject;
			GameObject Answer2 = newQuestionObject.transform.Find("ButtonField").transform.Find("Answer2Button").transform.Find("AnswerText").gameObject;
			GameObject Answer3 = newQuestionObject.transform.Find("ButtonField").transform.Find("Answer3Button").transform.Find("AnswerText").gameObject;
			Answer1.GetComponent<TMP_Text>().text = newQuestion.options[0];
			Answer2.GetComponent<TMP_Text>().text = newQuestion.options[1];
			Answer3.GetComponent<TMP_Text>().text = newQuestion.options[2];
		}
		
	}

}
