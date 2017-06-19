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
    public string end1,end2,end3,end4,end5,end6,end7,end8,end9;
	public Text hpText, hpyText,worktext,papertext,day1,Ldaytext;
    public Button b1,b2,b3;
	private int HPboost = 0;
    public Animator aime;

    public void Start()
    {
		aime = GetComponentInChildren<Animator>();
    }
    public void  Down()
    {
		aime.SetBool ("do2", false);
		aime.SetBool ("do3", false);
        hp1=hp1-1;
        hpText.text = hp1.ToString();
        work=work - 3;
        worktext.text = (work ).ToString();
        hpy = hpy - 1;
        hpyText.text = (hpy ).ToString();
        paper += (100 - hp1) / 100;
        papertext.text = (paper).ToString();
		aime.SetBool ("do1", true);
		aime.SetBool ("BP", true);
		aime.SetFloat ("do1v",Random.Range (-1f, 2f));
		HPboost = 0;
    }
    public void Down2()
    {
		aime.SetBool ("do1", false);
		aime.SetBool ("do3", false);
        hp1 = hp1 -1;
        hpText.text = hp1.ToString();
        work = work - 3;
        worktext.text = (work).ToString();
        hpy = hpy + 0.1;
        hpyText.text = (hpy ).ToString();
		aime.SetBool ("do2", true);
		aime.SetFloat ("do2v",Random.Range (-1f, 3f));
		HPboost = 0;
		aime.SetBool ("BP", true);
    }
    public void Down3()
    {
		aime.SetBool ("do1", false);
		aime.SetBool ("do2", false);
        hp1 = hp1 - 0.1;
        hpText.text = hp1.ToString();
        work = work - 3;
        worktext.text = (work).ToString();
        hpy = hpy + 0.5;
        hpyText.text = (hpy ).ToString();
		HPboost = 0;
		aime.SetBool ("do3", true);
		aime.SetFloat ("do3v",Random.Range (-1f, 3f));
		aime.SetBool ("BP", true);
    } 
    public void Update()
    {

		if (hpy>=0 && hpy<=50 && paper<=50 &&work<=0)//GG END
        {
            SceneManager.LoadScene(end1);
        }
        if (paper >= 100 &&hpy>0)//Good ENd
        {
            SceneManager.LoadScene(end2);

        }
        if (hp1 > 0 && paper < 75 && hpy <= -75 && work <= 24)//Jump End
        {
            SceneManager.LoadScene(end3);

        }
		if (hp1 < 0 && paper > 75 && hpy <= -10 && work <=0)//Collapse End
        {
            SceneManager.LoadScene(end4);

        }
		if (paper >= 100 && hpy < 0 && work >= 0)//Old End
        {
            SceneManager.LoadScene(end5);

        }
        if (paper < 50 && hpy >= 100 && work <=0)//Faro End
        {
            SceneManager.LoadScene(end6);

        }
		if (paper >= 50 && hpy >= 100 && work > 10)//PhD End
		{
			SceneManager.LoadScene(end7);

		}
		if (paper < 50 && hpy <= -50 && work <= 240)//Quit End
		{
			SceneManager.LoadScene(end8);

		}
		if (paper >=100 && hpy <= -50 && work <=0)//NeverTouch End
		{
			SceneManager.LoadScene(end9);

		}
        time += Time.deltaTime;
        day1.text = (time).ToString();
		int animatereturner = 0;
		if ((int)time>tt)
        {
			HPboost++;
            work = work - 1;
			Lday=work/24;
			Ldaytext.text = (Lday).ToString();
            worktext.text = (work).ToString();
			if (hp1 < 100) 
			{
				animatereturner++;
				if (HPboost >5 && hp1<97.5)
				{
					hp1 = hp1 + 2.5;
					aime.SetBool ("BP",false);
					aime.SetBool ("do1", false);
					aime.SetBool ("do2", false);
				    aime.SetBool ("do3", false);
				}
				else
				{
					hp1 = hp1 + 0.1;
				}
				if (animatereturner >= 3)
				{
					aime.SetBool ("BP",false);
					aime.SetBool ("do1", false);
					aime.SetBool ("do2", false);
					aime.SetBool ("do3", false);
					animatereturner = 0;
				}
			}
            hpText.text = hp1.ToString();
        }
        tt = (int)time;
    }
}
