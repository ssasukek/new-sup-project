using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class batteryLife : MonoBehaviour
{
    public float timeValue = 10;
    public Text countTimer;
    public ui_item script;
    public bool NightVisionOn;
    public GameObject greenScreen;

    
    void Start(){
        countTimer.text = timeValue.ToString();
    }

    public void CheckVision(){
        // if (Input.GetKeyDown(KeyCode.P)){
        //     NightVisionOn = true;
        //     if (NightVisionOn == true){
        //         greenScreen.SetActive(true);
        //     }
        // }
        // else if (Input.GetKeyDown(KeyCode.P) && NightVisionOn == true){
        //     greenScreen.SetActive(false);
        // }

        if (Input.GetKeyDown(KeyCode.P)){
            NightVisionOn = true;
        }
        if (NightVisionOn == true){
            greenScreen.SetActive(true);
        }
        if (NightVisionOn == true && Input.GetKeyDown(KeyCode.P)){
            greenScreen.SetActive(false);
        }

    }

    void Update(){
        CheckVision();
        if (timeValue > 0 && NightVisionOn){
            timeValue -= Time.deltaTime;
            countTimer.text = timeValue.ToString();
        }
        if (script.count > 0 && timeValue > 0){
            timeValue = 10;
            greenScreen.SetActive(false);
        }
        else{
            greenScreen.SetActive(false);
        }
    }
}
