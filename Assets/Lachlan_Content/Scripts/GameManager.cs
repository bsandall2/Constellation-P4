using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [Tooltip("Stars UI")]
    public int currentStars;
    public Text starsText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddStars(int starsToAdd)
    {
        //Adds Stars to Total + UI
        currentStars += starsToAdd;
        starsText.text = "Stars: " + currentStars;
    }
}
