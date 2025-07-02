using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log("xInput: " + xInput);
        float zInput = Input.GetAxis("Vertical");
        Debug.Log("zInput: " + zInput);

        float xspeed = xInput * speed;
        float zspeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xspeed, 0f, zspeed);
        playerRigidbody.linearVelocity = newVelocity;

        /*if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }*/
    }
}