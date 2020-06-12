using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    [Tooltip("the number given to this node in the list of nodes for the block")]
    public int NodeNumber = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<MovingBlocks>().ChangeDirection(NodeNumber);
    }

}
