using UnityEngine;
using UnityEngine.UIElements;

public class Collectibles : MonoBehaviour
{
    public VariableHolder variableHolder;
    public int ScoreValue = 1;
    public AudioClip collectSound;
    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        variableHolder = GameObject.Find("Canvas").GetComponent<VariableHolder>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Move();
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 50);
    }

    void Move()
    {
        Vector3 pos = transform.position;
        float newY = Mathf.Sin(Time.time * 2f) * 0.005f + pos.y;
        transform.position = new Vector3(pos.x, newY, pos.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            variableHolder.score += ScoreValue;
            variableHolder.UpdateScore();
            Destroy(gameObject);
        }
    }
}
