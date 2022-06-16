using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController6 : MonoBehaviour
{
    public float startTime = 3.8f;
    float seconds;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      seconds += Time.deltaTime;
      if (seconds >= startTime && transform.eulerAngles.x <= 100)
      {
        transform.RotateAround(transform.position, transform.right, -0.7f);
      }
    }
}
