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
	private int animatereturner = 0;
    public void Start()
    {
		aime = GetComponentInChildren<Animator>();
    }
    public void  Down()//work
    {
		aime.SetBool ("BP", true);
		aime.SetBool ("do2", false);
		aime.SetBool ("do3", false);
		aime.SetBool ("do1", true);
        hp1=hp1-1;
        hpText.text = hp1.ToString();
        work=work - 3;
		worktext.text = (work ).ToString("F1");
        hpy = hpy - 1;
		hpyText.text = (hpy ).ToString("F1");
        paper += (100 - hp1) / 100;
		papertext.text = (paper).ToString("F1");
		HPboost = 0;
    }
    public void Down2()//play
    {
		aime.SetBool ("BP", true);
		aime.SetBool ("do1", false);
		aime.SetBool ("do3", false);
		aime.SetBool ("do2", true);
        hp1 = hp1 -1;
		hpText.text = hp1.ToString("F1");
        work = work - 3;
		worktext.text = (work).ToString("F1");
        hpy = hpy + 0.5;
		hpyText.text = (hpy ).ToString("F1");
		HPboost = 0;
    }
    public void Down3()//eat
    {
		aime.SetBool ("BP", true);
		aime.SetBool ("do1", false);
		aime.SetBool ("do2", false);
		aime.SetBool ("do3", true);
        hp1 = hp1 - 0.5;
        hpText.text = hp1.ToString();
        work = work - 3;
        worktext.text = (work).ToString("F1");
        hpy = hpy + 0.1;
        hpyText.text = (hpy ).ToString("F1");
		HPboost = 0;
    } 
    public void Update()
    {
		if (hp1 <= 0) 
		{
			hpText.color = Color.red;
		} 
		else if (hp1 <= 50 && hp1 > 0) 
		{
			hpText.color = Color.yellow;
		}
		else
		{
			hpText.color = Color.black;
		}

		if (hpy <= 0)
		{
			hpyText.color = Color.red;
		} 
		else if(hpy>100)
		{
			hpyText.color = Color.green;
		}
		else
		{
			hpyText.color = Color.black;
		}
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
        day1.text = (time).ToString("F1");
		if ((int)time>tt)
        {
			HPboost++;
            work = work - 1;
			Lday=work/24;
			Ldaytext.text = (Lday).ToString("F1");
			worktext.text = (work).ToString("F1");
			animatereturner++;
			aime.SetInteger ("dov1", Random.Range (0, 2));
			aime.SetInteger ("dov3", Random.Range (0, 3));
			aime.SetInteger ("dov2", Random.Range (0, 3));
			if (animatereturner >= 10)
			{
				aime.SetBool ("BP",false);
				aime.SetBool ("do1", false);
				aime.SetBool ("do2", false);
				aime.SetBool ("do3", false);
				animatereturner = 0;
			}
			if (hp1 < 100) 
			{
				
				if (HPboost >5 && hp1<=97.9)
				{
					hp1 = hp1 + 3.1;
					aime.SetBool ("BP",false);
					aime.SetBool ("do1", false);
					aime.SetBool ("do2", false);
				    aime.SetBool ("do3", false);
				}
				else
				{
					hp1 = hp1 + 0.1;
				}
			}
            hpText.text = hp1.ToString("F1");
        }
        tt = (int)time;
    }
}
