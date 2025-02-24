using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseManager: MonoBehaviour
{
    // 2
    protected string _state = "Manager is not initialized...";
    public abstract string State { get; set; }
    // 3
    public abstract void Initialize();
}
public class CombatManager : BaseManager
{

    public override string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public override void Initialize()
    {
        _state = "Combat Manager initialized..";
        Debug.Log(_state);
    }
}
