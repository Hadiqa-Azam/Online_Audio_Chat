using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayer : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public float MinX, MaxX, MinY, MaxY;
    private void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY));
        PhotonNetwork.Instantiate(PlayerPrefab.name, randomPosition, Quaternion.identity);
    }
}
