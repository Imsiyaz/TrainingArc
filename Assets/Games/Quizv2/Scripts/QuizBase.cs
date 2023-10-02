using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizBase : MonoBehaviour
{
    [System.Serializable]
    public class Question <T> where T : EmptyAnswer
    {
        [SerializeField] private string question;
        [SerializeField] private T[] answerClass;

        public string QuestionText => question;
        public T[] AnswerClass => answerClass;

    }

    [System.Serializable]
    public class QuestionImage<T> where T : EmptyAnswer
    {
        [SerializeField] private Image question;
        [SerializeField] private T[] answerClass;

        public Image QuestionText => question;
        public T[] AnswerClass => answerClass;

    }

    public class EmptyAnswer
    {
        //Empty class to know that it is an anser type
        //since genereic <T> takes in anything we want to idiot proof this so i only pass in Answer types 
    }


    [System.Serializable]
    public class AnswerString : EmptyAnswer
    {
        [SerializeField] private string anwser;
        [SerializeField] private bool isCorrect;

        public string AnswerText => anwser;
        public bool IsCorrect => isCorrect; 
    }



    [System.Serializable]
    public class AnswerInt : EmptyAnswer
    {
        [SerializeField] private int anwser;
        [SerializeField] private bool isCorrect;

        public int AnswerInts => anwser;
        public bool IsCorrect => isCorrect;
    }


    [System.Serializable]
    public class AnswerImage : AnswerString
    {
        [SerializeField] private Image answer;

        public Image AnswersImage => answer; 
    }
}
