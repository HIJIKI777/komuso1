using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target) agent.destination = target.transform.position;
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "AttackArea") Destroy(this);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "AttackArea"){
            
            Destroy(this);
        }
    }

}
