using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatcherMovement : MonoBehaviour
{
    public float minZ;
    public float maxZ;
    public float speed = 0.5f;
	private Rigidbody rigidbodyComponent;

	private void Start()
	{
        rigidbodyComponent = GetComponent<Rigidbody>();
	}

    private void FixedUpdate()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        if ((horizontalInput < 0 && transform.position.z <= minZ) || (horizontalInput > 0 && transform.position.z >= maxZ))
            return;

        rigidbodyComponent.velocity = Vector3.forward * horizontalInput * speed;
    }
}
