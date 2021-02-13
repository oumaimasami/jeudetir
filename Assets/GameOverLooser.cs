using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLooser: MonoBehaviour {
 [SerializeField]
 GameObject GameOver;
 void OnCollisionEnter(Collision collision )
 { GameOver.SetActive(true); }
}