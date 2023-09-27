using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "new card", menuName = "Character")]
public class CardInfo : ScriptableObject
{
    //public Sprite img;
    [SerializeField] private string cardNames;

    public string CardNames => cardNames;
}
