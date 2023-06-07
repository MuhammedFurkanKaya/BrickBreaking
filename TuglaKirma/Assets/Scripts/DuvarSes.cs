using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarSes : MonoBehaviour
{
    public AudioClip sesEfekti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(sesEfekti, transform.position);
    }
}
