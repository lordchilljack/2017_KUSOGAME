using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class SaveLoad{
	public static GameMemory savedGame;

	public static void Save(){
		if (File.Exists (Application.persistentDataPath + "/savedGame.aot")) 
		{
			savedGame = GameMemory.current;
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/savedGame.aot",FileMode.Open);
			bf.Serialize (file, SaveLoad.savedGame);
			file.Close ();
		} 
		else
		{
			savedGame = GameMemory.current;
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Create (Application.persistentDataPath + "/savedGame.aot");
			bf.Serialize (file, SaveLoad.savedGame);
			file.Close ();
		}
	}

	public static void Load(){
		if (File.Exists (Application.persistentDataPath + "/savedGame.aot")) 
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/savedGame.aot", FileMode.Open);
			SaveLoad.savedGame = (GameMemory)bf.Deserialize (file);
			file.Close ();
		} 
		else
		{
			savedGame=GameMemory.current;
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Create (Application.persistentDataPath + "/savedGame.aot");
			bf.Serialize (file,SaveLoad.savedGame);
			file.Close ();
			file = File.Open (Application.persistentDataPath + "/savedGame.aot", FileMode.Open);
			SaveLoad.savedGame = (GameMemory)bf.Deserialize (file);
			file.Close ();
		}
	}
}
