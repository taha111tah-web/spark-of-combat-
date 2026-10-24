using UnityEngine;
using System;

public class CyberSecurityShield : MonoBehaviour
{
    void Awake()
    {
        // منع التجسس وتصوير الشاشة على أجهزة الأندرويد
        #if UNITY_ANDROID && !UNITY_EDITOR
        using (var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            var activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            var window = activity.Call<AndroidJavaObject>("getWindow");
            window.Call("addFlags", 8192); // FLAG_SECURE
        }
        #endif
    }
}
