using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem : MonoBehaviour
{
    #region METHODS
    public static void SavePlayer(Player player, Pet pet, GameObject petSprite, GameObject tileSprite,
                BuyItem conkeGO, BuyItem nanfaGO, BuyItem zeroGO, BuyItem prampGO,
                BuyItem mtpooGO, BuyItem bepisGO, BuyUpgrade troobleGO, BuyUpgrade parteyGO,
                BuyUpgrade patinatorGO)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/dataplayer.fun";
        FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

        Data playerData = new Data(player, pet, petSprite, tileSprite, conkeGO, nanfaGO, zeroGO, prampGO,
            mtpooGO, bepisGO, troobleGO, parteyGO, patinatorGO);

        formatter.Serialize(stream, playerData);
        stream.Close();
    }

    public static Data LoadPlayer()
    {
        string path = Application.persistentDataPath + "/dataplayer.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Data playerData = formatter.Deserialize(stream) as Data;
            stream.Close();

            return playerData;
        }
        else
        {
            Debug.Log("Save file not found in " + path);
            return null;
        }
    }
    #endregion
}
