using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_item : MonoBehaviour
{
    public static ui_item instance;
    public Text countText;
    public int count = 0;

    private void Awake(){
        instance = this;
    }

    void Start(){
        countText.text = count.ToString();
    }

    public void CountItem(){
        count++;
        countText.text = count.ToString();
    }

    public void RemoveCountItem(){
        if (count > 0){
            count--;
            countText.text = count.ToString();
        }
        else{
            Debug.Log("No more battery");
        }
    }
}