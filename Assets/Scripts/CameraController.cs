using UnityEngine;

public class CameraController : MonoBehaviour
{

    private float smoothTime = 2;
    private Vector3 velocity = new Vector3 (0, 0, 2);
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
        //transform.position = Vector3.SmoothDamp(cameraStartPos, new Vector3(-10, 0, -10) ,ref velocity, smoothTime);
        Debug.Log(cameraStartPos);
    }

    //player.transform.position + new Vector3(0, 0, -10)
}
