using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class CoffeeBean : MonoBehaviour {
    
    public string beanName;
    public string origin;
    public float roastLevel;   // 0 = light roast, 100 = dark roast
    public string flavorNotes;

    public float GetBaseQuality() {
        // Light roasts might have higher “complexity,” dark roasts might have more “body” etc.
        float baseQuality = 50f + (roastLevel - 50f) * 0.5f;
        return Mathf.Clamp(baseQuality, 0f, 100f);
    } /* end GetBaseQualityt */ ///
    
}/* end Script */ ////*/
                  ///
                  ///
                  /// using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeBean : MonoBehaviour {

    [Header("Bean Details")]
    public string beanName;
    public string origin;

    [Header("Roast Information")]
    [Range(0, 100)]
    public float roastLevel;   // 0 = light roast, 100 = dark roast
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

    public void FinishGrinding() {
        // Mark grinding as finished
        isGrinding = false;
        SimManager.Instance.isGrinding = false;

        // Calculate penalties
        float baseQuality = selectedBean.GetBaseQuality();
        float timePenalty = CalculateTimePenalty(currentGrindTimer, grindTimePenalty);
        float grindSizePenalty = CalculateGrindSizePenalty(idealGrindSize, grindSize);

        // Compute final grind quality
        float finalGrindQuality = CalculateFinalGrindQuality(baseQuality, timePenalty, grindSizePenalty);

        // Update the game manager's coffee quality
        SimManager.Instance.ModifyCoffeeQuality(finalGrindQuality);

        // Log the details
        LogGrindingDetails(timePenalty, grindSizePenalty, finalGrindQuality);
    }

    private float CalculateTimePenalty(float grindTimer, float penaltyMultiplier) {
        return grindTimer * penaltyMultiplier;
    }

    private float CalculateGrindSizePenalty(float idealSize, float actualSize) {
        return Mathf.Abs(idealSize - actualSize);
    }

    private float CalculateFinalGrindQuality(float baseQuality, float timePenalty, float grindSizePenalty) {
        return baseQuality - (timePenalty + grindSizePenalty);
    }

    private void LogGrindingDetails(float timePenalty, float grindSizePenalty, float finalQuality) {
        Debug.Log($"Finished Grinding: Time penalty {timePenalty}, Grind penalty {grindSizePenalty}, Final: {finalQuality}");
    }

}/* end Script */ ///

