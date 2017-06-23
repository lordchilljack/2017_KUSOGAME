using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class SaveLoad{
	public static List<GameMemory> savedGames = new List<GameMemory>();

	public static void Save(){
		savedGames.Add (GameMemory.current);
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.60d");
		bf.Serialize (file, SaveLoad.savedGames);
		file.Close ();
	}

	public static void Load(){
		if (File.Exists (Application.persistentDataPath +"/savedGames.60d")) 
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/savedGames.60d", FileMode.Open);
			SaveLoad.savedGames=(List<GameMemory>)bf.Deserialize(file);
			file.Close();
		}
	}
}
