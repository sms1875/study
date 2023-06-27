using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    Collider2D col;
    private void Awake()
    {
        col = GetComponent<Collider2D>();
    }

    float size = 20;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area"))
            return;

        Vector3 playrPos = GameManager.instance.player.transform.position;
        Vector3 tilePos = transform.position;
        float diffX = Mathf.Abs(playrPos.x - tilePos.x);
        float diffY = Mathf.Abs(playrPos.y - tilePos.y);

        Vector3 playerDir = GameManager.instance.player.inputVec;
        float dirX = playerDir.x < 0 ? -1 : 1;
        float dirY = playerDir.y < 0 ? -1 : 1;

        switch (transform.tag)
        {
            case "Ground":
                if (diffX > diffY)
                    transform.Translate(Vector3.right * dirX * size * 2);
                else if (diffX < diffY)
                    transform.Translate(Vector3.up * dirY * size * 2);
                break;
            case "Enemy":
                if(col.enabled)
                    transform.Translate(playerDir * size + new Vector3(Random.Range(-3f,3f), Random.Range(-3f,3f),0f));
                break;
        }
    }
}
