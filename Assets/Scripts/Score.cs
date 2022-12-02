using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public TextMeshProUGUI scoreText;

    private int score;
    public AudioSource uwuSound, deadSound;
     
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

        if (score == 10)
        {
            SceneManager.LoadScene(1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomba")
        {
            deadSound.Play();
            StartCoroutine(Dead());
            Dead();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Fruit")
        {
            uwuSound.Play();
            Destroy(collision.gameObject);
            score++;
        }

    }

    IEnumerator Dead()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}