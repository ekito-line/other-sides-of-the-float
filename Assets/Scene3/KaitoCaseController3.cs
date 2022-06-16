using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaitoCaseController3 : MonoBehaviour
{
    Vector3 goal = new Vector3(0.7f, 0.4f,-2.1f);
    float speed = 0.45f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      float step = speed * Time.deltaTime;
      transform.position = Vector3.MoveTowards(transform.position, goal, step);
    }
}
