using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization

	public float moveSpeed;
	public float jumpForce;
	private Rigidbody2D myRigidbody;
	public bool grounded;
	public LayerMask whatIsGround;
	private Collider2D myCollider;

	private Animator myAnimator;



	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
		myCollider= GetComponent<Collider2D>();
		myAnimator = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {
		
		//checking whether layers touching eachother\ needs 2 params
		grounded = Physics2D.IsTouchingLayers(myCollider,whatIsGround);

		//always move forward by forcing rigidbody
		myRigidbody.velocity = new Vector2(moveSpeed,myRigidbody.velocity.y);
		myAnimator.SetFloat("Speed",myRigidbody.velocity.x);				 
		myAnimator.SetBool("Grounded",grounded);
		

		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
				Debug.Log("Ali ben burdayu sen nerdesin ??");		
			//If players touch ground grands a jump skill once ....
				if(grounded){
					
					myRigidbody.velocity = new Vector2(myRigidbody.velocity.x,jumpForce);

		}
		//Controlling our animator params from here script..
	

		}
	
	}
}
