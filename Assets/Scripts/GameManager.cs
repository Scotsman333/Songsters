using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool startPlaying;

    public AudioSource theMusic;
    public NoteScroller BS;
    public static GameManager instance;

    public float currentScore;
    public float scorePerNote = 100;

    public Text scoreText;
    public Text enemyScoreText;
    public Text multiText;
    public Slider scoreBar;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThreshholds;

    public int enemyDifficulty;
    public int enemyScore;

    public int bADIDEASONGLENGTH;
    public int bADIDEASONGCURRENT = 0;

    public SongsterData activeAllySongster;
    public SongsterData activeEnemySongster;


    void Start()
    {
        instance = this;
        scoreText.text = "Score: 0";

        currentMultiplier = 1;
        multiplierTracker = 0;
    }

    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                BS.hasStarted = true;

                theMusic.Play();
                Debug.Log("Start!");
            }
        }
    }

    public void NoteHit()
    {
        if(currentMultiplier - 1 < multiplierThreshholds.Length)
        {
            multiplierTracker++;

            if (multiplierThreshholds[currentMultiplier - 1] <= multiplierTracker)
            {
                currentMultiplier++;
                multiplierTracker = 0;
            }

            currentScore += (scorePerNote * currentMultiplier);

            scoreText.text = "Score: " + currentScore;
            multiText.text = "Combo! x" + currentMultiplier;

            ScoreBarUpdate();

        }

    }
    public void NoteMissed()
    {

        multiplierTracker = 0;
        currentMultiplier = 1;
        multiText.text = "Combo! x" + currentMultiplier;

        ScoreBarUpdate();
    }
    public void ScoreBarUpdate()
    {

        if(Random.Range(0, 100) <= enemyDifficulty)
        {
            enemyScore = enemyScore + 250;

        }

        enemyScoreText.text = "Score: " + enemyScore;


        scoreBar.value = currentScore / (currentScore + enemyScore);

        bADIDEASONGCURRENT++;

        if(bADIDEASONGCURRENT >= bADIDEASONGLENGTH)
        {
            if(currentScore >= enemyScore)
            {
                Debug.Log("WIN");
            }
            else
            {
                Debug.Log("LOSE");
            }

            SceneManager.LoadScene(1);


        }

    }



}
