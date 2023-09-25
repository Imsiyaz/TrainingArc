using System.Collections;
using System.Collections.Generic;
using System.Security;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager2 : MonoBehaviour
{

    //when we are doing this we are forcing it to only allow it to take in an empty class type 
    [System.Serializable]
    public class Question<AnswerType> where AnswerType : EmptyClass
    {
        [SerializeField] private string questionLabel;
        [SerializeField] private AnswerType[] answers;

        public string QuestionLabel => questionLabel;
        public AnswerType[] Answers => answers; 
    }

    public class EmptyClass
    {

    }

    [System.Serializable]
    public class Answer : EmptyClass
    {
        [SerializeField] private string answerLabel;
        [SerializeField] private bool isCorrect;

        public string AnswerLabel => answerLabel;   
        public bool IsCorrect => isCorrect; 
    }



    [System.Serializable]
    public class AnswerWithImage : Answer
    {
        [SerializeField] private Image nameImg;

        public Image NameImg => nameImg;    
    }

    [SerializeField] private Question<Answer>[] questionAnswer;
    [SerializeField] private TextMeshProUGUI questionTextTMP;
    [SerializeField] private TextMeshProUGUI[] answerLabelTMP;

    private int questionCounter;

    private void Start()
    {
        questionCounter = 1;

        questionTextTMP.text = questionAnswer[0].QuestionLabel;

        for (int i = 0; i < questionAnswer[0].Answers.Length; i++)
        {
            answerLabelTMP[i].text = questionAnswer[0].Answers[i].AnswerLabel;
        }

        Debug.Log(questionAnswer.Length);
    }


    public void OnClickButton()
    {
        Debug.Log("Test");

        if (questionCounter == questionAnswer.Length)
        {
            questionCounter = 0;

            Debug.Log("ZZZ");
        }

        questionCounter++;


    }


    private void UpdateQns()
    {

    }

}
