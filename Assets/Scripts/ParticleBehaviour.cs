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

    }

    // Update is called once per frame
    void Update()
    {
        // move particle
        transform.position += (Vector3)(velocity * speed * Time.deltaTime);

        // World-wrap particle
        Vector3 pos = transform.position;
        if (pos.x > WorldManager.maxX) pos.x = WorldManager.minX;
        if (pos.x < WorldManager.minX) pos.x = WorldManager.maxX;
        if (pos.y > WorldManager.maxY) pos.y = WorldManager.minY;
        if (pos.y < WorldManager.minY) pos.y = WorldManager.maxY;
        transform.position = pos;
    }
}
