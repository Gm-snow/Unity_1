using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPoint : MonoBehaviour
{

    public Text text;

    public int pincnt;

    private AudioSource audioSource = null;
    public AudioClip PinSound = null;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        pincnt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag.Equals("Kegel"))
        {


            pincnt++;
            if (pincnt < 11)
            {
                if (audioSource != null && PinSound != null)
                {
                    audioSource.PlayOneShot(PinSound);
                }Destroy(other.gameObject);

                text.text = pincnt + " Nice Work !";
            }
            else if (pincnt >= 10)
            {
                text.text = "You WIn !";
            }
        }
    }
}
