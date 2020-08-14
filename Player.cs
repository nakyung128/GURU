using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            jumpCount = 0;
        }

        if (collision.gameObject.tag.CompareTo("Block") == 0)
        {
            DataManager.Instance.playTimeCurrent -= 2f;
        }
    }
}
