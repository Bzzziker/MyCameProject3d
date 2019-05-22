using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCharacterContoller : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;

    public Vector3 target_null_character;
    public bool target_null_character_boll = false;
    public float target_distance;
    public float target_distance_stop = 10;

    private void Awake()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void welk(Vector3 target)
    {
        //target_null_character = target;
        agent.SetDestination(target);
  
    }

}
