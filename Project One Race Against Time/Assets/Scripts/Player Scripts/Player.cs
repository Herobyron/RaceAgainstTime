using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Tooltip("this is the players health")]
    [SerializeField]
    private float PlayerHealth = 100.0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // a simple function that applys 100 damame to the player
    // in this game everything should kill with one hit so this is all that is required
    public void ApplyDamage()
    {
        PlayerHealth -= 100; 
    }

    public float ReturnHealth()
    {
        return PlayerHealth;
    }    

}
