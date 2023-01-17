using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level5 : MonoBehaviour
{
    public FireButton m_fb;
    public GameManager m_gm;
	public TextMeshProUGUI m_txt;
    public RadialCountdown countdown;
    public GameObject gameoverscreen;
    public GameObject completedscreen;
    public GameObject leveltargetscreen;
    public GameObject bulletgameoverscreen;
    private int totalbullets = 8;
    public GameObject[] bulletno;

    // Start is called before the first frame update
    void Start()
    {
    countdown = countdown.GetComponent<RadialCountdown>();
    countdown.countdownsecond = 10f;
    countdown.timeremaining = countdown.countdownsecond;
    m_fb = m_fb.GetComponent<FireButton>();
    m_gm = m_gm.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        m_txt.text ="Toons Killed :"+ m_fb.toonkilled.ToString();
        Debug.Log(m_fb.lv5bullets);
        if(countdown.seconds == 0)
        {
        if(m_fb.toonkilled >= 8)
        {
            Debug.Log("Level completed");
            completedscreen.SetActive(true);
                                                Time.timeScale = 0;

        }
        else if(m_fb.toonkilled != 8)
        {
            Debug.Log("Game over");
            gameoverscreen.SetActive(true);
                                                Time.timeScale = 0;


        }
        }
        else
        {
            if(m_fb.toonkilled == 8)
            {
Debug.Log("Level completed");
            completedscreen.SetActive(true);
                        Time.timeScale = 0;

            }
            else if(m_fb.lv5bullets<=0 && m_fb.toonkilled != 8)
            {
                 Debug.Log("Game over");
            bulletgameoverscreen.SetActive(true);
            Time.timeScale = 0;
            }
        }
        if(totalbullets != m_fb.lv5bullets)
        {
          float n =  totalbullets - m_fb.lv5bullets;
          for(int i = 0 ;i < n ;i++)
          {
            bulletno[i].GetComponent<Image>().color = Color.white;
          }
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
