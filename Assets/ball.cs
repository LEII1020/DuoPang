using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isRight = rb.transform.position.x > 0;
        float xVelo = -1f;
        float yVelo = UnityEngine.Random.Range(-1,1);
        if(isRight){
            xVelo = 1f;
        }
        rb.linearVelocity = new Vector2(xVelo * startSpeed, yVelo * startSpeed);
        print("I am" + rb.gameObject.name + ", and isRight = " + isRight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
