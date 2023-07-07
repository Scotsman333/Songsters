using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveSongsterScript : MonoBehaviour
{
    public GameManager gameManager;
    public SongsterData allySongster, enemySongster;

    public Image allySprite, enemySprite;
    public Text allyName, enemyName;
    public Text allyGenre, enemyGenre;


    // Start is called before the first frame update
    void Start()
    {
        SetupAllySongster();
        SetupEnemySongster();


    }

    public void SetupAllySongster()
    {
        allySongster = gameManager.activeAllySongster;

        allySprite.sprite = allySongster.baseSprite;
        allyName.text = allySongster.songsterName;
        allyGenre.text = allySongster.genre.ToString();
    }

    public void SetupEnemySongster()
    {
        enemySongster = gameManager.activeEnemySongster;

        enemySprite.sprite = enemySongster.baseSprite;
        enemyName.text = enemySongster.songsterName;
        enemyGenre.text = enemySongster.genre.ToString();
    }



    void GetSongsterGenre()
    {
        switch(allyGenre)
        {
        }
    }



}
