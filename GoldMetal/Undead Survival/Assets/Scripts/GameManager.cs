using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("# Game Control")]
    public float gameTimer = 0f;
    public float MaxGameTimer = 2 * 10f;
    [Header("# Player Info")]
    public int level;
    public int kill;
    public int exp;
    public int[] nextExp = {3, 4, 10, 100, 150, 210, 280, 360, 450, 600};
    [Header("# Game Object")]
    public PoolManager poolManager;
    public Player player;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        gameTimer += Time.deltaTime;

        if (gameTimer > MaxGameTimer)
        {
            gameTimer = MaxGameTimer;
        }
    }

    public void GetExp() 
    {
        exp++;
        if (exp >= nextExp[level])
        {
            level++;
            exp = 0;
        }
    }
}
