using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{

    public float Speed = 4.5f;
    public float TurnSpeed = 55f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0f, 0f, Speed * Input.GetAxis("Vertical") * Time.deltaTime);

        transform.Rotate(0f,TurnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f);

    }
}
