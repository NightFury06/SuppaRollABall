using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {
    Vector3 resetPosition;
	Rigidbody rb;
	canvas_controller cc;
    void ReturnToCheckpoint()
    {
        this.transform.position = resetPosition;
        
        rb.Sleep();
        rb.WakeUp();
    }
	public float moveSpeed = 1000f;
    public GameObject CheckPointText;
	Vector3 offset; 
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		cc = GameObject.Find ("Canvas").GetComponent<canvas_controller> ();
		offset = Camera.main.transform.position - this.transform.position;
        resetPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//rb.AddForce(Vector3.forward * 100f);
		float hdir = Input.GetAxisRaw("Horizontal");
		float vdir = Input.GetAxisRaw("Vertical");

		Vector3 directionVector = new Vector3 (hdir, 0, vdir);
		Vector3 unitVector = directionVector.normalized;
		Vector3 forceVector = unitVector * moveSpeed * Time.deltaTime;
		rb.AddForce (forceVector);
		Camera.main.transform.position = this.transform.position + offset;
        if (this.transform.position.y < - 15f)
        {
            ReturnToCheckpoint();
            cc.LoseTries();
        }
	}

void OnTriggerEnter(Collider other)
{
        if (other.gameObject.tag == "CheckPoint")
        {
            if (resetPosition != other.transform.position)
            {
                resetPosition = other.transform.position;

                GameObject temporaryTextObject = (GameObject)Instantiate(CheckPointText);
                Destroy(temporaryTextObject, 1.5f);
            }
        }
        if (other.gameObject.tag == "Hazard")
        {
            //ReturnToCheckpoint();
            cc.LoseTries();
            //float TimeToWaitInSeconds = 5f;

            rb.AddForce(Vector3.up * 10000);
           //Invoke("MethodName", TimeToWaitInSeconds);
            Invoke("ReturnToCheckpoint", 1.5f);
        }
		if (other.gameObject.tag == "JUMPS PADS") 
		{
			rb.AddForce(Vector3.up * 1000);
		}
		if (other.gameObject.tag == "LOL PAD") 
		{
			rb.AddForce(Vector3.up * 500);
		}
		if (other.gameObject.tag == "SUPER JUMP") 
		{
			rb.AddForce(Vector3.up * 2000);
		}

		if (other.gameObject.tag == "finishing touch") 
		{
			SceneManager.LoadScene("menu");
		}

            if (other.gameObject.tag == "collectable")
                {
                    if (other.GetComponent<Controler>().isCollected == false)
                    {
                        other.GetComponent<Controler>().isCollected = true;
                        cc.IncreaseScore(50);
                    }

                }
            }
        
}
