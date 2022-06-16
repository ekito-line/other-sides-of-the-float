using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController0 : MonoBehaviour
{
    public GameObject targetObject;
    float seconds;
    public float startTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      Vector3 pos = this.transform.position;
      int y1 = 6;
      int z2 = 69;

      seconds += Time.deltaTime;
      if (seconds >= startTime)
      {
        if (pos.y > y1)
        {
          transform.RotateAround(targetObject.transform.position, new Vector3(1,0,0), 0.3f);
        }

        else if (pos.z > z2)
        {
          transform.Translate(0,0,0.5f);
          // Vector3 target = new Vector3(0,0,0);
          // pos = Vector3.MoveTowards(pos, target, step);
        }
      }      
    }
}
