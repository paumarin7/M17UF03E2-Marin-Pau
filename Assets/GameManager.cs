using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
   public Text coins;
    [SerializeField]
    public Text ganar;
    [SerializeField]
    public Text empezr;
    public int coin;

    [SerializeField]
    public GameObject posicion;
    public GameObject ball;

    public Image im;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = "Coins " + coin;
    }


    public void empezar()
    {
        ball.transform.position = posicion.transform.position;
        empezr.gameObject.SetActive(false);
        im.gameObject.SetActive(false);
        ganar.gameObject.SetActive(true);
    }
}
