using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Transform TheTarget;

    public float Speed = 70f;

    public Vector3 Direction;

    public float DistanceThisFrame;

    public float LifeTime = 10f;

    public void Start()
    {
        Direction = TheTarget.position - transform.position;
        DistanceThisFrame = Speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (TheTarget == null)
        {
            Destroy(gameObject);
            return;
        }

        //Vector3.MoveTowards(gameObject.transform.position, TheTarget.position, DistanctThisFrame);
        transform.Translate(Direction.normalized * DistanceThisFrame, Space.World);


        if(LifeTime <= 0)
        {
            Destroy(gameObject);
        }

        LifeTime -= Time.deltaTime;

    }


    public void Seek(Transform target)
    {
        TheTarget = target;
    }



    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Player>().ApplyDamage();

            foreach(Turret T in FindObjectsOfType<Turret>())
            {
                T.CencelInvokes();
            }


            Destroy(gameObject);

        }
    }

}



