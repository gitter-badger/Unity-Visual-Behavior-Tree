﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts.AI.Nodes
{
    public abstract class BehaviorNode : BehaviorTreeElement
    {
        public BehaviorNode(string name, int depth, int id) : base(name, depth, id)
        {}

        public override IEnumerator Tick(WaitForSeconds delayStart = null)
        {
            base.Tick();
            yield return null;
        }
    }
}