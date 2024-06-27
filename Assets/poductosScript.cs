﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class poductosScript : MonoBehaviour
{
    public GameObject[] alimentos1;
    public GameObject[] alimentos2;

    public Text Txtprecio1;
    public Text Txtprecio2;

    int [] precios;

   

    




    // Start is called before the first frame update
    void Start()
    {
        precios = new int[13];

        //precioPera = 5
        precios[0] = 5;
        //precioCHamburguesa = 15
        precios[1] = 15;
        //precioSandia = 9
        precios[2] = 9;
        //precioHuevo = 3
        precios[3] = 3;
        //precioSushi = 12
        precios[4] = 12;
        //precioBotella = 16
        precios[5] = 16;
        //precioHamburguesa = 10
        precios[6] = 10;
        //precioSandwich = 11
        precios[7] = 11;
        //precioBanana = 4
        precios[8] = 4;
        //precioZanahoria = 6
        precios[9] = 6;
        //precioHongo = 8
        precios[10] = 8;
        //precioMedialuna = 13
        precios[11] = 13;
        //precioLimon = 7
        precios[12] = 7;
        //precioSalchicha = 14
        precios[13] = 14;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        int nroR = Random.Range(0, 13);
            Debug.Log(nroR);
            int precio1 = precios[nroR];
            Txtprecio1.text = precio1.ToString();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int nroR2 = Random.Range(0, 13);
            Debug.Log(nroR2);
            int precio2 = precios[nroR2];
            Txtprecio2.text = (precio2).ToString();
        }
    }
}
