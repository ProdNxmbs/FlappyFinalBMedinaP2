using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditorInternal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {
    
    public static GameControl instance;
    public GameObject gameOverText;
<<<<<<< HEAD
    public Text scoreText;
    public bool gameOver = false;
    public float scrollspeed = -1.5f;

    private int score = 0;
=======
    public bool gameOver = false;
>>>>>>> c26187109d9dd3b6fd8acd5ed527c135ff50059b
    
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)  {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score:" + scoreText.ToString();
    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
