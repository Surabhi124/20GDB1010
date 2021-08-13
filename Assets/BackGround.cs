using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public BoxCollider2D bcollider;
    public Rigidbody2D rb;
    public float width;
    public float scrollSpeed = -1f;
    // Start is called before the first frame update
    void Start()
    {
        bcollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        width = bcollider.size.x;
        bcollider.enabled = false;
        rb.velocity = new Vector2(scrollSpeed,0);
        ResetObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -width)
        {
            Vector2 resetPos = new Vector2(width*2f,0);
            transform.position = (Vector2)transform.position + resetPos;
            ResetObstacle();
        }
    }
    private void ResetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(0, Random.Range(-3, 3), 0);
    }
    
}
