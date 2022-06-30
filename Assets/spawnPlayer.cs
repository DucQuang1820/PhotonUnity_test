using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class spawnPlayer : MonoBehaviour
{
    public GameObject playerPrefab;
    public TMP_Text PlayerName;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public void Awake()
    {
        PlayerName.text = PhotonNetwork.LocalPlayer.NickName;
    }
    private void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    }
}
