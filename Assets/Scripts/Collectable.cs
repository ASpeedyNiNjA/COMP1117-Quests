using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject); //This destroys the Collectable
            //Destroy(collision.gameObject); //This destroys the player, oops!
        }
    }
}
