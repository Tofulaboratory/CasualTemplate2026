using System;
using R3;

public sealed class MainGameStateHandler : IDisposable
{
    private ReactiveProperty<MainGameState> _mainGameState;
    public ReadOnlyReactiveProperty<MainGameState> MainGameState => _mainGameState;

    public void Initialize()
    {
        _mainGameState = new ReactiveProperty<MainGameState>();
    }

    public void ChangeState(MainGameState state)
    {
        _mainGameState.Value = state;
    }

    public void Dispose()
    {
        _mainGameState.Dispose();
    }
}
