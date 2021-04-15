using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    private Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Angular")
        {
            anim.Play("idle");
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Angular")
        {
            anim.Play("run");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
