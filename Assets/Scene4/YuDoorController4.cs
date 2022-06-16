using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuDoorController4 : MonoBehaviour
{
    Vector3 goal = new Vector3(-1.2f,0,0);
    float startTime = 4.0f;
    float speed = 0.1f;
    float seconds;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      seconds += Time.deltaTime;
      if (seconds >= startTime)
      {
        float step = speed * (seconds-startTime);
        transform.position = Vector3.MoveTowards(transform.position, goal, step);
      }
    }
}
