using DKDLLActivity;
using UnityEngine;

public class PluginTester : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerMove player = FindFirstObjectByType<PlayerMove>();
        player.speed = SpeedChanger.Instance.Execute(player.speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
