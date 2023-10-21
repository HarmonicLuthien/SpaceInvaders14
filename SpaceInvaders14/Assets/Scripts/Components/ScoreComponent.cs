using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreComponent : MonoBehaviour
{
    [SerializeField]
    private int scoreValue;
    [SerializeField]
    private GameObject leaderboardObject;
    // private LeaderboardLogic leaderboardLogic;

    // private void Awake()
    // {
    //     leaderboardObject = leaderboardObject.GetComponent<LeaderboardLogic>();
    // }

    // private void OnDisable()
    // {
    //     leaderboardLogic.AddScore(scoreValue);
    // }
}
