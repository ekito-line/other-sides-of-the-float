using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaitoCaseController4 : MonoBehaviour
{
    Vector3 goal = new Vector3(-6.5f, 1.42f, -14f);
    float startTime = 4.5f;
    float speed = 1.2f;
    float seconds;
    float dir;

    // Start is called before the first frame update
    void Start()
    {
      Vector3 start = transform.position;
      dir = Vector3.Distance(start, goal);
    }

    // Update is called once per frame
    void Update()
    {
      seconds += Time.deltaTime;
      float present = ((seconds - startTime) * speed) / dir;
      if (seconds >= startTime)
      {
        transform.position = Vector3.Lerp(transform.position, goal, present);
      }
    }
}
