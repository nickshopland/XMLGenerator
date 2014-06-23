using System.Collections.Generic;

[System.Serializable]
public class Quiz
{
	public bool Default = true;
	public List<QuizItem> Questions;
}

[System.Serializable]
public class QuizItem
{
	public string Question;
	public List<string> Answers;
	public int Correct;
	public string Information;
}
