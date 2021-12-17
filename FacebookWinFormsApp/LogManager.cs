using System;
using System.Collections.Generic;
using System.Linq;

namespace FacebookApp
{
    public sealed class LogManager
    {
        private Dictionary<FaceBookAction.eActionType, List<FaceBookAction>> m_LogCollection;
        private List<FaceBookAction> k_ActionsList;
        public List<FaceBookAction> ActionsList => k_ActionsList;
        private static readonly object objectLock = new object();

        private LogManager() 
        {
            m_LogCollection = new Dictionary<FaceBookAction.eActionType, List<FaceBookAction>>();
            k_ActionsList = new List<FaceBookAction>();
            foreach (FaceBookAction.eActionType enumsValue in Enum.GetValues(typeof(FaceBookAction.eActionType)))
            {
                m_LogCollection.Add(enumsValue, new List<FaceBookAction>());
            }
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

        public int GetActivityCountByType(FaceBookAction.eActionType i_EActionType)
        {
            return k_ActionsList.Where(action => action.Type == i_EActionType).Count();
        }
    }
}
