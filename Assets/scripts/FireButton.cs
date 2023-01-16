using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera fpscamera;
    public GameObject cubePrefab;
    private GameObject toon;
    private GameObject hitobj;
    private float range = 100f;
    public GameManager m_gm; 
    public int hitscore;
    public level1 m_lvl;

    void Start()
    {
        m_lvl = m_lvl.GetComponent<level1>();
        m_gm = m_gm.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
     //   Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
       //     Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
    }
   public void onpressed()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpscamera.transform.position,fpscamera.transform.forward,out hit,range))
        {
            hitobj = hit.transform.gameObject;
            m_lvl.bullets--;
   //Debug.Log(hitobj.tag);     
            destroyToons();
        }
        
            
        
    }
void destroyToons(){
    if(hitobj.tag == "Toons")
    {
        Destroy(hitobj);
        m_gm.enemiesalive--;
         hitscore += 20;
         m_lvl.toonskilled++;
    }
}
}
