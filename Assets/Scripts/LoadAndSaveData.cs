//using UnityEngine;

//public class LoadAndSaveData : MonoBehaviour
//{
//    public static LoadAndSaveData instance;

//    private void Awake()
//    {
//        if(instance != null)
//        {
//            Debug.LogWarning("Il y'a plus d'une instance de LoadAndSaveData dans la scène");
//            return;
//        }

//        instance = this;
//    }


//    public void SaveData()
//    {
//        PlayerPrefs.SetInt("color", MouseControl.instance.color); 
//    }
//}