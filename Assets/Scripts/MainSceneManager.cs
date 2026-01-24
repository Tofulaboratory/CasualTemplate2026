using Cysharp.Threading.Tasks;
using UnityEngine;
using R3;

public class MainSceneManager : MonoBehaviour
{
    private MainGameStateHandler _mainGameStateHandler;
    void Start()
    {
        _mainGameStateHandler = new MainGameStateHandler();
        _mainGameStateHandler.Initialize();
        _mainGameStateHandler.MainGameState.Subscribe(state =>
        {
            switch (state)
            {
                case MainGameState.Init:
                    break;
                case MainGameState.Begin:
                    break;
                case MainGameState.End:
                    break;
            }
        }).AddTo(this);
        _mainGameStateHandler.ChangeState(MainGameState.Init);
    }

    void OnDestroy()
    {
        _mainGameStateHandler.Dispose();
    }
}
