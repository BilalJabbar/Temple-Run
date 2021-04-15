using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class PlayerController : MonoBehaviour
{


    [SerializeField]
    private AudioClip jumpClip;
    private Rigidbody2D rb;
    private bool canJump= false;
    public float jumpForce = 12f, rightForce = 0f;
    private Button jumpBtn;


    Vector2 movem;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpBtn = GameObject.Find("Jump Button").GetComponent<Button>();
        jumpBtn.onClick.AddListener(() => Jump());
    }

    public void Jump()
    {
        if (canJump)
        {
            canJump = false;
            if (transform.position.x < 0)
            {
                rightForce = 1f;
            }
            else
            {
                rightForce = 0;
            }
            rb.velocity = new Vector2(rightForce, jumpForce);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   

        if (Mathf.Abs(rb.velocity.y) == 0)
        {
            canJump = true;
        }
        

    }
}
