using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeLevels : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void level1(){
        SceneManager.LoadScene(2);
        Time.timeScale = 0;
    }
    public void level2(){
        SceneManager.LoadScene(3);
        Time.timeScale = 0;
    }
     public void level3(){
        SceneManager.LoadScene(4);
        Time.timeScale = 0;
    } public void level4(){
        SceneManager.LoadScene(5);
        Time.timeScale = 0;
    }
    public void level5(){
        SceneManager.LoadScene(6);
        Time.timeScale = 0;
    }
}

