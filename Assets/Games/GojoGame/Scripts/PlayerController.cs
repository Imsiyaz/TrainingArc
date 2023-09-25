using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : AttackHealthSystem
{

    public EnemyController enemyController;
    //public int damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputRecieved();
    }

    public override void InputRecieved()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            enemyController.TakeDamage(damage);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            TakeDamage(enemyController.damage);
        }

    }

}   

public class AttackHealthSystem : MonoBehaviour
{
    public int health;
    public int damage;

    public virtual void InputRecieved()
    {

    }

    //We're offloading the function to take damage to the reciever because 
    //they may have things to do when they receieve damage on their end (defence, buffs and what not)
    //we cannot be handling them on our side. It's not our responsibility. All we need to know is we're damaging them
    public void TakeDamage(int damageToRecieve)
    {
        health -= damageToRecieve;
    }
}
