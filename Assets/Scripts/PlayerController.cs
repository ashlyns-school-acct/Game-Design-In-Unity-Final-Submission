using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float GravityModifier;

    public Rigidbody rb;
    public Animator anim;
    public VariableHolder variableHolder;

    public bool IsGrounded = true;
    public bool IsClimbing = false;

    public AudioClip jumpSound;
    public AudioClip pitFall;
    public AudioSource playerAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        Physics.gravity *= GravityModifier;
        playerAudio = GetComponent<AudioSource>();
        variableHolder = GameObject.Find("Canvas").GetComponent<VariableHolder>();
    }

    void LateUpdate()
    {
        Move();
        Jump();
        Climb();

        animate();
    }

    private void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.forward * Mathf.Abs(horizontalInput) * Time.deltaTime * moveSpeed);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            IsGrounded = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void Climb()
    {
        if (Input.GetKey(KeyCode.UpArrow) && IsClimbing)
        {
            rb.AddForce(Vector3.up * jumpForce * 4 * Time.deltaTime, ForceMode.Impulse);
        }
    }

    private void animate()
    {
        anim.SetFloat("Speed_f", Mathf.Abs(horizontalInput));
        if (horizontalInput  > 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        } else if (horizontalInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("Ladder"))
        {
            IsGrounded = true;
            IsClimbing = true;
        }

         if (other.gameObject.CompareTag("Pit"))
        {
            transform.position = new Vector3(3, 0.5f, 2.5f);
            playerAudio.PlayOneShot(pitFall, 1.0f);
        }

        if (other.gameObject.CompareTag("Flag"))
        {
            variableHolder.Win();
        }
    }

    private void OnTriggerExit(Collider other)
    {
         if (other.gameObject.CompareTag("Ladder"))
        {
            IsClimbing = false;
        }
    }
}
