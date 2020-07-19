using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera CAM1 = GameObject.FindWithTag("Camera1").GetComponent<Camera>();
        Camera CAM2 = GameObject.FindWithTag("Camera2").GetComponent<Camera>();
        float obj_speed = 100.0f;
        if(Input.GetKey(KeyCode.W)) {
            this.transform.Translate(
            new Vector3 (0.0f, 0.0f, obj_speed * Time.deltaTime));
		}
        if (Input.GetKey(KeyCode.S)) {
            this.transform.Translate(
                new Vector3 (0.0f, 0.0f, -1 * obj_speed * Time.deltaTime));  
		}
        if(Input.GetKey(KeyCode.D)) {
            this.transform.Translate(
            new Vector3 (obj_speed * Time.deltaTime, 0.0f, 0.0f));
		}
        if (Input.GetKey(KeyCode.A)) {
            this.transform.Translate(
                new Vector3 (-1 * obj_speed * Time.deltaTime, 0.0f, 0.0f));  
		}
        if (Input.GetKey(KeyCode.J)) {
            this.transform.Rotate(
                new Vector3 (0.0f, -1 * obj_speed * Time.deltaTime, 0.0f));
		}
        if (Input.GetKey(KeyCode.L)) {
            this.transform.Rotate(
                new Vector3 (0.0f, obj_speed * Time.deltaTime, 0.0f));
		}
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            CAM1.depth = 0;
            CAM2.depth = 1;
		}
        if (Input.GetKeyUp(KeyCode.LeftShift)) {
            CAM1.depth = 1;
            CAM2.depth = 0;
		}
    }
}
