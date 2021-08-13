using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed = 5;
    public float Direction;
    public int scoreNum;
    public Text myscoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreNum = 0;
        myscoreText.text = "Score:" + scoreNum;
    }

    // Update is called once per frame
    void Update()
    {
        Direction = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(0,Direction*Speed);
        StartCoroutine(update_Score());
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }
    }
    private IEnumerator update_Score()
    {
        yield return new WaitForSeconds(1f);
        scoreNum++;
        myscoreText.text = "Score:" + scoreNum;
    }
}
