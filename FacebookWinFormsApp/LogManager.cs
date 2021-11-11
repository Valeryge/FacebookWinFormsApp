using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures
{

    public class LogManager
    {
        private Dictionary<FaceBookAction.eActionType, List<FaceBookAction>> m_LogCollection;
        private List<FaceBookAction> k_ActionsList;
        public List<FaceBookAction> ActionsList => k_ActionsList;

        public LogManager()
        {
            m_LogCollection = new Dictionary<FaceBookAction.eActionType, List<FaceBookAction>>();
            k_ActionsList = new List<FaceBookAction>();
            foreach (FaceBookAction.eActionType enumsValue in Enum.GetValues(typeof(FaceBookAction.eActionType)))
            {
                m_LogCollection.Add(enumsValue, new List<FaceBookAction>());
            }
        }

        public int GetActivityCountByType(FaceBookAction.eActionType i_EActionType)
        {
            return k_ActionsList.Where(action => action.Type == i_EActionType).Count();
        }
    }
}
