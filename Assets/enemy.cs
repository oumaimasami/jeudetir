using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
        speed = Random.Range(0.1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.LookAt(Camera.main.transform);
       // transform.Rotate(Vector3.up * 10f * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
