using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class game : MonoBehaviour {
    public double hp1 = 100;
    public double hpy = 100;
    public double work = 1440;
    public double paper = 0;
    public float time = 0;
    public int tt;

    public Text hpText, hpyText,worktext,papertext,day1;
    public Button b1,b2,b3;
    Animator aime;
    public void Start()
    {
        aime = GetComponent<Animator>();

    }
    public void  Down()
    {
        hp1=hp1-1;
        hpText.text = hp1.ToString();
        work=work - 3;
        worktext.text = (work ).ToString();
        hpy = hpy - 0.1;
        hpyText.text = (hpy ).ToString();
        paper += (100 - hp1) / 100;
        papertext.text = (paper).ToString();
        aime.SetTrigger("do1");

    }
    public void Down2()
    {
        hp1 = hp1 -1;
        hpText.text = hp1.ToString();
        work = work - 3;
        worktext.text = (work).ToString();
        hpy = hpy + 0.1;
        hpyText.text = (hpy ).ToString();
    }

    public void Down3()
    {
        hp1 = hp1 - 0.1;
        hpText.text = hp1.ToString();
        work = work - 3;
        worktext.text = (work).ToString();
        hpy = hpy + 0.5;
        hpyText.text = (hpy ).ToString();
    }
    
    public void Update()
    {
        time += Time.deltaTime;
        day1.text = (time).ToString();
        
        if ((int)time>tt)
        {
            work = work - 1;
            worktext.text = (work).ToString();
            hp1 = hp1 + 1;
            hpText.text = hp1.ToString();
        }
        tt = (int)time;
    }
}
