using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CollegeTracker : MonoBehaviour {


	//Declaration of all ints of all colleges
	public static int berk = 0;
	public static int bran = 0;
	public static int dave = 0;
	public static int ezra = 0;
	public static int fran = 0;
	public static int hopp = 0;
	public static int jona = 0;
	public static int mors = 0;
	public static int paul = 0;
	public static int pier = 0;
	public static int sayb = 0;
	public static int sill = 0;
	public static int timo = 0;
	public static int trum = 0;

	//Functions that are applied to buttons that will increment the variables when clicked
	public void AddBerk()
	{
		berk += 1;
	}

	public void AddBran()
	{
		bran += 1;
	}

	public void AddDave()
	{
		dave += 1;
	}

	public void AddEzra()
	{
		ezra += 1;
	}

	public void AddFran()
	{
		fran += 1;
	}

	public void AddHopp()
	{
		hopp += 1;
	}

	public void AddJona()
	{
		jona += 1;
	}

	public void AddMors()
	{
		mors += 1;
	}

	public void AddPaul()
	{
		paul += 1;
	}

	public void AddPier()
	{
		pier += 1;
	}

	public void AddSayb()
	{
		sayb += 1;
	}

	public void AddSill()
	{
		sill += 1;
	}

	public void AddTimo()
	{
		timo += 1;
	}

	public void AddTrum()
	{
		trum += 1;
	}


	public void Compare()
	{
		//Creation of dictionary and addition of all aforementioned variables and their values
		Dictionary<string, int> result = new Dictionary<string, int> ();

		result.Add("Berkley", berk);
		result.Add("Branford", bran);
		result.Add("Davenport", dave);
		result.Add("Stiles", ezra);
		result.Add("Ben Franklin", fran);
		result.Add("Hopper", hopp);
		result.Add("JE", jona);
		result.Add("Morse", mors);
		result.Add("Pauli Murray", paul);
		result.Add("Pierson", pier);
		result.Add("Saybrook", sayb);
		result.Add("Silliman", sill);
		result.Add("TD", timo);
		result.Add("Trumbull", trum);

 		//Puts dictionary into a list that is ordered by descending order
		//https://stackoverflow.com/questions/10290838/how-to-get-max-value-from-dictionary
		List<string> collegeList = result.OrderByDescending(kp => kp.Value).Select(kp => kp.Key).ToList();

		//Prints first element of list in console
        Debug.Log(collegeList[0]);
    }
}
