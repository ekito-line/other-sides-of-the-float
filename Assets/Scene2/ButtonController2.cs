using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Invoke("Push", 1);
      Invoke("Pull", 1.3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Push()
    {
      transform.Translate(0,-2,0);
    }
    void Pull()
    {
      transform.Translate(0,0.5f,0);
    }
}
