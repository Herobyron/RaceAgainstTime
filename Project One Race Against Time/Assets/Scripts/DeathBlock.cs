using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBlock : MonoBehaviour
{


    // this checks to see if the player collides with the death block
    // if it does it applys damage to the player
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<Player>().ApplyDamage();
        }
    }

}
