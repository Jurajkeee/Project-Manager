using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_manager : MonoBehaviour {
    [Space(5)]
    [Header("Controll Panel")]
    public background_controller backgroundController;

    [Header("Assets")]
    [Space(2)]

    [Header("Background Sprites")]
    public Sprite[] backgroundImage = new Sprite[6];


    private void Start()
    {

    }
  
}
