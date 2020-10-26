using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class DebugText : MonoBehaviour
{
    static DebugText _instance = null;

    Text debugText = null;

    void Start() 
    {
        if (_instance != null) Destroy(this);
        else _instance = this;

        DontDestroyOnLoad(this.gameObject);

        debugText = GetComponent<Text>();
    }

    public static DebugText getInstance() 
    {
        return _instance;
    }

    public void Output(string toWrite) 
    {
        debugText.text = toWrite;

        CancelInvoke();
        Invoke("ClearText", 5f);
    }

    void ClearText() 
    {
        debugText.text = "";
    }
}
