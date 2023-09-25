using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursedTechnique : MonoBehaviour
{


    [SerializeField] private Transform playerHands;
    [SerializeField] private GameObject blueTechnique;
    [SerializeField] private GameObject redTechnique;


    // Update is called once per frame
    void Update()
    {
        ActivateTechniques();
    }


    private void ActivateTechniques()
    {
        //if(blueTechnique.transform.position.x - redTechnique.transform.position.x < 0)
        //{
        //    Debug.Log("HOLLOW PURPLE");
        //}
        
        //Debug.Log(blueTechnique.transform.position.x - redTechnique.transform.position.x);
        if (Input.GetKeyDown(KeyCode.B))
        {
            Destroy(Instantiate(blueTechnique, playerHands.transform.position, Quaternion.identity, playerHands), 2f);

        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(Instantiate(redTechnique, playerHands.transform.position, Quaternion.identity, playerHands), 2f);
        }


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }


}
