using UnityEngine;

public class Secrets : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            meshRenderer.enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                meshRenderer.enabled = true;
            }
    }
}
