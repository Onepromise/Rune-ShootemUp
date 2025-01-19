using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;
    public Vector3 Offset;
    private Vector3 Velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 targetPostion = target.position + Offset;

            transform.position = Vector3.SmoothDamp(transform.position, targetPostion, ref Velocity, smoothTime);
        }

    }
}
