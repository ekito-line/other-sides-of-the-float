using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController8 : MonoBehaviour
{
  public float startTime1 = 2.4f;
  public float speed1 = 0.005f;
  Vector3 goal1 = new Vector3(-20.523f,-0.28f,-3.731f);
  public float rotateTime = 2.9f;
  public float startTime2 = 3.2f;
  public float speed2 = 0.05f;
  Vector3 goal2 = new Vector3(-20.523f,3.0f,-3.731f);
  float seconds;

  // Start is called before the first frame update
  void Start()
  {
    Invoke("Rotate", rotateTime);
  }

  // Update is called once per frame
  void Update()
  {
    seconds += Time.deltaTime;
    if (seconds >= startTime1 && seconds < startTime2)
    {
      transform.position = Vector3.MoveTowards(transform.position, goal1, speed1);
    }
    if (seconds >= startTime2)
    {
      transform.position = Vector3.MoveTowards(transform.position, goal2, speed2);
    }
  }

  void Rotate()
  {
    transform.Rotate(new Vector3(0,0,30));
  }
}
