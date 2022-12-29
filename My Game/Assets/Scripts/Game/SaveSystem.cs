using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using Mono.Cecil.Cil;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public static class SaveSystem
{
    
    public static void SavePlayer(Playermovement playermovement, Health health)
    {
       BinaryFormatter formatter = new BinaryFormatter();
        string path = "Save.sav";//Path.Combine(Application.persistentDataPath,"/PlayerDataSave.save");//"C:/Users/Philipp/Documents/GitHub/Maturaarbeit/My Game/SAasdfasfdas.save";
        FileStream stream =new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        PlayerData data = new PlayerData(playermovement, health);

        formatter.Serialize(stream, data);
        stream.Close();


    }

    public static PlayerData LoadPlayer()
    {
        string path = "Save.sav";//Path.Combine(Application.persistentDataPath, "/PlayerDataSave.save");// "C:/Users/Philipp/Documents/GitHub/Maturaarbeit/My Game/SAasdfasfdas.save";
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
            return default;
        }
    }

}
