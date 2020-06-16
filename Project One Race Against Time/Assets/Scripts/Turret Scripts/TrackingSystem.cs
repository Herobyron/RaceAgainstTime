using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingSystem : MonoBehaviour
{

    public float Speed = 3.0f;

    public GameObject Target = null;

    Vector3 LastKnownPosition = Vector3.zero;

    Quaternion LookAtRotation;

    // Update is called once per frame
    void Update()
    {
        if (Target)
        {
            if (LastKnownPosition != Target.transform.position)
            {
                LastKnownPosition = Target.transform.position;
                LookAtRotation = Quaternion.LookRotation(LastKnownPosition - transform.position);
            }

            if (transform.rotation != LookAtRotation)
                transform.rotation = Quaternion.RotateTowards(transform.rotation, LookAtRotation, (Speed * Time.deltaTime));

        }
    }


    public bool SetTarget(GameObject TheTarget)
    {
        if(TheTarget)
        {
            return false;
        }

        Target = TheTarget;
        return true;

    }

}
