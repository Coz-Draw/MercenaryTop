using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSimple : MonoBehaviour
{
    public GameObject winText;
    public GameObject loseText;

    bool ended = false;

    void Start()
    {
        winText.SetActive(false);
        loseText.SetActive(false);
    }

    void Update()
    {
        if (ended)
        {
            if (Input.anyKeyDown)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            return;
        }

        // GANAR: si ya no hay monedas en la escena
        if (GameObject.FindGameObjectsWithTag("Coin").Length == 0)
        {
            winText.SetActive(true);
            Time.timeScale = 0f;
            ended = true;
        }
    }

    public void Lose()
    {
        loseText.SetActive(true);
        Time.timeScale = 0f;
        ended = true;
    }
}