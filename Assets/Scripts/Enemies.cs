using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed = 3f;
    public float RightMax;
    public float leftMax;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.x > RightMax)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if (transform.position.x < leftMax)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }

}
