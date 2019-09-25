using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject Target;

    public float SmoothSpeed;

    private void Update()
    {

        transform.position = Vector3.Lerp(transform.position, Target.transform.position, Time.deltaTime * SmoothSpeed);
        transform.LookAt(Target.transform.parent);

    }

}
