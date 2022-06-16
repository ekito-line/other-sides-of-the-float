using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IController5 : MonoBehaviour
{
    Animator animator;
    Vector3 goal = new Vector3(-10.11f,0,-12.73f);
    public float startTime;
    public float speed;
    float seconds;
    float dir;
    public float rotateTime = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
      this.animator = GetComponent<Animator>();
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
        animator.SetFloat("Forward", 0.02f);
        transform.position = Vector3.Lerp(transform.position, goal, present);
      }
      if (transform.position.x <= -10)
      {
        animator.SetFloat("Forward", 0.0f);
      }

      if (seconds >= rotateTime && transform.eulerAngles.y >= 278)
      {
        transform.RotateAround(transform.position, new Vector3(0,1,0), -1.5f);
      }

    }
}
