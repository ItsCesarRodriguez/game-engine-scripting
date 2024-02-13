using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfCode : MonoBehaviour
{

    public int apples;
    public int bananas;

    // Start is called before the first frame update
    void Start()
    {
        if(true) 
        {
            Debug.Log("this is true");
        }
        else
        {
            Debug.Log("this is not true");
        }
    }

        [ContextMenu("Execute If Test")]
        void ExecuteIfTest()
        {


            if (apples == 4 && bananas ==2)
            {
                Debug.Log(string.Format("we have {0}",apples));
            }
            else
            {
                Debug.Log("we do not have 4 apples");
            }

        }
  
    

    
}
