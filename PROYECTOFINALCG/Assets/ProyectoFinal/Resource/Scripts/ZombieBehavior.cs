using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieBehavior : MonoBehaviour
{
    public Transform Objetivo;
    public float Velocidad;
    public NavMeshAgent IA;

    public Animation Anim;
    public string NombreAnimacionCaminar;
    public string NombreAnimacionAtacar;


    // Update is called once per frame
    void Update()
    {
        IA.speed = Velocidad;
        IA.SetDestination(Objetivo.position);


        if(IA.velocity == Vector3.zero)
        {
            Anim.CrossFade(NombreAnimacionAtacar);
        }
        else
        {
            Anim.CrossFade(NombreAnimacionCaminar);
        }
    }
}
