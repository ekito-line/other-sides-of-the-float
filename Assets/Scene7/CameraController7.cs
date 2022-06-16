using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController7 : MonoBehaviour
{
  public float startTime = 1.85f;
  float seconds;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    seconds += Time.deltaTime;
    if (seconds >= startTime)
    {
      // transform.RotateAround(transform.position, transform.right, -0.5f);
      float angle = Mathf.LerpAngle(17.5f, -21.7f, seconds-startTime);
      transform.eulerAngles = new Vector3(angle,282.926f,0);
    }
  }
}
