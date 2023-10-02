using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuizManagerV2 : QuizBase
{

    [Header("Quiz Questions/Answers")]
    [SerializeField] private Question<AnswerString>[] questionAnswer;


    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI qnTextTMP;
    [SerializeField] private TextMeshProUGUI[] answerTextsTMP;

    private int qnCounter;

    // Start is called before the first frame update
    void Start()
    {
        qnCounter = 0;

        questionAnswer.Shuffle();
        for (int i = 0; i < questionAnswer[qnCounter].AnswerClass.Length; i++)
        {
            questionAnswer[qnCounter].AnswerClass.Shuffle();
        }

        DisplayQN();

    }

    private void DisplayQN()
    {
        qnTextTMP.text = questionAnswer[qnCounter].QuestionText;

        for (int i = 0; i < answerTextsTMP.Length; i++)
        {
            answerTextsTMP[i].text = questionAnswer[qnCounter].AnswerClass[i].AnswerText;
        }

    }
    
    public void UpdateQN(int buttonID)
    {
        CheckAnswer(buttonID);

        qnCounter++;
        if (questionAnswer.Length == qnCounter)
        {
            qnCounter = 0;
            questionAnswer.Shuffle();
        }

        DisplayQN();
    }

    private void CheckAnswer(int buttonID)
    {
        if (questionAnswer[qnCounter].AnswerClass[buttonID].IsCorrect)
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Wrong");
        }


        //After checking shuffles next set of answers
        for (int i = 0; i < questionAnswer[qnCounter].AnswerClass.Length; i++)
        {
            questionAnswer[qnCounter].AnswerClass.Shuffle();
        }

    }




}
