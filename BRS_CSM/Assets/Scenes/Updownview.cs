using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updownview : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Turning_speed = 80.0f;
        if (Input.GetKey(KeyCode.I)) {
            this.transform.Rotate(
                new Vector3 (Turning_speed * -Time.deltaTime, 0.0f, 0.0f));
		}
        if (Input.GetKey(KeyCode.K)) {
            this.transform.Rotate(
                new Vector3 (Turning_speed * Time.deltaTime, 0.0f, 0.0f));
		}
    }
}
