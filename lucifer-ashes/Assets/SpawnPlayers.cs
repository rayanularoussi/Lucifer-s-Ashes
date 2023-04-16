using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;
    public GameObject cameraPrefab;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    void Start()
    {
        
        // Spawn the player object across the network
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        
        // Spawn the camera object across the network
        PhotonNetwork.Instantiate(cameraPrefab.name, Vector3.zero, Quaternion.identity);
    }
}