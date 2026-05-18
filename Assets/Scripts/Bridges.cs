using UnityEngine;

public class Bridges : MonoBehaviour
{
    public BoxCollider BoxCollider;
    public bool isBridgeActive = false;

    void Start()
    {
        BoxCollider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) && isBridgeActive)
        {
            BoxCollider.enabled = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isBridgeActive = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isBridgeActive = false;
        }
    }
}
