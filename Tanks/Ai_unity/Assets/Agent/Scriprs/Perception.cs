using UnityEngine;

public class Perception : MonoBehaviour
{
    public string tagName;
    public float maxDistance;
    public float maxAngle;

    public abstract GameObject[] getObject;
}
