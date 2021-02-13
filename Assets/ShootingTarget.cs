using UnityEngine;
using UnityEngine.UI;
public class ShootingTarget : MonoBehaviour
{
    AudioSource MyAudioSource;
    [SerializeField]
    AudioClip ShootSound, ExplosionSound;
    private void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
    }


    public Text txtscore;

    public void MajScore(int sc)
    {
        txtscore.text = sc.ToString();
    }

    RaycastHit hit;
    [SerializeField]
    GameObject prefabExplosion;

    [SerializeField]
    private int score = 0;

    void Update()
    {
         Vector2 center = new Vector2(Screen.width / 2, Screen.height / 2);
          Ray ray = Camera.main.ScreenPointToRay(center);
          if (Input.GetButtonDown("Fire1"))
          {
            MyAudioSource.PlayOneShot(ShootSound); // lancer le bruitage de tir 
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) //Renvoie V si le rayon croise un collider
              { Destroy(hit.collider.transform.gameObject);
                MyAudioSource.PlayOneShot(ExplosionSound); // lancer le bruitage de l’explosion 
                GameObject enemy = Instantiate(prefabExplosion, hit.transform.position, Quaternion.identity);
             
                Destroy(enemy, 4f);
                
                score++;
                GameObject.Find("Canvas").GetComponent<ShootingTarget>().MajScore(score);
                
            } //Détruire l’ennemi
           
        }

   
    }
    
}