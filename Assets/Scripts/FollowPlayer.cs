using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 1, -10);

    public AudioClip Music;
    public AudioSource MusicSource;

    private void Start()
    {
        MusicSource.clip = Music;
        MusicSource.Play();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
