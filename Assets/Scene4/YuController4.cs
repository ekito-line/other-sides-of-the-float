using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuController4 : MonoBehaviour
{
    Animator animator;
    Vector3 goal = new Vector3(-24.55f,0,-11.8f);
    float startTime = 4.3f;
    float speed = 0.1f;
    float seconds;
    float dir;

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
      float present = ((seconds-startTime) * speed) / dir;
      if (seconds >= startTime)
      {
        animator.SetFloat("Forward", 0.02f);
        transform.position = Vector3.Lerp(transform.position, goal, present);
      }
      if (transform.position.z >= -12.0f)
      {
        animator.SetFloat("Forward", 0.0f);
      }
    }
}
