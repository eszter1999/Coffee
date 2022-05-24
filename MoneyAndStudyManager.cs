using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyAndStudyManager : MonoBehaviour
{
    public static MoneyAndStudyManager Instance;
    
    public TextMesh startMoney;
    public TextMesh studyMoney;
    public TextMesh buyMoney;

    public TextMesh startStudy;
    public TextMesh studyStudy;
    public TextMesh buyStudy;

    void Awake(){Instance = this;}

    public void moneyChanged(){
        startMoney.text = "Money: " + GameManager.Money;
        studyMoney.text = "Money: " + GameManager.Money;
        buyMoney.text = "Money: " + GameManager.Money;
    }
    public void studyChanged(){
        startStudy.text = "Studied: "+GameManager.StudyDone+"%";
        studyStudy.text = "Studied: "+GameManager.StudyDone+"%";
        buyStudy.text = "Studied: "+GameManager.StudyDone+"%";
    }
}
