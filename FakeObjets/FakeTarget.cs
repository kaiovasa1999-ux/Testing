namespace Skeleton.Tests.FakeObjets
{
    using Skeleton.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class FakeTarget : ITarget
    {
        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
           return true;
        }

        public void TakeAttack(int atackPoints)
        {
            
        }
    }
}
