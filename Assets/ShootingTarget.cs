using UnityEngine;
using UnityEngine.UI;
public class ShootingTarget : MonoBehaviour
{
 [SerializeField]
 Text txtScore;
 private int score = 0;
 public int Monscore {
    get { return score; }
    set { score = value; txtScore.text = "Score" + score; } }
 Monscore++;


    RaycastHit hit;
    [SerializeField]
    GameObject prefabExplosion;
   
                  
        
    void Update()
    {
        Vector2 center = new Vector2(Screen.width / 2, Screen.height / 2);
        Ray ray = Camera.main.ScreenPointToRay(center);
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) //Renvoie V si le rayon croise un collider
            { Destroy(hit.collider.transform.gameObject);
                GameObject Go = Instantiate(prefabExplosion, hit.transform.position, Quaternion.identity);
                Destroy(Go, 5f);
            } // Détruire l’ennemi
        }
    }
     
}