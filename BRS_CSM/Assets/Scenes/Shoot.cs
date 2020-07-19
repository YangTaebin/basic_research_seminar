using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject GUN = GameObject.FindWithTag("Gun");
        GameObject player = GameObject.FindWithTag("player");
        GameObject unknown = GameObject.FindWithTag("Unknown");
        GameObject pivot = GameObject.Find("Pivot");
        Vector3 vec = this.transform.position;
        Vector3 gun = GUN.transform.position;
        float BulletSpeed = 100.0f;
        float Dis = Vector3.Distance(GUN.transform.position, vec);
        if (Input.GetKey(KeyCode.Space)) {
            this.transform.parent = player.transform.parent;
            Debug.Log(Dis);
            this.transform.Translate(new Vector3 (0.0f, 0.0f, BulletSpeed * Time.deltaTime));
		}
        if (Input.GetKey(KeyCode.R)) {
            this.transform.parent = unknown.transform.parent;
            Debug.Log(Dis);
            this.transform.position = gun;
		}
        if (Input.GetKey(KeyCode.P)) {
            Debug.Log(pivot.transform.rotation);
		}
    }
}
