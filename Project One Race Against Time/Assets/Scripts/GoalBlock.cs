using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBlock : MonoBehaviour
{





    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<LevelManager>().LevelComplete();

            foreach (Turret T in FindObjectsOfType<Turret>())
            {
                T.CencelInvokes();
            }
        }
    }

}
