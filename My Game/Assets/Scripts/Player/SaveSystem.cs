using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(Playermovement playermovement, Health health)
    {
       BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/PlayerDataSave.save";
        FileStream stream =new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(playermovement, health);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/PlayerDataSave.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save Flie not found in" + path);
            return null;
        }
    }

}
