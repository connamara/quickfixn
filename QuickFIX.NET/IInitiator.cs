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

        /// <summary>
        /// Start connecting to targets.
        /// </summary>
        void OnStart();

        /// <summary>
        /// Connect and poll for events.
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        bool OnPoll(double timeout);

        /// <summary>
        /// Stop a running initiator.
        /// </summary>
        void OnStop();

        /// <summary>
        /// Connect a session to its target.
        /// </summary>
        /// <param name="sessionID"></param>
        /// <param name="settings"></param>
        void DoConnect(SessionID sessionID, QuickFix.Dictionary settings);
    }
}
