using UnityEngine;

public class ParticleBehaviour : MonoBehaviour
{
    // Movement Variables
    public Vector2 velocity;
    public float speed = 1f;


    // World-wrapping
    public float minX, maxX, minY, maxY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera cam = Camera.main;

        // z = distance from camera to particle plane
        float zDistance = -cam.transform.position.z;

        Vector3 bottomLeft = cam.ScreenToWorldPoint(new Vector3(0, 0, zDistance));
        Vector3 topRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, zDistance));

        minX = bottomLeft.x;
        minY = bottomLeft.y;

        maxX = topRight.x;
        maxY = topRight.y;
    }

    // Update is called once per frame
    void Update()
    {
        // move particle
        transform.position += (Vector3)(velocity * speed * Time.deltaTime);

        // World-wrap particle
        Vector3 pos = transform.position;
        if (pos.x > maxX) pos.x = minX;
        if (pos.x < minX) pos.x = maxX;
        if (pos.y > maxY) pos.y = minY;
        if (pos.y < minY) pos.y = maxY;
        transform.position = pos;
    }
}
