using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCharacterContoller : MonoBehaviour
{
    public Vector3 t_target;
    public GameObject a_target;
    NavMeshAgent agent;
    Animator ani;

    public Vector3 target_null_character;
    public bool target_null_character_boll = false;
    public float target_distance;
    public float target_distance_stop = 10;



    public float testdistance;

    public enum anicontrols
    {
        Welk,
        Idle,
        Attack
    }
    private void Awake()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        ani = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if((t_target!=null)&&(Vector3.Distance(t_target, transform.position))>1)
        {
            anicontorl(anicontrols.Welk); 
           // anicontrols.GetValue()

        }
        else
        {
            anicontorl(anicontrols.Idle);
            
        }
    }


    public void anicontorl(anicontrols str)
    {
        switch(str)
        {
            case anicontrols.Idle:
                {
                    this.ani.SetBool("Idle", true);
                    this.ani.SetBool("Welk", false);
                    this.ani.SetBool("Attack", false);
                }
                break;
            case anicontrols.Welk:
                {
                    this.ani.SetBool("Idle", false);
                    this.ani.SetBool("Welk", true);
                    this.ani.SetBool("Attack", false);
                }
                break;
            case anicontrols.Attack:
                {
                    this.ani.SetBool("Idle", false);
                    this.ani.SetBool("Welk", false);
                    this.ani.SetBool("Attack", true);
                }
                break;

        }
       // if(anicontrols.Idle)
       // {
       //     this.ani.SetBool("Idle", true);
       //     this.ani.SetBool("Welk", false);
       //     this.ani.SetBool("Attack", false);


       // }
       //if(str == "Welk")
       // {
       //     this.ani.SetBool("Idle", false);
       //     this.ani.SetBool("Welk", true);
       //     this.ani.SetBool("Attack", false);
       // }
       //if(str == "Attack")
       // {
       //     this.ani.SetBool("Idle", false);
       //     this.ani.SetBool("Welk", false);
       //     this.ani.SetBool("Attack", true);
       // }
    }

    public void welk(Vector3 target)
    {
        //target_null_character = target;
        agent.SetDestination(target);
        //testdistance =  Vector3.Distance(target, transform.position);
        t_target = target;
    }

    public void Attack(GameObject target)
    {

        agent.SetDestination(target.transform.position);
    }

}
