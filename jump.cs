using UnityEngine;
using UnityEngine.UI;

public class jump : MonoBehaviour
{
    public float jmpSpeed = 5;
    public Rigidbody2D rb;
    public bool isGameOver;
    public float score;
    public GameObject retryButton;
    public GameObject quitButton;
    public GameObject gameoverButton;
    public GameObject scoreEnd;
    public Text scoreEndText;
    public GameObject scorePlay;
    public Text scorePlayText;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            if(!isGameOver)
            {
                rb.velocity = Vector2.up * jmpSpeed;
            }
        }
        scorePlayText.text = "" + score + "";
        scoreEndText.text = "Your Score: " + score;

        if(rb.transform.position.y > 5)
        {
            isGameOver = true;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("point"))
        {
            if(!isGameOver)
            {
                score++;
            }
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("pipe"))
        {
            isGameOver = true;
        }

        if (collision.gameObject.CompareTag("ground"))
        {
            gameoverButton.SetActive(true);
            retryButton.SetActive(true);
            quitButton.SetActive(true);
            scoreEnd.SetActive(true);
            scorePlay.SetActive(false);
        }
    }
}

