using UnityEngine;

public abstract class BaseLaw : ScriptableObject
{
    [Header("Law Settings")]
    public string lawName = "Unnamed Law";

    [Tooltip("Toggle this law on/off globally.")]
    public bool isEnabled = true;

    // Core method: compute force between two particles
    public abstract Vector3 ComputeForce(GameObject a, GameObject b);
}
