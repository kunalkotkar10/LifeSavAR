using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchStep : MonoBehaviour
{
    // Start is called before the first frame update  
    public GameObject[] background;
    public GameObject[] modelParts;
    public GameObject[]  menuButtons;
    public GameObject[] navButtons;
    int index;

    void Start()
    {
      index = 0;
   
    }
        
    void Update()
    {
        
        if(index < 0)
           index = 0 ;
        
        if(index == 0)
        {
            background[0].gameObject.SetActive(true);
        }
        if(index > 0){
            background[0].gameObject.SetActive(false);
        }

    }

    public void Next()
     {
        index += 1;
         
         if(index > background.Length-1){
            index = 1;
         }
         for(int i = 0 ; i < background.Length; i++)
         {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
         }
            Debug.Log(index);
     }
    
     public void Previous()
     {
         index -= 1;

         if(index < 0){
            index = 0;
         }

        for(int i = 0 ; i < background.Length; i++)
         {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
         }
            Debug.Log(index);
     }
      public void CloseMenu(){
         background[0].gameObject.SetActive(false);

         for(int i = 0 ; i < menuButtons.Length; i++)
            {
               menuButtons[i].gameObject.SetActive(false);
            }
         
         for(int i = 0 ; i < navButtons.Length; i++)
            {
               navButtons[i].gameObject.SetActive(true);
            }
         
         for(int i = 0 ; i < modelParts.Length; i++)
         {
            modelParts[i].gameObject.SetActive(true);
         }
        index = 0;
      }
}
