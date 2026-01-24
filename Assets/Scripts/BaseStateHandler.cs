using System;
using R3;

public abstract class BaseStateHandler<T> : IDisposable where T : Enum
{
    private ReactiveProperty<T> _state;
    public ReadOnlyReactiveProperty<T> State => _state;
    public virtual void Initialize()
    {
        _state = new ReactiveProperty<T>();
    }

    public virtual void ChangeState(T state)
    {
        _state.Value = state;
    }

    public virtual void Dispose()
    {
        _state.Dispose();
    }
}
