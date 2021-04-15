using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angular : MonoBehaviour
{

    private float speed = -3f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, 0f); 
    }
}
