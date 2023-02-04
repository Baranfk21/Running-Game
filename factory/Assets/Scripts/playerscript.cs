using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerscript : MonoBehaviour
{


    public float speed = 15.0f;

   
    public GameObject prefab;


public string NewLevel="scenefinal";

public float delay=4;

    // Start is called before the first frame update
    void Start()
    {
          StartCoroutine(LoadLevelAfterDelay(delay));
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

        if(Input.GetKey("a"))
        {
            transform.Translate(-5 * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("d"))
        {
            transform.Translate(5 * Time.deltaTime, 0, 0);
        }
       
      
    }
IEnumerator LoadLevelAfterDelay(float delay)
     {
         yield return new WaitForSeconds(delay);
         SceneManager.LoadScene(NewLevel);
     }

     void OnTriggerEnter(Collider collison)
     {

   

        if(collison.gameObject.tag=="duvarcesit1")
        {
            for(int i=0;i<5;i++)
            {
                GameObject obj=Instantiate(prefab,transform.position,Quaternion.identity);
                collison.tag="Untagged";


            }

        }

        if(collison.gameObject.tag=="duvarcesit2")
        {
             GameObject obj=Instantiate(prefab,transform.position,Quaternion.identity);
             collison.tag="Untagged";
        }


        if(collison.gameObject.tag=="duvarcesit3")
        {
            for(int i=0;i<10;i++)
            {
                GameObject obj=Instantiate(prefab,transform.position,Quaternion.identity);
                collison.tag="Untagged";


            }

        }
        
         if(collison.gameObject.tag=="duvarcesit4")
        {
             GameObject obj=Instantiate(prefab,transform.position,Quaternion.identity);
             collison.tag="Untagged";
        }



          if(collison.gameObject.tag==("enemy"))
          {
            Destroy(prefab);
            
          }

     
        


     }

     

}
