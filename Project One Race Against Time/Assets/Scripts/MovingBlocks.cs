using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlocks : MonoBehaviour
{
    [Tooltip("this is the list of nodes for the block to travel thorugh")]
    public List<GameObject> Nodes = new List<GameObject>();

    [Tooltip("this is the current node number the block is moving towards")]
    public int CurrentNode = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDirection(CurrentNode);
    }

    public void ChangeDirection(int TheNodeNumber)
    {

        if(TheNodeNumber > Nodes.Count)
        {
            CurrentNode = 0;
        }
        else
        {
            CurrentNode = TheNodeNumber + 1;
        }

        transform.position = Vector3.MoveTowards(transform.position, Nodes[CurrentNode].transform.position, 0.1f);

    }



}
