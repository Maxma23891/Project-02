using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerGetCoin : MonoBehaviour
{
    float Score = 0;
    public TMP_Text ScoreText;
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Coins"))
        {
            Score++;
            ScoreText.text = Score.ToString("Score : " + Score);
            Destroy(other.gameObject, 0.1f);
        }
    }

}
