using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlocks : MonoBehaviour
{
    [Tooltip("this is the list of nodes for the block to travel thorugh")]
    public List<GameObject> Nodes = new List<GameObject>();

    [Tooltip("this is the current node number the block is moving towards")]
    public int CurrentNode = 0;


    public int NodesComplete = 0;

    private GameObject Destination;

    public float speed;



    // Start is called before the first frame update
    void Start()
    {
        NodesComplete = 0;

        Destination = Nodes[0];

        Move(Destination);
    }



    private void FixedUpdate()
    {
        Move(Destination);
    }


    public void Move(GameObject node)
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, node.gameObject.transform.position, Time.deltaTime * speed);
    }


    public void ChangeDirection()
    {

        foreach(GameObject G in Nodes)
        {
            if(G.GetComponent<Node>().MovedOn == false)
            {
                Destination = G;
                break;
            }
            else if(G.GetComponent<Node>().LastNode == true)
            {
                foreach(GameObject g in Nodes)
                {
                    g.GetComponent<Node>().MovedOn = false;
                    NodesComplete = 0;

                    Destination = Nodes[0];
                }
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Player>().ApplyDamage();
        }
    }

}
