using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level1 : MonoBehaviour
{
    public FireButton m_fb;
    public GameManager m_gm;
    public int toonskilled;
	public TextMeshProUGUI m_txt;
    public RadialCountdown countdown;
    public GameObject gameoverscreen;
    public GameObject completedscreen;
    public GameObject leveltargetscreen;
    public int bullets = 5;
    public GameObject[] bulletno;

    // Start is called before the first frame update
    void Start()
    {
               countdown = countdown.GetComponent<RadialCountdown>();
        m_fb = m_fb.GetComponent<FireButton>();
        m_gm = m_gm.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(bullets);
        m_txt.text ="Toons Killed :"+ toonskilled.ToString();
        Debug.Log(countdown.seconds);
        if(countdown.seconds == 0)
        {
        if(toonskilled >= 3)
        {
            Debug.Log("Level completed");
            completedscreen.SetActive(true);
        }
        else if(toonskilled != 3)
        {
            Debug.Log("Game over");
            gameoverscreen.SetActive(true);

        }
        }
        else
        {
            if(toonskilled == 3)
            {
Debug.Log("Level completed");
            completedscreen.SetActive(true);
                        Time.timeScale = 0;

            }
            else if(bullets<=0 && toonskilled != 3)
            {
                 Debug.Log("Game over");
            gameoverscreen.SetActive(true);
            Time.timeScale = 0;
            }
        }
        
        if(bullets == 4)
        {
            bulletno[4].GetComponent<Image>().color = Color.white;
        }
        else if(bullets == 3)
        {
            bulletno[4].GetComponent<Image>().color = Color.white;
            bulletno[3].GetComponent<Image>().color = Color.white;

        }
        else if(bullets == 2)
        {
            bulletno[4].GetComponent<Image>().color = Color.white;
            bulletno[3].GetComponent<Image>().color = Color.white;
            bulletno[2].GetComponent<Image>().color = Color.white;

        }
        else if(bullets == 1)
        {
            bulletno[4].GetComponent<Image>().color = Color.white;
            bulletno[3].GetComponent<Image>().color = Color.white;
            bulletno[2].GetComponent<Image>().color = Color.white;
            bulletno[1].GetComponent<Image>().color = Color.white;

        }
        else if(bullets == 0)
        {
            bulletno[4].GetComponent<Image>().color = Color.white;
            bulletno[3].GetComponent<Image>().color = Color.white;
            bulletno[2].GetComponent<Image>().color = Color.white;
            bulletno[1].GetComponent<Image>().color = Color.white;
            bulletno[0].GetComponent<Image>().color = Color.white;

        }
    }
    public void nextlevel()
    {
        SceneManager.LoadScene(0);

    }
    public void leveltarget()
    {
        Time.timeScale = 1;
        leveltargetscreen.SetActive(false);
    }
}
