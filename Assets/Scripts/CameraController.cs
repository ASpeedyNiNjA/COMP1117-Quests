using UnityEngine;

public class CameraController : MonoBehaviour
{
    //offset
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;



    //Vector3 cameraStartPos = new Vector3(0f, 0f, -10f);
    //public PlayerController player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + new Vector3(0, 0, -10);       
        //Debug.Log(cameraStartPos);
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(-20f, 10f, -10f) ,ref velocity, smoothTime);
    }

    //player.transform.position + new Vector3(0, 0, -10)
}
