using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour {
    public float speed;
    public float Score;
    public string VerticalAxis;
    
	// Use this for initialization
	void Start () {
        speed = 5.0f;
		
	}

    private void FixedUpdate()
    {
        float y = Input.GetAxisRaw(VerticalAxis); // - + deger verme vertical yataylik. alfa beta cok onemli degil.


        GetComponent<Rigidbody2D>().velocity = new Vector2(0, y) * speed;
    }
}
