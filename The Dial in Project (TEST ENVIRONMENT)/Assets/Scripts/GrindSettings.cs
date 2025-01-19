using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrindSettings : MonoBehaviour {
    [Header("References")]
    public CoffeeBean selectedBean;
    
    [Header("Grind Settings")]
    public float grindSize = 50f;     // 0 = coarse, 100 = fine
    public float grindTime = 2.0f;    // how many seconds to grind
    
    [Header("Resulting Quality Impact")]
    public float grindTimePenalty = 0.5f;
    public float idealGrindSize = 55f; // sweet spot

    private float currentGrindTimer;
    private bool isGrinding;

    void Update() {
        if (isGrinding)
        {
            currentGrindTimer += Time.deltaTime;
            if (currentGrindTimer >= grindTime)
            {
                FinishGrinding();
            }
        }
    }/* end Update */ //

    public void StartGrinding(CoffeeBean bean) {
        if (isGrinding) return;
        
        selectedBean = bean;
        isGrinding = true;
        currentGrindTimer = 0f;
        
        // Indicate that the game is grinding
        SimManager.Instance.isGrinding = true;
    } /* end StartGrinding */ //

    void FinishGrinding() {
        isGrinding = false;
        SimManager.Instance.isGrinding = false;
        
        float baseQuality = selectedBean.GetBaseQuality();
        float timePenalty = currentGrindTimer * grindTimePenalty; // more time => bigger penalty
        float grindSizePenalty = Mathf.Abs(idealGrindSize - grindSize);
        
        float finalGrindQuality = baseQuality - (timePenalty + grindSizePenalty);
        
        // Update the game manager's coffee quality
        SimManager.Instance.ModifyCoffeeQuality(finalGrindQuality);
        
        Debug.Log($"Finished Grinding: Time penalty {timePenalty}, Grind penalty {grindSizePenalty}, Final: {finalGrindQuality}");
    }/* end FinishGrinding */ //
    
}/* end Script */ ///
