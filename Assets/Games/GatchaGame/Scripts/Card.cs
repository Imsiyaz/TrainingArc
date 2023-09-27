using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    //[SerializeField] private Image img;
    [SerializeField] private TextMeshProUGUI cardName;

    public CardInfo cardInfo;

    void Start()
    {
        if(cardInfo != null)
        {
            cardName.text = cardInfo.CardNames;
        }
    }


    void Update()
    {
        Start();
    }
}
