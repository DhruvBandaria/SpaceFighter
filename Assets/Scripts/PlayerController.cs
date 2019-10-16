using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public GameObject Laser;
    public float fireRate=0.2f;
    private float counter = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        /*counter += Time.deltaTime;
        if (Input.GetButton("Fire1") && counter>fireRate)
        {
            shootLaser();
            counter = 0f;
        }
        */
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shootLaser();
        }
    }
    // FixedUpdate is used when manipulating physics
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        // Debug.Log("Horizontal: " + horiz + " Vertical: " + vert);

        // Modify players velocity through the rigidbody2D
        Rigidbody2D rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(horiz * speed, vert * speed);
    }
    void shootLaser()
    {
        Instantiate(Laser, new Vector3(transform.position.x, transform.position.y, 0), Laser.transform.rotation);
    }
}