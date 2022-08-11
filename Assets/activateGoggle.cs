using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activateGoggle : MonoBehaviour
{
    public GameObject greenScreen;
    // public GameObject timerScreen;
    public Text countTimer;
    public float goggleTime = 10;
    public float batteryTime = 10;
    public bool NightVisionOn = false;
    public GameObject zombie;


    void Start(){
        countTimer.text = goggleTime.ToString();
        zombie = GameObject.FindGameObjectWithTag("Zomb");
        zombie.GetComponent<Renderer>().enabled = false;
    }

    void Update(){
        CheckTime();
        AddMoreTime();
        if (Input.GetKeyDown("g") && NightVisionOn == false){
            TurnOnGoggle();
        }
        else if (Input.GetKeyDown("g") && NightVisionOn == true){
            TurnOffGoggle();
        }
    }

    public void CheckTime(){
        if(goggleTime > 0 && NightVisionOn){
            goggleTime -= Time.deltaTime;
            countTimer.text = goggleTime.ToString();
        }
        else{
            greenScreen.SetActive(false);
            NightVisionOn = false;
            zombie.GetComponent<Renderer>().enabled = false;
        }
    }

    public void TurnOnGoggle(){
        greenScreen.SetActive(true);
        // timerScreen.SetActive(true);
        NightVisionOn = true;
        zombie.GetComponent<Renderer>().enabled = true;
    }

    public void TurnOffGoggle(){
        NightVisionOn = false;
        greenScreen.SetActive(false);
        // timerScreen.SetActive(false);
        goggleTime -= 0;
        zombie.GetComponent<Renderer>().enabled = false;
    }

    public void AddMoreTime(){
        if (Input.GetKeyDown("p")){
            goggleTime = batteryTime + goggleTime;
            countTimer.text = goggleTime.ToString();
        }
    }
}