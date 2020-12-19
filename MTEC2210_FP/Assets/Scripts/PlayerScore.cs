using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public static float Score = 0;
    
    private Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Add();
        //playerScore++;
    }

    void Add()
    {
        score.text = "Score: " + Score;
    }
 
}
