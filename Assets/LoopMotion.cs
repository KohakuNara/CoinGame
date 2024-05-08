using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float sin = Mathf.Sin(Time.time);
        this.transform.position = new Vector3(0, 1, sin);
    }
}
