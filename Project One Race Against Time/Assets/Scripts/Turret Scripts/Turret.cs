using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    private Transform Target;
    private float FireCountDown = 0f;


    [Header("Attributes")]

    public float FireRate = 1f;
    public float Range = 15.0f;
    public float TurnSpeed = 10.0f;


    [Header("SetUp Fields")]

    public Transform PartToRotate;
    public GameObject BulletPrefab;
    public Transform FirePoint;
    
   



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Target != null)
        {
            Vector3 Direction = Target.position - transform.position;
            Quaternion LookRotation = Quaternion.LookRotation(Direction);
            Vector3 Rotation = Quaternion.Lerp(PartToRotate.rotation, LookRotation, Time.deltaTime * TurnSpeed).eulerAngles;
            PartToRotate.rotation = Quaternion.Euler(0f, Rotation.y, 0f);


            if (FireCountDown <= 0)
            {
                Shoot();
                FireCountDown = 1f / FireRate;
            }


            FireCountDown -= Time.deltaTime;

        }
    }

    void UpdateTarget()
    {

            Target = GameObject.FindGameObjectWithTag("PlayerTransform").transform;
            float DistanceToEnemy = Vector3.Distance(transform.position, Target.position);

            if(DistanceToEnemy >= Range)
            {
                Target = null;
            }
            else
            {
                Target = GameObject.FindGameObjectWithTag("PlayerTransform").transform;
            }




    }

    void Shoot()
    {
        GameObject BulletGameObject = (GameObject)Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        Bullet bullet = BulletGameObject.GetComponent<Bullet>();

        if(bullet)
        {
            bullet.Seek(Target);
        }    
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Range);
    }

}
