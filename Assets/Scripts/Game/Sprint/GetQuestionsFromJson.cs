using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;


public static class GetQuestionsFromJson
	{
		private class Data
		{
			public List<Question> questions;
		}
		public static List<Question> GetGeographyQuestions()
		{
			string json = File.ReadAllText("./Assets/Scripts/Questions/Geography/geography.JSON");
			Data questionsData = JsonConvert.DeserializeObject<Data>(json);
			return questionsData.questions;
		}
	

	
}
