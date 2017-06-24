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
		SaveLoad.Load ();
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
		if (hp1 <= -10) 
		{
			paper+= ((hp1-100)/100);
		} 
		else
		{
			paper += ((100-hp1)/100);
		}
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
		ColorCtrl ();
		Ending (hp1, hpy, work, paper);
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
			if (hp1 < 100 && aime.GetBool("BP")==false) 
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
	void ColorCtrl()
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
	}

	void Ending(double HP, double HPY, double Lhour, double Complete)
	{
		if (Lhour <= 0)
		{//時間到結局
			if (Complete >= 100)
			{
				if (HPY >= 100 && HP >= 0) 
				{
					
					GameMemory.current.ENDINGS.EDF =true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end2);//彩色畢業END-F
				} 
				else if ( HPY > -50) 
				{
					GameMemory.current.ENDINGS.EDA = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end5);//老人畢業END-A
				} 
				else
				{
					GameMemory.current.ENDINGS.EDH = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end9);//蜘蛛網畢業END-H
				}
			}
			else if (Complete >= 50 && Complete < 100) 
			{
				if (HPY >= 50)
				{
					GameMemory.current.ENDINGS.EDI = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end7);//簽下去END-I
				}
				else if (HPY > 0 && HPY < 50)
				{
					GameMemory.current.ENDINGS.EDA = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end5);//老人畢業END-A
				} 
				else 
				{ //快樂負值
					GameMemory.current.ENDINGS.EDC = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end4);//崩潰 END-C
				}
			} 
			else 
			{
				//論文進度小於50
				if (HPY >= 100) 
				{
					GameMemory.current.ENDINGS.EDB = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end6);//法老王END-B
				} 
				else if (HPY > 0 && HPY < 50)
				{
					GameMemory.current.ENDINGS.EDG = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end1);//GG END-G
				} 
				else
				{
					GameMemory.current.ENDINGS.EDC = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end4);//崩潰 END-C
				}
			}
		} 
		else if (Lhour <= 240 && HPY <= -50) 
		{
			GameMemory.current.ENDINGS.EDD = true;
			SaveLoad.Save ();
			SceneManager.LoadScene (end8);//休學END-D
		} 
		else if (Lhour <= 24 && HPY <= -50)
		{
			GameMemory.current.ENDINGS.EDE = true;
			SaveLoad.Save ();
			SceneManager.LoadScene (end3);//跳樓END-E
		}
		else
		{//無視時間觸發類型
			if (Complete >= 100)
			{
				if (HPY >= 100 && HP >= 0) 
				{
					GameMemory.current.ENDINGS.EDF = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end2);//彩色畢業END-F
				} 
				else if (HPY > -50) 
				{
					GameMemory.current.ENDINGS.EDA = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end5);//老人畢業END-A
				} 
				else 
				{
					GameMemory.current.ENDINGS.EDH = true;
					SaveLoad.Save ();
					SceneManager.LoadScene (end9);//蜘蛛網畢業END-H
				}	
			}
			if (HP <= -75) 
			{
				if (HPY <= -50) 
				{
					if (Complete >= 50) {
						GameMemory.current.ENDINGS.EDD = true;
						SaveLoad.Save ();
						SceneManager.LoadScene (end8);//休學END-D
					}
					else {
						GameMemory.current.ENDINGS.EDE = true;
						SaveLoad.Save();
						SceneManager.LoadScene (end3);//跳樓END-E
					}
				}

			}
		}
	}
}