using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class GatchaManager : MonoBehaviour
{
    [SerializeField] private GatchaRate[] gacha;
    [SerializeField] private Transform parent, pos;
    [SerializeField] private GameObject characterCardGO;

    GameObject charCards;
    Card card;


    public void Gacha()
    {
        if(charCards == null)
        {
            charCards = Instantiate(characterCardGO, pos.position, Quaternion.identity) as GameObject;
            charCards.transform.SetParent(parent);
            charCards.transform.localPosition = new Vector3(1,1,1);
            card = charCards.GetComponent<Card>();

        }


        int rnd = UnityEngine.Random.Range(1, 101);

        for (int i = 0; i < gacha.Length; i++)
        {
            if (rnd <= gacha[i].rate)
            {
                card.cardInfo = Reward(gacha[i].rarity);
                return;
            }
        }
    }


    CardInfo Reward(string rarity)
    {
        GatchaRate gr = Array.Find(gacha, rt => rt.rarity == rarity);
        CardInfo[] reward = gr.reward;

        int rnd = UnityEngine.Random.Range(0,reward.Length);
        return reward[rnd];
    }













}

