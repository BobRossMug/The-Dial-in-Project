using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStuffs : MonoBehaviour {
    
    public Slider grindSizeSlider;
    public GrindSettings grinder;
    public EspressoMachine brewer;
    public Text qualityText;

    void Start() {
        // Set the slider to reflect the initial grinder setting
        grindSizeSlider.value = grinder.grindSize;
    }/* end Start */ //

    public void OnGrindSizeSliderChanged() {
        grinder.grindSize = grindSizeSlider.value;
    } /* end OnGrindSizeSliderChaned */ //

    void Update() {
        // Display current coffee quality
        qualityText.text = "Coffee Quality: " + SimManager.Instance.currentQuality.ToString("F2");
    }/* end Update */ //
    
}/* end Script */ ///

