using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuController8 : MonoBehaviour
{
  Animator animator;
  Vector3 goal = new Vector3(-20.51f, 0, -5.13f);
  public float startTime;
  public float speed;
  public float rotateTime;
  public float rotateSpeed;
  float seconds;
  float dir;
  // Start is called before the first frame update
  void Start()
  {
    this.animator = GetComponent<Animator>();
    animator.SetFloat("Forward", 0.02f);

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
    if (seconds >= rotateTime && transform.eulerAngles.y >= 5)
    {
      transform.RotateAround(transform.position, new Vector3(0,1,0), rotateSpeed);
    }
  }

  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Stop")
    {
      animator.SetFloat("Forward", 0.0f);
    }
  }
}
