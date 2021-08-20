using System;
using UnityEngine;

public class SteveController : MonoBehaviour
{
    public Rigidbody2D body;
    public Collider2D coll;
    public float jumpforce, speed, velocityReductionRate, startPlatformSize;
    private float horizontalMove;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        for(int x=(int)Math.Round(transform.position.x), p = 0;p < startPlatformSize;p++){
            x = x + (int)Math.Pow(-1,p) * p;
            ObjectCreator.CreateObject(new Vector3(x, transform.position.y-1, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))  Application.Quit();

        float direction = Input.GetAxisRaw("Horizontal");
        if(direction != 0)  horizontalMove = direction;
        else horizontalMove /= velocityReductionRate;
        body.velocity = new Vector2(horizontalMove*speed,body.velocity.y);

        if((Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButton(2))&&body.velocity.y==0)  body.velocity = new Vector2(body.velocity.x, jumpforce);
        if(transform.position.y<-20)  transform.position = new Vector3(1,4,transform.position.z);
    }
}
