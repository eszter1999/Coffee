using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study : MonoBehaviour
{
    public static Study Instance;
    void Awake(){Instance = this;}
    
     public void study(){
        GameManager.StudyDone += 20;
        Debug.Log("Study");
    }
}
