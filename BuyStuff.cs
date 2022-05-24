
using System.Diagnostics;
//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyStuff : MonoBehaviour
{
    
    public void BuyCoffee(){
        try{
            GameManager.Money -= 5;
        }
        catch (ArgumentOutOfRangeException e){
            Debug.Log("mosogatni kell");
        }
        Debug.Log("Buy coffee");
    }

    public void BuyTea(){
        try{
        GameManager.Money -= 3;
        }
        catch (ArgumentOutOfRangeException e){
            Debug.Log("mosogatni kell");
        }
        Debug.Log("Buy tea");
    }

    public void BuyCake(){
        try{
            
        GameManager.Money -= 4;
        }
        catch (ArgumentOutOfRangeException e){
            Debug.Log("mosogatni kell");
        }
        Debug.Log("Buy cake");
    }
}
