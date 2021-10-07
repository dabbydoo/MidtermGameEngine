using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private float movespeed;
    private float dirX, dirZ;
    float jump = 5f;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 5f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * movespeed;
        dirZ = Input.GetAxis("Vertical") * movespeed;



        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb.velocity.y < 0.05 && rb.velocity.y > -0.05)
                rb.velocity = new Vector3(rb.velocity.x, jump, rb.velocity.z);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy1")
        {
            Destroy(col.gameObject);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}