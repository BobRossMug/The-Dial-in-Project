using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspressoMachine : MonoBehaviour {
    
    [Header("Brew Settings")]
    public float brewTime = 5f;
    public float brewTimerPenalty = 0.4f;
    public float idealBrewTime = 4.5f;
    
    private float currentBrewTimer;
    private bool isBrewing;

    void Update() {
        if (isBrewing)
        {
            currentBrewTimer += Time.deltaTime;
            if (currentBrewTimer >= brewTime)
            {
                FinishBrewing();
            }
        }
    }

    public void StartBrewing() {
        if (isBrewing) return;
        isBrewing = true;
        currentBrewTimer = 0f;
        
        SimManager.Instance.isBrewing = true;
    } /* end StartBrewing */ //

    void FinishBrewing() {
        isBrewing = false;
        SimManager.Instance.isBrewing = false;
        
        float brewPenalty = Mathf.Abs(idealBrewTime - currentBrewTimer) * brewTimerPenalty;

        // Deduct from coffee quality
        SimManager.Instance.ModifyCoffeeQuality(-brewPenalty);
        Debug.Log($"Finished Brewing. Brew penalty: {brewPenalty}");
    }/* end FinishBrewing */ //
    
}/* end Script */ ///
