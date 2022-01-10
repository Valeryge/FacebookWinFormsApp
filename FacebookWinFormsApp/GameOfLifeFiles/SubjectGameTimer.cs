using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp.GameOfLifeFiles
{
    internal class SubjectGameTimer
    {
        private Timer m_Timer;
        private List<IGameTimerObserver> m_Observers = new List<IGameTimerObserver>();

        public SubjectGameTimer()
        {
            m_Timer = new System.Windows.Forms.Timer();
            m_Timer.Interval = 1000;
            m_Timer.Tick += Notify;
        }

        public void Attach(IGameTimerObserver i_Observer)
        {
            m_Observers.Add(i_Observer);
        }

        public void Detach(IGameTimerObserver i_Observer)
        {
            m_Observers.Remove(i_Observer);
        }

        private void Notify(object i_Sender, EventArgs i_E)
        {
            foreach (IGameTimerObserver observer in m_Observers)
            {
                observer.Update();
            }
        }

        public void Start()
        {
            m_Timer.Start();
        }

        public void Stop()
        {
            m_Timer.Stop();
        }
    }
}
