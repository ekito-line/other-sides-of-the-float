using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController8 : MonoBehaviour
{
  public float startTime = 3.371f;
  float seconds;
  public float rotateTime = 6.3f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    seconds += Time.deltaTime;
    if (seconds >= startTime && transform.eulerAngles.x <= 100)
    {
      transform.RotateAround(transform.position, transform.right, -1.2f);
    }
    if (seconds >= rotateTime && transform.eulerAngles.y <= 265)
    {
      transform.RotateAround(transform.position, new Vector3(0,1,0), 0.6f);
    }
  }
}
