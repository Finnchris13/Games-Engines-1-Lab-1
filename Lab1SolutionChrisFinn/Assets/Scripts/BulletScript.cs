using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float Speed = 60f;
    public float Thrust = 2500f;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * Thrust);

        Destroy(gameObject, 5);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        transform.position += transform.forward * (Speed * Time.deltaTime);
        */

        /*
        rb.AddForce(transform.forward * Thrust);
        */

        
    }
}
