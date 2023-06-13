using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worrior : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpHigh;

    private Rigidbody2D rb;
    private bool isJump = false;

    GameObject hold = null;

    private void Awake() {
        hold = GameObject.Find("Hold");
        rb = hold.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Action(KeyCode.LeftArrow)
        
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("방향키 왼 꾹 누름");
            Move("L");
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("방향키 오 꾹 누름");
            Move("R");
        } 

        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            Debug.Log("점프 꾹 누름");
            Jump();
        } 
    }

    void Move(string directionKind) {
        Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
        if (directionKind == "L") {
            transform.position -= moveTo;
        } else if (directionKind == "R"){
            transform.position += moveTo;
        }
    }

    void Jump() {
        // Vector3 jumpTo = new Vector3(0f, jumpHigh * Time.deltaTime, 0f);
        // transform.position += jumpTo;
        if (!isJump) {
            isJump = true;
            rb.AddForce(Vector3.up * jumpHigh, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionStay2D(Collision2D other) {
        Debug.Log("hello");
        Debug.Log(other.gameObject.tag);
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(other.gameObject.tag);
        Debug.Log(other.gameObject.name + "hell");
        if(other.gameObject.CompareTag("mat")) {
            isJump = false;
        }
    }
}
