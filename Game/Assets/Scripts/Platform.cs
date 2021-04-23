using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private float speed = 2;
    private Vector2 screenbound;
    public GameObject Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Score");
        screenbound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {

        speed = 2 + ((float)(Score.GetComponent<score>().scorepoint)) / 30.0f;

        GetComponent<Rigidbody>().velocity = new Vector3(-speed, 0, 0);
        if (transform.position.x < screenbound.x*2)
        {
            Destroy(this.gameObject);
        }
    }
}
