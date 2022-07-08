using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float turnSpeed;
    public float horInput;
    public float forwardInput;

    public GameObject healthPoints;
    public GameObject enemyPoints;

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.up * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.back * Time.deltaTime * turnSpeed * horInput);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            healthPoints.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("Health"))
        {
            Destroy(collision.gameObject);
            enemyPoints.SetActive(false);
        }
    }

}
