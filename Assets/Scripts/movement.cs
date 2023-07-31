using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public LayerMask PlatformLayerMask;
    public Collider2D gd;
    public Animator anim;
    public float jumpForce = 10.0f;
    public float speed = 10.0f;
    bool isJumping = false;
    // private bool isGrounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //gd = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dir_x = Input.GetAxisRaw("Horizontal");
        //float disttoGround = gd.bounds.extents.y;

       if(dir_x != 0)
       {
            anim.SetFloat("speed", 1);
       }
       else anim.SetFloat("speed", 0);
        //float dir_y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(dir_x * speed * Time.deltaTime, 0, 0);
        transform.position += direction;

        // if(Physics.Raycast(transform.position, -Vector3.up, disttoGround + 0.1f, PlatformLayerMask)){
        //     Debug.Log("AIr");
        //     isJumping = false;
        //      isGrounded = true;
        // }


        if (IsGrounded() && Input.GetButtonDown("Jump")){
            Vector3 JumpDirection = Vector3.up;
            rb.AddForce(JumpDirection*jumpForce);
            // isGrounded = false;
            isJumping = true;
        }


        anim.SetBool("jump", !IsGrounded());
    }

    //void OnTriggerEnter(Collider other){
        
    //     if (other.CompareTag("Platform")){
    //         // isGrounded = true;
    //         Debug.Log("Yo");
    //         isJumping = false;
    //     }
    private bool IsGrounded(){
        float disttoGround = gd.bounds.extents.y;
        RaycastHit2D raycastHit = Physics2D.Raycast(gd.bounds.center, -Vector3.up, disttoGround + 0.5f, PlatformLayerMask);
        return raycastHit.collider != null;
    }
}
