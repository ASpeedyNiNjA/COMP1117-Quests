using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 0, -10);
    private CameraStats stats;
    private float smoothTime;
    private Vector3 velocity = Vector3.zero;
    public GameObject player;
    


    //Vector3 cameraStartPos = new Vector3(0f, 0f, -10f);
    //public PlayerController player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        stats = new CameraStats();
        smoothTime = stats.FloatSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + new Vector3(0, 0, -10);       
        //Debug.Log(transform.position);
        Vector3 targetPosition = player.transform.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition,ref velocity, smoothTime);
    }

    //player.transform.position + new Vector3(0, 0, -10)
}
