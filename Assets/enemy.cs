using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

        speed = Random.Range(0.9f, 0.9f);
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(Camera.main.transform);
        transform.Rotate(Vector3.up * 1f * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
