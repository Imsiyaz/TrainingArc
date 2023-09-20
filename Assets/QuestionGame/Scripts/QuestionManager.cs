using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    [System.Serializable]
    public class Question<T>
    {
        [SerializeField] private string questionText;
        [SerializeField] private T[] answer;

        public string QuestionText => questionText;
        public T[] Answer => answer;
    }

    [System.Serializable]
    public class Answer
    {
        [SerializeField] private string answerLabel;
        [SerializeField] private bool correctBool;

        public string AnswerLabel => answerLabel;
        public bool IsCorrect => correctBool;
    }

    [SerializeField] private Question<Answer>[] questionAnswer;

    [Header("UI for game")]
    [SerializeField] private TextMeshProUGUI questionLabel;
    [SerializeField] private TextMeshProUGUI[] answerTexts;
    private int questionCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateQuestionAnswer();

    }

    public void OnClickButton(int buttonID)
    {
        if (questionAnswer[questionCount].Answer[buttonID].IsCorrect)
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("wrong");
        }

        questionCount++;
        UpdateQuestionAnswer();


    }
    

    private void UpdateQuestionAnswer()
    {
        //Debug.Log(questionCount);
        //Debug.Log(questionAnswer.Length);

        if (questionCount == questionAnswer.Length)
        {
            questionCount = 0;

        }

        questionLabel.text = questionAnswer[questionCount].QuestionText;


        for (int i = 0; i < questionAnswer[questionCount].Answer.Length; i++)
        {
            answerTexts[i].text = questionAnswer[questionCount].Answer[i].AnswerLabel;

        }
        

    }
}
