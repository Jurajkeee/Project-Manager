using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class background_controller : MonoBehaviour {
    private GameObject background;

    private void Start()
    {
        background = this.gameObject;
        if (background == null) Debug.LogError(this.name + "Background Not Found");       
    }

    private float FindAspectRatio(){
        var imageComponent = background.GetComponent<Image>();
        var width = imageComponent.sprite.bounds.size.x;
        var height = imageComponent.sprite.bounds.size.y;
        Debug.Log(this.name + "Aspect Ratio = " + width / height);
        return width / height;
    }

    public void SetNewBackGroundImage(Sprite image){
        background.GetComponent<Image>().sprite = image;
        background.GetComponent<AspectRatioFitter>().aspectRatio = FindAspectRatio();
    }    
}
