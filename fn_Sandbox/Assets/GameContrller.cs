using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameContrller : MonoBehaviour {



    public Text Title;
    public Text body;
    public string  url;

    public List<string> noun;
    public List<string> subjectMatter;

    public List<GameObject> choices;

    public List<string>Response;

    public int responseIndex;

    public int round;
    int count = 0;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        this.round = 0;
        this.responseIndex = 0;
    }
    // Use this for initialization
  
    
    public void AddToTitle(string title)
    {
        if (round == 0)
            Title.text = "";
        Title.text += title;

        round++;

        url = "www.nobullshitnews.com/articles/"+Title.text;

        if (round == 2)
            body.text = "";
    }
	
	// Update is called once per frame
	void Update () {

        if (round == 0)
        {
            for (int i = 0; i < choices.Count; i++)
            {
                choices[i].GetComponentInChildren<Text>().text = noun[i];
            }

        }
        else if (round == 1)
        {
            for (int i = 0; i < choices.Count; i++)
            {
                choices[i].GetComponentInChildren<Text>().text = subjectMatter[i];
                choices[i].GetComponentInChildren<Text>().fontSize = 12;
            }
        }
        else
        {
            GameObject g2 = GameObject.Find("newsFeed");
            if (g2 == null)
            {
                if (round < 100)
                    body.text += "blah ";
                round++;
            }
        }

        GameObject g= GameObject.Find("newsFeed");


        if (g != null && count==0)
        {
            g.GetComponent<Text>().text = "Trump: \n \t People in the media are awful people, especially those at no bullshit news. sad. \n 49k <3 \n\n"+g.GetComponent<Text>().text;
            count++;
        }

        g = GameObject.Find("Followers");
        if(g!=null)
        {
            g.GetComponent<Text>().text = "followers: " + 100 + count;
            count++;
        }

    }

}
