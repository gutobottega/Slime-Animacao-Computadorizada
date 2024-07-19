using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        //rotate the player on horizontal axis
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal * 2, 0);

        //move the player on vertical axis based on the rotation
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(0, 0, vertical);
        move = transform.rotation * move;

        controller.Move(move * Time.deltaTime * playerSpeed);
    }
}
