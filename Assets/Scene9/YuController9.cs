using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuController9 : MonoBehaviour
{
  Animator animator;
  public float turnTime1;
  public float turnTime2;
  public float addTime1;
  public float addTime2;
  public float turnSpeed;
  public float midAngle;
  Vector3 goal = new Vector3(-3.18f, 0, -7.49f);
  public float startTime;
  public float speed;
  float seconds;
  float dir;
  // Start is called before the first frame update
  void Start()
  {
    this.animator = GetComponent<Animator>();
    Invoke("Turn", turnTime1);
    Invoke("TurnAround", turnTime2);

    // Vector3 start = transform.position;
    // dir = Vector3.Distance(start, goal);
  }

  // Update is called once per frame
  void Update()
  {
    seconds += Time.deltaTime;
    // float present = ((seconds - startTime) * speed) / dir;
    if (seconds >= turnTime1 + addTime1 && seconds < turnTime2 + addTime2)
    {
      float angle1 = Mathf.LerpAngle(30.0f, midAngle, seconds-turnTime1-addTime1);
      transform.eulerAngles = new Vector3(0, angle1, 0);
    }
    if (seconds >= turnTime2 + addTime2 && seconds < startTime)
    {
      float angle2 = Mathf.LerpAngle(midAngle, -150.0f, seconds-turnTime2-addTime2);
      transform.eulerAngles = new Vector3(0, angle2, 0);
    }
    if (seconds >= startTime)
    {
      animator.SetFloat("Forward", 0.02f);
      transform.position = Vector3.MoveTowards(transform.position, goal, speed);
    }
  }

  void Turn()
  {
    animator.SetTrigger("TurnRightTrigger");
  }

  void TurnAround()
  {
    animator.SetTrigger("TurnAroundTrigger");
  }
}
