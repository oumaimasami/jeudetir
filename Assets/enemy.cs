using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {

        speed = Random.Range(4f, 4f);
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(Camera.main.transform);
        transform.Rotate(Vector3.up * 1f * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
