using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovSurvivor : MonoBehaviour
{
    public float speedMove;
    public float speedRotation;
    private Animator anim;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * speedRotation, 0);

        transform.Translate(0, 0, y * Time.deltaTime * speedMove);

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetFloat("VelX", 0);
            anim.SetFloat("VelY", 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetFloat("VelX", 0);
            anim.SetFloat("VelY", -1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetFloat("VelX", -1);
            anim.SetFloat("VelY", 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetFloat("VelX", 1);
            anim.SetFloat("VelY", 0);
        }
        else
        {
            anim.SetFloat("VelX", 0);
            anim.SetFloat("VelY", 0);
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    anim.SetTrigger("Jump");
        //}

        //if (Input.GetKeyDown(KeyCode.T))
        //{
        //    anim.SetTrigger("Thriller");
        //}
    }
}
