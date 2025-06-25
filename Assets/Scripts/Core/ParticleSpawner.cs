using UnityEngine;
using System.Collections.Generic;


public class ParticleSpawner : MonoBehaviour
{
    public Transform particleParent; // Parent transform to organize hierarchy
    public GameObject particlePrefab; // Prefab to instantiate
    public List<ParticleClass> spawnableParticleClasses; // List of possible types (e.g., proton, electron)
    public int numberOfParticles = 100; // Total number to spawn


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

            // Assign random class
            ParticleClass chosenClass = spawnableParticleClasses[Random.Range(0, spawnableParticleClasses.Count)];

            // Give behaviour + assign class
            ParticleBehaviour behaviour = particle.GetComponent<ParticleBehaviour>();
            behaviour.velocity = Random.insideUnitCircle.normalized;
            behaviour.AssignClass(chosenClass);
        }
    }

    void Update()
    {
        
    }
}
