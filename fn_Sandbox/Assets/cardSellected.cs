using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cardSellected : MonoBehaviour
{

    public GameObject g; 
    public string cardSelected = "";

    private GameContrller gameController;

    void Start()
    {
        gameController=g.GetComponent<GameContrller>();
    }

    // Update is called once per frame
    void Update()
    {
        Text t = transform.GetComponentInChildren<Text>();
        cardSelected = t.text;
    }
    void OnMouseDown()
    {
        gameController.AddToTitle(cardSelected);
    }
}
