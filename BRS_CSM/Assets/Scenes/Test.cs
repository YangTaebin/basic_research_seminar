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
        Vector3 vec = this.gameObject.transform.position;
        if(Input.GetKey(KeyCode.W)) {
            float flt_x = Random.Range (-50.0f, 50.0f);
            float flt_y = Random.Range (-50.0f, 50.0f);
            this.gameObject.transform.position = new Vector3 (flt_x, vec.y, flt_y);
		}
    }
}
