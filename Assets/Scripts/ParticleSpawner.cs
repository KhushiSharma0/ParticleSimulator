using NUnit.Framework.Internal.Execution;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public Transform particleParent;
    public GameObject particlePrefab;
    public int numberOfParticles = 100;

    void Start()
    {
        for (int i = 0; i < numberOfParticles; i++)
        {
            Vector3 spawnPos = new Vector3(
                Random.Range(WorldManager.minX, WorldManager.maxX),
                Random.Range(WorldManager.minY, WorldManager.maxY),
                0f
            );

            GameObject particle = Instantiate(particlePrefab, spawnPos, Quaternion.identity, particleParent);

            // Random Velocity
            ParticleBehaviour behaviour = particle.GetComponent<ParticleBehaviour>();
            behaviour.velocity = Random.insideUnitCircle.normalized;
        }
    }

    void Update()
    {
        
    }
}
