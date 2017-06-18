using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour {
    public double hp1 = 100;
    public double hpy = 87;
    public double work = 1440;
    public double paper = 0;
    public float time = 0;
    public int tt;
	public double Lday=60;

	public Text hpText, hpyText,worktext,papertext,day1,Ldaytext;
    public Button b1,b2,b3;
	private int HPboost = 0;
    public Animator aime;
	public string ED1, ED2, ED3, ED4, ED5, ED6, ED7;

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
        hpy = hpy - 1;
        hpyText.text = (hpy ).ToString();
        paper += (100 - hp1) / 100;
        papertext.text = (paper).ToString();
        aime.SetTrigger("do1");
		aime.SetBool ("BP", true);
		HPboost = 0;
    }
    public void Down2()
    {
        hp1 = hp1 -1;
        hpText.text = hp1.ToString();
        work = work - 3;
        worktext.text = (work).ToString();
        hpy = hpy + 0.1;
        hpyText.text = (hpy ).ToString();
		aime.SetTrigger("do2");
		HPboost = 0;
		aime.SetBool ("BP", true);
    }
    public void Down3()
    {
        hp1 = hp1 - 0.1;
        hpText.text = hp1.ToString();
        work = work - 3;
        worktext.text = (work).ToString();
        hpy = hpy + 0.5;
        hpyText.text = (hpy ).ToString();
		HPboost = 0;
		aime.SetTrigger("do3");
		aime.SetBool ("BP", true);
    } 
    public void Update()
    {
        time += Time.deltaTime;
        day1.text = (time).ToString();
		if ((int)time>tt)
        {
			HPboost++;
            work = work - 1;
			Lday=work/24;
			Ldaytext.text = (Lday).ToString();
            worktext.text = (work).ToString();
			if (hp1 < 100) 
			{
				if (HPboost >5 && hp1<97.5)
				{
					
					hp1 = hp1 + 2.5;
					aime.SetBool ("BP",false);
				}
				else
				{
					hp1 = hp1 + 0.1;
				}
			}
            hpText.text = hp1.ToString();
        }
        tt = (int)time;
    }
}
