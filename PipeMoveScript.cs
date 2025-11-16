using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float pipeSpeed = 5f;
    public float deadZone = -45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position +(Vector3.left * pipeSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
