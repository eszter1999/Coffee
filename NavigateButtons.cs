using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigateButtons : MonoBehaviour
{
    public static NavigateButtons Instance;
    void Awake(){
        Instance = this;
        //GameManager.onGameStateChanged += newState;
    }
    public void GoToStudy(){
        GameManager.Instance.updateGameState(GameState.Study);
        Study.Instance.study();
    }
    public void GoToOrder(){
        GameManager.Instance.updateGameState(GameState.BuySomething);
    }
    public void GoToStart(){
        GameManager.Instance.updateGameState(GameState.SelectActivity);
    }
    public void GoToWashingUp(){
        GameManager.Instance.updateGameState(GameState.WashingUp);
    }

}
