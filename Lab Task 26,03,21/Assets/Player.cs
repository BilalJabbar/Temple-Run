using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed = 3f;

    public Rigidbody2D rigidbody2D;

    Vector2 movem;

    public Text textCoin;

    public int collectedCoins = 0;

   

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {

      
        movem.x = Input.GetAxisRaw("Horizontal");
        movem.y = Input.GetAxisRaw("Vertical");

       

    }

    void FixedUpdate()
    {

        rigidbody2D.MovePosition(rigidbody2D.position + movem * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody2D.MovePosition(rigidbody2D.position + movem * Time.fixedDeltaTime*5);
        }
    }

    //Just hit another collider 2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    //Hitting a collider 2D
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Stay Collision");
    }

    //Just stop hitting a collider 2D
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exit Collision");
    }

    //Just overlapped a collider 2D
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("On Trigger Enter 2D");
       if(collision.gameObject.tag == "coin")
        {
            collectedCoins += 1;
            textCoin.text = "Coins:" + collectedCoins.ToString();
            GameObject.Destroy(collision.gameObject);
        }
    }

    //Overlapping a collider 2D
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("On Trigger Stay 2D");
    }

    //Just stop overlapping a collider 2D
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("On Trigger Exit 2D");
    }


}
