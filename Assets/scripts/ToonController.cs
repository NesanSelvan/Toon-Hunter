using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToonController : MonoBehaviour
{
    private Animator m_an;
    private Rigidbody m_rb;
    public GameObject toonobj;
    private CharacterController m_ch;
    public GameObject checkpoint;
    public GameManager m_gm;
private Vector3 randomposition;
    
    // Start is called before the first frame update
    void Start()
    {
        m_gm = m_gm.GetComponent<GameManager>();
        m_rb = GetComponent<Rigidbody>();
        m_an = GetComponent<Animator>();
        m_ch = GetComponent<CharacterController>();
       
    }

private void FixedUpdate()
{
         m_rb.AddForce(Physics.gravity);
}
    // Update is called once per frame
    void Update()
    {
        
       if(toonobj.name == "Cow"|| toonobj.name == "Cow(Clone)"||toonobj.name == "Pig"||toonobj.name == "Pig(Clone)")
       {
        m_an.SetInteger("animation",1);
 
          movetoon();
       }
     else if(toonobj.name == "Cow1"|| toonobj.name == "Cow1(Clone)"||toonobj.name == "Pig1(Clone)"||toonobj.name == "Pig1")
       {
        m_an.SetInteger("animation",2);
       }
       else if(toonobj.name == "Cow2"|| toonobj.name == "Cow2(Clone)"||toonobj.name == "Pig2"||toonobj.name == "Pig2(Clone)")
       {
  
            m_an.SetInteger("animation",3);
                    movetoon();

 
   
       }
       
       //    toon = GameObject.FindGameObjectsWithTag("Toons");
//     for (int i = 0; i < toon.Length; i++)
//     {
//         //Return GameObject if the name Matches
      
//         toonname =  toon[i].name;
//         //Debug.Log(toonname);
//     }
    
//    if(toonname == "Pig" || toonname == "Pig(Clone)")
//    {
// Debug.Log("its Pig");
//    }
//    else if(toonname == "Cow" || toonname == "Cow(Clone)")
//    {
// Debug.Log("its cow");
//    }
//    else if(toonname == "chicken" || toonname == "chicken(Clone)")
//    {
// Debug.Log("its chicken");
//    }
       

        
        
        
        
    }
    void movetoon(){

        Vector3 target = checkpoint.transform.position;
        float dist = Vector3.Distance(transform.position, target);
        Vector3 movePosition = Vector3.Slerp(transform.position, target, 0f * Time.deltaTime);
        transform.LookAt(target);
        if (dist > 1)
        {
            // transform.position += target * 2 * Time.deltaTime;

        m_rb.MovePosition(transform.position + target * Time.deltaTime * 0.1f);
        }else if(dist > 20){
            Destroy(this.gameObject);
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
         if(other.collider.tag == "Finish")
 {
m_gm.enemiesalive--;
 Destroy(this.gameObject);
 }
    }
}

 

 
