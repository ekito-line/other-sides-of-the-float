using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController9 : MonoBehaviour
{
  Vector3 goal = new Vector3(-1.65f,1.25f,-3.879f);
  public float startTime;
  public float speed;
  float seconds;
  float dir;

  GameObject Yu;
  YuController9 YuController;
  float startTime1;
  float speed1;
  Vector3 goal1 = new Vector3(-4.36f, 1.25f, -8.57f);
  // Start is called before the first frame update
  void Start()
  {
    Vector3 start = transform.position;
    dir = Vector3.Distance(start, goal);

    Yu = GameObject.Find("Yu");
    YuController = Yu.GetComponent<YuController9>();
    startTime1 = YuController.startTime;
    speed1 = YuController.speed;

  }

  // Update is called once per frame
  void Update()
  {
    seconds += Time.deltaTime;
    float present = ((seconds - startTime) * speed) / dir;
    if (seconds >= startTime && seconds < startTime1)
    {
      transform.position = Vector3.Lerp(transform.position, goal, present);
    }
    if (seconds >= startTime1)
    {
      transform.position = Vector3.MoveTowards(transform.position, goal1, speed1);
    }
  }
}
