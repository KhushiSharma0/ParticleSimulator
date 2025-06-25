// ParticleClass.cs (ScriptableObject)
using UnityEngine;

[CreateAssetMenu(fileName = "NewParticleClass", menuName = "Particle/ParticleClass")]
public class ParticleClass : ScriptableObject
{
    public Color color = Color.white;
    public float speed = 1f;
    // Later: public float mass, charge, etc.
}