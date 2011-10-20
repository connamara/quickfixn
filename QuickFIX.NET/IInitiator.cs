using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    /// <summary>
    /// Public interface for initiator.
    /// The class AbstractInitiator contains a default base implementation.
    /// </summary>
    public interface IInitiator
    {
        bool IsStopped { get; }

        void Start();
        void Stop();
        void Stop(bool force);

        bool IsLoggedOn();
    }
}
