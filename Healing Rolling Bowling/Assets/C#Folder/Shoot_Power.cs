using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shoot_Power : MonoBehaviour
{

    private float power;
    private float power_add = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        power = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            {
            power += power_add + Time.deltaTime;
            Debug.Log(power);
            }
        if (Input.GetMouseButtonUp(0))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, power));
            power = 0.0f;
        }
        if (this.transform.position.y < -5.0f || Input.GetMouseButton(1))
        {
            SceneManager.LoadScene(0);
        }
    }
}
