using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float smoothTime;
    private Vector3 velocity = new Vector3 (2, 2, 2);
    Vector3 cameraStartPos;
    public PlayerController player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraStartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + new Vector3(0, 0, -10);
        transform.position = Vector3.SmoothDamp(cameraStartPos, new Vector3(-10, 0, -10) ,ref velocity, smoothTime);
    }

    //player.transform.position + new Vector3(0, 0, -10)
}
