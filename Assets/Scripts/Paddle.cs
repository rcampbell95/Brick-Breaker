using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float mousePositionWorldUnits = Input.mousePosition.x / Screen.width * 16;

        Vector3 newPosition = new Vector3();

        newPosition.x = Mathf.Clamp(mousePositionWorldUnits, 0f, 15f);
        newPosition.y = this.transform.position.y;
        newPosition.z = this.transform.position.z;

        this.transform.position = newPosition;
	}
}
