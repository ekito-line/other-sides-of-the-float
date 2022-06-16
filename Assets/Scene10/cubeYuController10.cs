using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeYuController10 : MonoBehaviour
{
  Vector3 goal = new Vector3(-22.286f, 11.54f, -35.25f);
  float seconds;
  float dir;

  GameObject cubeGo;
  cubeGoController10 cubeGoController;
  float startTime;
  float speed;
  // Start is called before the first frame update
  void Start()
  {
    cubeGo = GameObject.Find("cubeGo");
    cubeGoController = cubeGo.GetComponent<cubeGoController10>();
    startTime = cubeGoController.startTime;
    speed = cubeGoController.speed;

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
