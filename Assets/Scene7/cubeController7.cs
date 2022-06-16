using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController7 : MonoBehaviour
{
  Vector3 goal = new Vector3(-20.587f,0.1f,-3.143f);
  float startTime = 0.1f;
  float speed = 0.1f;
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
