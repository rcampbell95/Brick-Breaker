using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    private Paddle paddle;

    private Vector3 paddleToBallVector;

    private Rigidbody2D rigidbody;

    private bool hasStarted = false;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            // Lock the ball relative to the paddle
            this.transform.position = paddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                rigidbody = GetComponent<Rigidbody2D>();
                rigidbody.velocity = new Vector2(2f, 8f);

                hasStarted = true;
            }
        }
	}
}
