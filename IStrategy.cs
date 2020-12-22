using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public interface IStrategy
    {
        void Perform(Transform transform);
    }


    public class MoveForward : IStrategy
    {
        public void Perform(Transform transform)
        {
            transform.Translate(0, 1 * Time.deltaTime, 0);
        }
    }

    public class Rotate : IStrategy
    {
        public void Perform(Transform transform)
        {
            transform.Rotate(0, 0, 30 * Time.deltaTime);
        }
    }

    public class Emmit : IStrategy
    {
        public void Perform(Transform transform)
        {
            transform.gameObject.GetComponent<ParticleSystem>().Emit(1);
        }
    }

