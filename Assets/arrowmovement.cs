using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowmovement : MonoBehaviour
{
    public int velocidadY;
    public float vertical;
    private Rigidbody2D movimiento;

    private void Awake()
    {
        movimiento = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento.velocity = new Vector2(velocidadY * vertical);
    }
}
