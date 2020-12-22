using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Performer : MonoBehaviour
{
    public IStrategy ContextStrategy;

    public void Context(IStrategy _strategy)
    {
        ContextStrategy = _strategy;
    }
    public void SetStrategy(int i)
    {
        if(i == 1)
        {
            Context(new MoveForward());
        }
        if(i == 2)
        {
            Context(new Rotate());
        }
        if(i == 3)
        {
            Context(new Emmit());
        }
    }

    private void Update()
    {
        ContextStrategy?.Perform(this.transform);
    }
}
