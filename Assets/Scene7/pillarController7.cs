using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillarController7 : MonoBehaviour
{
    public GameObject axis;
    public float startTime = 1.2f;
    float speed = -0.6f;
    float seconds;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      seconds += Time.deltaTime;
      if (seconds >= startTime && transform.position.z >= -6.65)
      {
        float step = speed * (seconds - startTime) * (seconds - startTime);
        transform.RotateAround(axis.transform.position, new Vector3(1,0,0), step);
      }

    }
}
