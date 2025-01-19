using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeBean : MonoBehaviour {
    
    public string beanName;
    public string origin;
    public float roastLevel;   // 0 = light roast, 100 = dark roast
    public string flavorNotes;

    public float GetBaseQuality() {
        // Light roasts might have higher “complexity,” dark roasts might have more “body” etc.
        float baseQuality = 50f + (roastLevel - 50f) * 0.5f;
        return Mathf.Clamp(baseQuality, 0f, 100f);
    } /* end GetBaseQualityt */ ///
    
}/* end Script */ ////
