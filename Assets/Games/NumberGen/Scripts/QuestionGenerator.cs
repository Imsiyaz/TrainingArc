using TMPro;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI numberTMP;




    public void OnClickNumGen()
    {
        NumberGeneratorV3(Random.Range(0 , 10));
    }

    //private void NumberGenerator(int questionInt)
    //{
    //    Debug.Log(questionInt);

    //    int sum1 = Random.Range(1, 5);

    //    int sum2 = Mathf.Abs(sum1 - questionInt);

    //    if (sum1 >= sum2)
    //    {
    //        sum2 = Mathf.Abs(sum1 - questionInt);

    //        Debug.Log($"{sum1} - {sum2} = {questionInt}");
    //    }
    //    else
    //    {
    //        Debug.Log("sum2 > sum1");
    //    }



    //}



    private void NumberGeneratorV2(int questionSum)
    {
        int sum2 = Random.Range(1, 5);

        int sum1 = sum2 + questionSum;

        Debug.Log($"{sum1} - {sum2} = {questionSum}");

    }


    private (int, int) NumberGeneratorV3(int questionSum)
    {

        int sum1 = Random.Range(questionSum, 11);
        int sum2 = sum1 - questionSum;


        numberTMP.text = ($"{sum1} - {sum2} = {questionSum}");

        return (sum1, sum2);
    }


}
