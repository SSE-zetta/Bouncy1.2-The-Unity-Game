using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float speed = 2;
    private Rigidbody rb;
    private Vector2 screenbound;
    public GameObject Score;
    public GameObject Ball;
    [SerializeField] private Transform collidercheck2;

    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Score");
        Ball = GameObject.Find("Ball");
        //rb = GetComponent<Rigidbody>();

        screenbound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Ball.GetComponent<Ball>().platformcounter);
        //if (Ball.GetComponent<Ball>().platformcounter > 30)
        //{
        speed = 2 + ((float)(Score.GetComponent<score>().scorepoint)) / 30.0f;
        //}
        GetComponent<Rigidbody>().velocity = new Vector3(-speed, 0, 0);
        Debug.Log(Physics.OverlapSphere(collidercheck2.position, 0.3f).Length);
        if (Physics.OverlapSphere(collidercheck2.position, 0.3f).Length == 2)
        {
            Ball.GetComponent<Ball>().life = Ball.GetComponent<Ball>().life + 1;
            Destroy(this.gameObject);
        }
        if (transform.position.x < screenbound.x * 2)
        {
            Destroy(this.gameObject);
        }
    }
}

