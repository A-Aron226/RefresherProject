using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    private Vector2 input;
    Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] Animator anim; //referencing player animation
    [SerializeField] float jumpStrength;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //communicates to a rigidbody component from an object (such as the capsule with the rigidbody component)
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        anim.SetFloat("moveSpeed", Mathf.Abs(input.magnitude)); //Setting the parameter 'moveSpeed' to input
    }

    private void FixedUpdate() // udpates based on physics //Code lines if you want to mess with physics
    {
        var newInput = GetCameraInput(input, Camera.main);

        var newVelocity = new Vector3(newInput.x * speed * Time.fixedDeltaTime, rb.velocity.y, newInput.z * speed * Time.fixedDeltaTime);// temp velocity
        rb.velocity = newVelocity;
    }

    Vector3 GetCameraInput(Vector2 input, Camera cam)
    {
        Vector3 camRight = cam.transform.right;
        camRight.y = 0;
        camRight.Normalize();

        Vector3 camForward = cam.transform.forward;
        camForward.y = 0;
        camForward.Normalize();

        return input.x * camRight + input.y * camForward; //multiplying input by camera vector
    }

    public void OnJump()
    {
        Debug.Log("Jump");
        rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
    }
}
