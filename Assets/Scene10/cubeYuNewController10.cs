using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeYuNewController10 : MonoBehaviour
{
  Vector3 start = new Vector3(-22.021f, 11.54f, -35.749f);
  float seconds;
  float dir;

  GameObject cubeGo;
  cubeGoController10 cubeGoController10;
  float returnTime;
  float speed;

  GameObject cubeManager;
  cubeManager10 cubeManager10;
  float changeTime;
  // Start is called before the first frame update
  void Start()
  {
    cubeGo = GameObject.Find("cubeGo");
    cubeGoController10 = cubeGo.GetComponent<cubeGoController10>();
    returnTime = cubeGoController10.returnTime;
    speed = cubeGoController10.speed;

    cubeManager = GameObject.Find("cubeManager");
    cubeManager10 = cubeManager.GetComponent<cubeManager10>();
    changeTime = cubeManager10.changeTime;

    Vector3 goal = transform.position;
    dir = Vector3.Distance(start, goal);
  }

  // Update is called once per frame
  void Update()
  {
    seconds += Time.deltaTime;
    float startTime = returnTime - changeTime;
    float present = ((seconds - startTime) * speed) / dir;
    if (seconds >= startTime)
    {
      transform.position = Vector3.Lerp(transform.position, start, present);
    }
  }
}
