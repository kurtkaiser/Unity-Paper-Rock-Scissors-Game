using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    GameObject enemy;
    SpriteRenderer playerSprite;
    SpriteRenderer enemySprite;

    public Text winText;
    public Text loseText;
    public Sprite[] options;
    public static System.Random rnd = new System.Random();
    int winCount = 0;
    int loseCount = 0;
    int pIndex;
    int eIndex;

    private void OnMouseDown()
    {
        pIndex = rnd.Next(0, 3);
        playerSprite.sprite = options[pIndex];
        eIndex = rnd.Next(0, 3);
        enemySprite.sprite = options[eIndex];
        // Check for who won
        if(pIndex != eIndex)
        {
            if(pIndex == 0 && eIndex == 2)
            {
                winCount++;
            }
            else if (pIndex == 1 && eIndex == 0)
            {
                winCount++;
            }
            else if (pIndex == 2 && eIndex == 1)
            {
                winCount++;
            }
            else
            {
                loseCount++;
            }
        }
        winText.text = winCount.ToString();
        loseText.text = loseCount.ToString();
    }

    private void Awake()
    {
        enemy = GameObject.Find("Enemy");
        enemySprite = enemy.GetComponent<SpriteRenderer>();
        playerSprite = GetComponent<SpriteRenderer>();
    }
}
