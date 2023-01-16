using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject menubar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pausemenuactive(){
menubar.SetActive(true);
        Time.timeScale = 0;
    }
    public void resume(){
         Time.timeScale = 1;
        menubar.SetActive(false);
    }
    public void restart(){
 SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 
        Time.timeScale = 0;    
        }
        public void exit(){
            SceneManager.LoadScene(0);
        }
}
