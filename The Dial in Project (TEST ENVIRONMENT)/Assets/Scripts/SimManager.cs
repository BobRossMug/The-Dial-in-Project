using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimManager : MonoBehaviour {

    public static SimManager Instance; // Prev. GameManager

    [Header("Game States")]
    public bool isGrinding;
    public bool isBrewing;
    public bool resultsScreen;
    public bool settingsScreen;

    [Header("Coffee Types")] 
    
    public float coffeeType;
    public float roastConsistency;
    
    public float currentQuality = 0f;
    public float maxQuality = 100f;
    
    
    
    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }

        DontDestorNestedCall();
    } /* end Awake */ //

    //private void NewMethod_R2Test() {
    //    DontDestroyOnLoad(gameObject);
    //}
    
    private void DontDestorNestedCall() {
        DontDestroyOnLoad(gameObject);
    }
    
    void Start() {
        
        ResetGame();

    }/* end Start */ ////

    
    
    public void ResetGame() {
        isGrinding = false;
        isBrewing = false;
        currentQuality = 0f;
    } /* end ResetGame */ //
    
    public void ModifyCoffeeQuality(float amount) {
        //currentQuality += amount;
        //currentQuality = Mathf.Clamp(currentQuality, 0, maxQuality);
        Debug.Log("Coffee quality is now: " + currentQuality);
    }/* end ModifyCoffeQuality */ //
    
    
    
    
    void Update() {
        
    }/* end Update */ ////
                      
                      
} /* end Script */ /////
