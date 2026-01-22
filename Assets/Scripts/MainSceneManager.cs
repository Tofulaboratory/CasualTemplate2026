using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    private MainGameStateHandler _mainGameStateHandler;
    void Start()
    {
        _mainGameStateHandler = new MainGameStateHandler();
        _mainGameStateHandler.Initialize();
        _mainGameStateHandler.ChangeState(MainGameState.Init);

    }

    void OnDestroy()
    {
        _mainGameStateHandler.Dispose();
    }
}
