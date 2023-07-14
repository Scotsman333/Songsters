using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Songsters", menuName = "Songsters/Create new Songster")]

public class SongsterData : ScriptableObject
{
    //Info
    [TextArea]
    public string songsterName, Species, Biography;


    //Anims and Sprites
    public Sprite baseSprite;

    //Stats
    public int HP, Attack, ChargeTime, ChargeCount;

    public SongstersGenre genre;

}

public enum SongstersGenre
{
    None,
    HipHop,
    Country,
    Punk,
    Metal,
    Electronic,
    Jazz
}