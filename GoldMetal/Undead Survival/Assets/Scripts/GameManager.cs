using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("# Game Control")]
    public float gameTime = 0f;
    public float MaxGameTime = 2 * 10f;
    [Header("# Player Info")]
    public int hp;
    public int maxHp = 100;
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

    private void Start()
    {
        hp = maxHp;
    }

    private void Update()
    {
        gameTime += Time.deltaTime;

        if (gameTime > MaxGameTime)
        {
            gameTime = MaxGameTime;
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
