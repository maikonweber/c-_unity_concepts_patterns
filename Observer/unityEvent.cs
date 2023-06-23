using UnityEngine;
using UnityEngine.Events;


public class GameManager: MonoBehaviour
{
    public UnityEvent onGameStart;
    void Start() {
        onGameStart.Invoke();
    }

}