using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingWater : MonoBehaviour
{
    [Tooltip("this is a bool that determines wether the water should start moving")]
    public bool Trigered;

    [Tooltip("The End point for the water rising")]
    public GameObject EndPoint;

    [Tooltip("this is the speed of the water rising")]
    public float Speed;

    // Update is called once per frame
    void Update()
    {
       if(Trigered)
       {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, EndPoint.transform.position, Time.deltaTime * Speed);
       }
    }
}
