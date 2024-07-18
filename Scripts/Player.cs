using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float bounceforce ;
    public GameObject Gameover;
  
    public GameObject SplashPrefab;
    public ParticleSystem win;


    public static bool GameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        Gameover.SetActive(false);
        win.Pause();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {


        if (GameOver) return;
        rb.velocity = new Vector3(rb.velocity.x, bounceforce * Time.deltaTime, rb.velocity.z);
        
         
       GameObject Splash= Instantiate(SplashPrefab, transform.position,transform.rotation);
       Splash.transform.parent = other.gameObject.transform;
        
        if (other.gameObject.tag=="Finish")
        {
            rb.velocity = Vector3.zero;
            Gameover.SetActive(true);
            GameOver = true;
            
            
        }  

        if(other.gameObject.tag=="winner")
        {
            Gameover.SetActive(true);
            win.Play();
        }

       
    }
 
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
        GameOver = false;

    }
    public void restartl2()
    {
        SceneManager.LoadScene("Level2");
        GameOver = false;

    }
}
