using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBlock : MonoBehaviour
{
    [Tooltip("Panel Displayed When the player wins")]
    [SerializeField]
    private GameObject TheVicotryPanel = null;




    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TheVicotryPanel.SetActive(true);
        }
    }

}
