using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 5f; // Set a default or your own value
    public LogicScript logic;
    public bool birdisAlive = true;

    void Start()
    {
        // Get rigidbody and assign logic reference
        myRigidbody = GetComponent<Rigidbody2D>();
        GameObject logicObj = GameObject.FindGameObjectWithTag("Logic");
        if (logicObj != null)
        {
            logic = logicObj.GetComponent<LogicScript>();
        }
        else
        {
            Debug.LogError("Logic GameObject not found. Make sure it exists and is tagged 'Logic'!");
        }
    }

    void Update()
    {
        // Only allow jumping while alive
        if (birdisAlive && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Only trigger once
        if (birdisAlive)
        {
            birdisAlive = false;
            // Optionally freeze the bird
            myRigidbody.linearVelocity = Vector2.zero;
            myRigidbody.simulated = false;

            if (logic != null)
            {
                logic.gameOver();
            }
            else
            {
                Debug.LogError("LogicScript reference is null — gameOver() not called!");
            }
        }
    }
}

