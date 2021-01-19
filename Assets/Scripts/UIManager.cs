using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject UI_VRMenuGameObject;
    public GameObject Location1;
    public GameObject Location2;
    public GameObject Location3;

    // Start is called before the first frame update
    void Start()
    {
        UI_VRMenuGameObject.SetActive(false);
    }

    public void OnStartButtonClicked()
    {
        print("Location1 button");
        Player.transform.position = Location1.transform.position;
        Player.transform.rotation = Location1.transform.rotation;
    }
    public void OnSettingButtonClicked()
    {
        print("Location2 button");
        Player.transform.position = Location2.transform.position;
        Player.transform.rotation = Location2.transform.rotation;

    }
    public void OnExitButtonClicked()
    {
        print("Location3 button");
        Player.transform.position = Location3.transform.position;
        Player.transform.rotation = Location3.transform.rotation;
    }
}
