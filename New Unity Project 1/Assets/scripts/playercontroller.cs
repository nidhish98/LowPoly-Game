using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour {

	public float speed;
	public Text wintext;
	public Text countText;
	public Rigidbody rb;
	private int count;
	void Start()
	{
		count = 0;
		setCounttext ();
		wintext.text = "";
	
	}
	void FixedUpdate () 
	{
		
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal,0.0f, moveVertical);
		rb.AddForce(movement * speed * Time.deltaTime);
	}
		void OnTriggerEnter(Collider other)
		{


			if(other.gameObject.tag == "pickup")
			{
			other.gameObject.SetActive(false);
			if (other.gameObject.name == "pickup(1)") {
				count+=10;
			} else if (other.gameObject.name == "pickup(2)") {
				count+=20;
			} else if (other.gameObject.name == "pickup(3)") {
				count+=30;
			}
			else	if(other.gameObject.name == "pickup(4)")
				count+=40;
			else	if(other.gameObject.name == "pickup(5)")
				count+=50;
			else	if(other.gameObject.name == "pickup(6)")
				count+=60;
			else	if(other.gameObject.name == "pickup(7)")
				count+=70;
			else	if(other.gameObject.name == "pickup(8)")
				count+=80;
			else if(other.gameObject.name == "pickup(9)")
				count+=90;
			else if(other.gameObject.name == "pickup(10)")
				count+=100;
			else if(other.gameObject.name == "pickup(11)")
				count+=110;
			else if(other.gameObject.name == "pickup")
				count+=120;
			setCounttext(); 
			}
	
		}	

	void OnCollisionEnter(Collision othi)
	{
		if (othi.gameObject.tag == "walls") {

			wintext.text = "game over!";
			Application.Quit();
		}
	}
	void setCounttext()
	{
		countText.text = count.ToString ();
		if (count==780)
		{
			wintext.text = "you won!";
			Application.Quit();
		}

	}
}