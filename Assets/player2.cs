using UnityEngine;

public class player2 : MonoBehaviour
{

    public GameObject player;
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressingUp = Input.GetKey(KeyCode.UpArrow);
        bool isPressingDown = Input.GetKey(KeyCode.DownArrow);
        if (isPressingUp){
            player.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
        if (isPressingDown){
            player.transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }
    }
}
