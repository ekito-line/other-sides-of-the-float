using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuController11 : MonoBehaviour
{
  Animator animator;
  Vector3 goal = new Vector3(-2.5f, 0, -2.38f);
  public float startTime;
  public float speed;
  float seconds;
  float dir;
  // Start is called before the first frame update
  void Start()
  {
    this.animator = GetComponent<Animator>();
    animator.SetFloat("Forward", 0.02f);

    // Vector3 start = transform.position;
    // dir = Vector3.Distance(start, goal);
  }

  // Update is called once per frame
  void Update()
  {
    seconds += Time.deltaTime;
    // float present = ((seconds - startTime) * speed) / dir;
    if (seconds >= startTime)
    {
      transform.position = Vector3.MoveTowards(transform.position, goal, speed);
    }
  }

  void OnTriggerExit(Collider other)
  {
    if (other.gameObject.tag == "Stop")
    {
      animator.SetFloat("Forward", 0.0f);
    }
  }
}
