using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;


    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;


    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            Command turnRight = new TurnRight(rb, sidewaysForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(turnRight);
            invoker.ExecuteCommand();
        }
        if (Input.GetKey("a"))
        {
            Command turnLeft = new TurnLeft(rb, sidewaysForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(turnLeft);
            invoker.ExecuteCommand();
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
