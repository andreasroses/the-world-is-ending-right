using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public List<PieceItemQuantifier> piecesOwned = new();

    void Start(){
        DontDestroyOnLoad(this);
    }
}
