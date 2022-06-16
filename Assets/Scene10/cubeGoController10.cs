using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGoController10 : MonoBehaviour
{
  Vector3 start = new Vector3(-22.445f, 11.55f, -34.951f);
  Vector3 goal = new Vector3(-22.286f, 11.55f, -35.25f);
  public float startTime;
  public float returnTime;
  public float speed;
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
    float present1 = ((seconds - startTime) * speed) / dir;
    float present2 = ((seconds - returnTime) * speed) / dir;
    if (seconds >= startTime && seconds < returnTime)
    {
      transform.position = Vector3.Lerp(transform.position, goal, present1);
    }
    if (seconds >= returnTime)
    {
      transform.position = Vector3.Lerp(transform.position, start, present2);
    }
  }
}
