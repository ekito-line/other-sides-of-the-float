using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController1 : MonoBehaviour
{
  float seconds;
  public float nextTime;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    seconds += Time.deltaTime;
    if (seconds >= nextTime)
    {
      SceneManager.LoadScene("second");
    }

  }
}
