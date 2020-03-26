using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events; 
using UnityEngine.EventSystems;

public class ScoreTextScript : MonoBehaviour
{
    
    public static int scoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        Color c = new Color(0.5f, 0.5f, 0.5f);
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
        score.text = "Score: " + scoreValue;
        
       
    }
}
