using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carreira : MonoBehaviour
{

    public Sprite[] modelos;

    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = modelos[Random.Range(0, modelos.GetLength(0))];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
