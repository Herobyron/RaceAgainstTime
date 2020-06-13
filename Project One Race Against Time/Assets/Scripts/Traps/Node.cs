using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    [Tooltip("had this node been passed through by the moving block")]
    public bool MovedOn;

    [Tooltip("if this is the last node in the sequence make this true")]
    public bool LastNode;


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("MovingBlock"))
        {
            MovedOn = true;
            other.GetComponent<MovingBlocks>().ChangeDirection();
            other.GetComponent<MovingBlocks>().NodesComplete++;
        }
    }

}
