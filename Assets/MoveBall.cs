using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {
    public float speed = 5.0f;

    MoveRacket LRacket;
    MoveRacket RRacket;

    public GameObject LR;
    public GameObject RR;

	// Use this for initialization
	void Start () {
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;
        LRacket = LR.GetComponent<MoveRacket>();
        RRacket = RR.GetComponent<MoveRacket>();
	}

    private void FixedUpdate()
    {

         
    }

    private void OnCollisionEnter2D(Collision2D other) //cok onemli.
    {
        if (other.gameObject.name == "RightWall")
        {
            LRacket.Score++;
        }
        if (other.gameObject.name == "LeftWall")
        {
            RRacket.Score++;
           
        }
        if(other.gameObject.name == "RightRacket")
        {
            float ySub = transform.position.y - other.gameObject.transform.position.y;
            float RacketHeight = other.collider.bounds.size.y;
            float y = ySub / RacketHeight;
            Vector2 direction = new Vector2(-1, y);

            GetComponent<Rigidbody2D>().velocity = direction * speed;

        }
        if (other.gameObject.name == "LeftRacket")
        {
           float ySub = transform.position.y - other.gameObject.transform.position.y;
           float RacketHeight = other.collider.bounds.size.y;
           float y = ySub / RacketHeight;
           Vector2 direction = new Vector2(1, y);

           GetComponent<Rigidbody2D>().velocity = direction * speed;


        }
    }

}
