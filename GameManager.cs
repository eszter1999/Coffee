using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
//using System.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState state;
    public static event Action<GameState> onGameStateChanged;

    //cameras
    public GameObject camStart;
    public GameObject camBuy;
    public GameObject camStudy;
    public GameObject camWashingUp;
    
    private static int money = 10;
    public static int Money{
        get{return money;}
        set{
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "It must be above 0;-");
            else money = 10;
            MoneyAndStudyManager.Instance.moneyChanged();
        }
    }
    private static int studyDone = 0;
    public static int StudyDone{
        get{return studyDone;}
        set{
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "It must be above 0%");
            else if (value < 100)
                throw new ArgumentOutOfRangeException(nameof(value), "It must be below 100%");
            else studyDone = value;
                MoneyAndStudyManager.Instance.studyChanged();
            }
    }
    private void Awake() {
        Instance = this;
    }

    void Start(){
        updateGameState(GameState.SelectActivity);
    }
    
    public void updateGameState(GameState newState){
        state = newState;

        switch (newState){
        case GameState.SelectActivity:
            startState();
            break;
        case GameState.BuySomething:
            BuyState();
            break;
        case GameState.Study:
            StudyState();
            break;
        case GameState.WashingUp:
            WashingUpState();
            break;
        case GameState.Done:
            break;
        default:
            throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        onGameStateChanged?.Invoke(newState);
    }

    void startState(){
        camStart.SetActive(true);   //this is true
        camBuy.SetActive(false);
        camStudy.SetActive(false);
        camWashingUp.SetActive(false);

        

        Debug.Log("selectState");
    }
    void BuyState(){
        camStart.SetActive(false);
        camBuy.SetActive(true);     //this is true
        camStudy.SetActive(false);
        camWashingUp.SetActive(false);
        Debug.Log("BuySomethingState");
    }
    void StudyState(){
        camStart.SetActive(false);
        camBuy.SetActive(false);
        camStudy.SetActive(true);   //this is true
        camWashingUp.SetActive(false);
        Debug.Log("StudyState");
    }
    void WashingUpState(){
        
    }
}

public enum GameState{
    SelectActivity,
    Study,
    BuySomething,
    WashingUp,
    Done
}