using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeManager10 : MonoBehaviour
{
    public float changeTime;
    GameObject oldCube;
    GameObject newCube;
    // Start is called before the first frame update
    void Start()
    {
      oldCube = GameObject.Find("cubeYu");
      newCube = GameObject.Find("cubeYuNew");
      newCube.SetActive(false);
      Invoke("Change", changeTime);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Change()
    {
      // 表示状態を逆転
      oldCube.SetActive(false);
      newCube.SetActive(true);
    }
}
