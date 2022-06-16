using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillarYuController6 : MonoBehaviour
{
  Vector3 goal = new Vector3(-3.1176f,0,2.0f);
  public float startTime = 3.5f;
  public float speed = 0.007f;
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
