using UnityEngine;

public class CameraFollow1 : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void FixedUpdate()
    {
        transform.position = target.position+offset;
    }
    
}
