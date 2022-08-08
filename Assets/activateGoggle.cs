using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activateGoggle : MonoBehaviour
{
    public GameObject greenScreen;
    public GameObject timerScreen;
    public Text countTimer;
    public float goggleTime = 10;
    public float batteryTime = 10;
    public bool NightVisionOn;

    void Start(){
        countTimer.text = goggleTime.ToString();
    }

    void Update(){
        CheckTime();
        TurnOnGoggle();
        AddMoreTime();
    }

    public void CheckTime(){
        if(goggleTime > 0 && NightVisionOn){
            goggleTime -= Time.deltaTime;
            countTimer.text = goggleTime.ToString();
        }
        else{
            greenScreen.SetActive(false);
            NightVisionOn = false;
        }
    }

    public void TurnOnGoggle(){
        if (Input.GetKeyDown("g")){
            greenScreen.SetActive(true);
            timerScreen.SetActive(true);
            NightVisionOn = true;
            Debug.Log("goggle on, plus " + goggleTime);
        }
        // if (Input.GetKeyDown("g") && NightVisionOn){
        //     greenScreen.SetActive(false);
        //     goggleTime -= 0;
        // }
    }

    public void AddMoreTime(){
        if (Input.GetKeyDown("p")){
            goggleTime = batteryTime + goggleTime;
            countTimer.text = goggleTime.ToString();
        }
    }
}