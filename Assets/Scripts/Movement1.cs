using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    private CharacterController player;
    private Rigidbody rb;
    private float playerSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.AddComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        player.Move(move * Time.deltaTime * playerSpeed);
    }
}
