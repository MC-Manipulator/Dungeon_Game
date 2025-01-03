using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public int Health;
    public int Exp;
    public PlayerInventoryManager playerInventoryManager;
    public Text HealthText;
    public Text ExpText;
    
    private void Awake(){
        Instance = this;
        playerInventoryManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventoryManager>();
    }

    public void IncreaseHealth(int value){
        Health += value;
        HealthText.text = $"HP:{Health}";
    }
    public void IncreaseExp(int value){
        Exp += value;
        ExpText.text = $"EXP:{Exp}";
    }

}
