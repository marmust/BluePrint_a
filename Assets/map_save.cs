using System;
using System.IO;
using UnityEngine.Windows;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public static class map_saver
{

    public static void SavePlayer(Player player)
    {

        BinaryFormatter bf = new BinaryFormatter();
        var createdir = Directory.CreateDirectory(Application.persistentDataPath + "/saves");
        String dir = Application.persistentDataPath + "/saves";
        PlayerData data = new PlayerData(player);

        DirectoryInfo dir_i = new DirectoryInfo(dir);
        FileInfo[] info = dir_i.GetFiles("*.wyrm");
        foreach (FileInfo f in info)
        {
            Debug.Log(f);
        }

        FileStream stream = new FileStream(dir + "/player" + (info.Length + 1) + ".wyrm", FileMode.Create);

        bf.Serialize(stream, data);
        stream.Close();
    }

    public static float[] LoadPlayer()
    {

        String dir = Application.persistentDataPath + "/saves";

        DirectoryInfo dir_i = new DirectoryInfo(dir);
        FileInfo[] info = dir_i.GetFiles("*.save");
        foreach (FileInfo f in info)
        {
            Debug.Log(f);
        }

        if (info.Length >= 1)
        {

            BinaryFormatter bf = new BinaryFormatter();
            var createdir = Directory.CreateDirectory(Application.persistentDataPath + "/saves");
            FileStream stream = new FileStream(dir + "/player" + (info.Length) + ".save", FileMode.Open);
            PlayerData data = bf.Deserialize(stream) as PlayerData;

            stream.Close();
            return data.stats;
        }
        else
        {
            return null;
        }
    }
}

[Serializable] //serializable means it is able to be saved
public class PlayerData
{

    public float[] stats;

    public PlayerData(Player player)
    {
        stats = new float[5]; //create an empty array and use it to store values
        stats[0] = player.Level; //you can change these into whatever you want to save, but it must be either a float or int.
        stats[1] = player.Experience;
        stats[2] = player.transform.position.x;
        stats[3] = player.transform.position.y;
        stats[4] = player.transform.position.z;
    }
}
