using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    private int max;
    private int min;
    private int guess;
    public int maxGuessesAllowed = 10;

    public Text Text;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        min = 1;
        max = 1001;
        NextGuess();
    }

    private void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        Text.text = guess.ToString();
        maxGuessesAllowed--;
        if (maxGuessesAllowed == 0)
        {
            StartGame();
            SceneManager.LoadScene("Win");
        }
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
}