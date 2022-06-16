using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuController5 : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
      this.animator = GetComponent<Animator>();
      animator.SetFloat("Forward", 0.02f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
      if (other.gameObject.tag == "Stop")
      {
        animator.SetFloat("Forward", 0.0f);
      }
    }
}
