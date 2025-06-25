using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public static float minX, maxX, minY, maxY;

    void Awake()
    {
        // World-wrapping
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
}
