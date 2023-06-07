using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public AudioClip sesEfektiTuglaKirilma;
    public AudioClip sesEfektiTuglaCarpma;
    public static int toplamTuglaSayisi;
    public Sprite[] tuglaSprite;
    private int maxCarpmaSayisi;
    private int carpmaSayisi;
    private Puan puanScripti;
    // Start is called before the first frame update
    void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length + 1;
        toplamTuglaSayisi++;
        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("top"))
        {
            puanScripti.PuanArttir();
            carpmaSayisi++;
            if(carpmaSayisi >= maxCarpmaSayisi)
            {
                toplamTuglaSayisi--;
                Debug.Log(toplamTuglaSayisi);
                if (toplamTuglaSayisi <= 0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().BirSonrakiSahne();
                }
                AudioSource.PlayClipAtPoint(sesEfektiTuglaKirilma, transform.position);
                Destroy(this.gameObject);
            }
            else
            {
                AudioSource.PlayClipAtPoint(sesEfektiTuglaCarpma, transform.position);
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1];
            }
        }
    }
}
