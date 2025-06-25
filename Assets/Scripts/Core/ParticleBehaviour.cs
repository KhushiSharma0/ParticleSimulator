using UnityEngine;

public class ParticleBehaviour : MonoBehaviour
{
    // Movement Variables
    public Vector2 velocity;
    public float speed = 1f;

    // Assign Class info to particle
    public void AssignClass(ParticleClass particleClass)
    {
        Color colorToUse = particleClass != null ? particleClass.color : Color.magenta;
        GetComponent<SpriteRenderer>().color = colorToUse;
        speed = particleClass != null ? particleClass.speed : 1f;
    }



    // Dynamic Behaviour
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
