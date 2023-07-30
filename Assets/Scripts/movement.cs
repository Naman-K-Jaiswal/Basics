using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public Animator anim;
    public float speed = 10.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dir_x = Input.GetAxisRaw("Horizontal");

       if(dir_x != 0)
       {
            anim.SetFloat("speed", 1);
       }
       else anim.SetFloat("speed", 0);
        //float dir_y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(dir_x * speed * Time.deltaTime, 0, 0);
        transform.position += direction;
    }
}
