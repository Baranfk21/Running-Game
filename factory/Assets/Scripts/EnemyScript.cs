using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

public GameObject enemy;
    public  Transform target;
    public float speed;
    Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos=Vector3.MoveTowards(transform.position,target.position,speed*Time.fixedDeltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
    }

    
void OnTriggerEnter(Collider collision)
{
    if(collision.gameObject.tag=="player")
    {
        Destroy(enemy);
    }

}



}
