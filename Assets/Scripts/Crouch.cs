using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public CircleCollider2D Ccollider ;
    public Animator anim;
    bool isCrouch = false;
    void Start()
    {
        Ccollider = GetComponent<CircleCollider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("s"))
        {
            isCrouch = !isCrouch;
            anim.SetBool("crouch", isCrouch);
            Ccollider.enabled = !Ccollider.enabled;
        }
    }
}