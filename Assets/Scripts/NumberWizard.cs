using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int maxGuess = 1000;
    [SerializeField] int minGuess = 1;
    [SerializeField] TextMeshProUGUI guessText;
    int guess = 500;// prety much global variable in c#

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
        //int maxGuess;
        //maxGuess = 1000;
        //      int minGuess;
        //    minGuess = 1;
        //  int guess = 500;*  ------you can do this locally in c# but not in the global class of number wizard. 
        //there they must be declared and initialized in one go./ 
    }
    void StartGame()// void means nothing to return
    {
        
        
        guess = (maxGuess + minGuess) / 2;// your making it so at the start the initial guess is 500
        
        
    }

    public void OnPressHigher()
    {
        minGuess = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxGuess = guess - 1;
        NextGuess();
    }



    // start is only ran once at the beginning of the game, good for getting this set up
    // Update is called once per frame
    /*void Update()// anything used in every frame  the player is playing so like 60fps it would update 60 times in a second
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))// if i were to have done multiple if only statements they wouldve repeated at the same time
        {
            minGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxGuess = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I told you My Program could guess your number right");
            maxGuess = 1000;
            minGuess = 1;
            guess = 500;
                StartGame();
        }
        
    }*/
    void NextGuess()
    {
        guess = Random.Range(minGuess,maxGuess +1);
        
        guessText.text = guess.ToString();
        
    }
}
