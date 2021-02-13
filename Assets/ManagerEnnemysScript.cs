using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ManagerEnnemysScript : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float rayon = 0.1f, delay = 0f, h = 0.1f;
    void Start()
    {
        InvokeRepeating("Generation", 0f, delay);
    } // Répéter la fonction Generation d’une manière régulière
      // Après N secondes (ici 0), avec une fréquence = delay
    void Generation()
    {
        int angle = Random.Range(1, 180);
        Vector3 pos = Vector3.zero;
        pos.x = transform.position.x + rayon * Mathf.Cos(angle);
        pos.z = transform.position.z + rayon * Mathf.Sin(angle);
        pos.y = Random.Range(-h, h);
        GameObject go = Instantiate(enemy, pos, Quaternion.identity);
    }
}