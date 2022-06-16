using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController5 : MonoBehaviour
{
  Vector3 goal = new Vector3(-10.734f,1.25f,-12.628f);
  public float startTime = 7.5f;
  public float speed = 0.5f;
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
