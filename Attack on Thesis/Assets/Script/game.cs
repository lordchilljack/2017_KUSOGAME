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
    public string end,end2,end3,end4,end5,end6,end7,end8;
	public Text hpText, hpyText,worktext,papertext,day1,Ldaytext;
    public Button b1,b2,b3;
	private int HPboost = 0;
    public Animator aime;
	public string ED1, ED2, ED3, ED4, ED5, ED6, ED7;

    public void Start()
    {
		aime = GetComponentInChildren<Animator>();
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
		float v1 = Random.Range (0, 1);
		aime.SetFloat ("do1v",v1);
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
		float v2 = Random.Range (0, 2);
		aime.SetTrigger("do2");
		aime.SetFloat ("do2v",v2);
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
		float v3 = Random.Range (0, 2);
		aime.SetFloat ("do3v",v3);
		aime.SetBool ("BP", true);
    } 
    public void Update()
    {

        if (hp1<=-25&&paper<=100)
        {
            SceneManager.LoadScene(end);

        }
        if (hp1 > 0 && paper >= 100 &&hpy>0 && work>0)
        {
            SceneManager.LoadScene(end2);

        }
        if (hp1 > 0 && paper < 100 && hpy <= 0 && work > 50)
        {
            SceneManager.LoadScene(end3);

        }
        if (hp1 > 0 && paper < 100 && hpy <= 10 && work <= 50)
        {
            SceneManager.LoadScene(end4);

        }
        if (hp1 > 0 && paper >= 100 && hpy < 50 && work > 0)
        {
            SceneManager.LoadScene(end5);

        }
        if (hp1 > 0 && paper < 50 && hpy <= -10 && work > 10)
        {
            SceneManager.LoadScene(end8);

        }
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
