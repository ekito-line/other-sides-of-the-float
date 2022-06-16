using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (transform.eulerAngles.y <= 219)
      {
        transform.RotateAround(transform.position, new Vector3(0,1,0), 0.05f);
      }

    }
}
