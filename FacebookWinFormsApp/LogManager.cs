using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;


namespace FacebookApp
{
    public sealed class LogManager: IEnumerable<FaceBookAction>
    {
      //  private Dictionary<FaceBookAction.eActionType, List<FaceBookAction>> m_LogCollection;
        private List<FaceBookAction> k_ActionsList;
        public List<FaceBookAction> ActionsList => k_ActionsList;
        private static readonly object objectLock = new object();
        public Func<FaceBookAction, bool> FilterByActionTypes { get; set; }

        private LogManager() 
        {
       //     m_LogCollection = new Dictionary<FaceBookAction.eActionType, List<FaceBookAction>>();
            k_ActionsList = new List<FaceBookAction>();
            FilterByActionTypes = (action) => true;
 
        }
        
        private static LogManager instance = null;
        public static LogManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (objectLock)
                        {
                            if (instance == null)
                            {
                                instance = new LogManager();
                            }
                        }
                }
                return instance;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<FaceBookAction> GetEnumerator()
        {
            foreach (FaceBookAction action in ActionsList)
            {
                if (FilterByActionTypes.Invoke(action))
                {
                    yield return action;
                }
            }
        }

        public int GetActivityCountByType(FaceBookAction.eActionType i_EActionType)
        {
            return k_ActionsList.Where(action => action.Type == i_EActionType).Count();
        }
    }
}
