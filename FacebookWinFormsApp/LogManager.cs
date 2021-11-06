using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{

    public class LogManager
    {
        private Dictionary<FaceBookAction.ActionType, List<FaceBookAction>> m_LogCollection;

        public Dictionary<FaceBookAction.ActionType, List<FaceBookAction>> logCollection
        {
            get => m_LogCollection;
            set => m_LogCollection = value;
        }

        public LogManager()
        {
            m_LogCollection = new Dictionary<FaceBookAction.ActionType, List<FaceBookAction>>();
            foreach (FaceBookAction.ActionType enumsValue in Enum.GetValues(typeof(FaceBookAction.ActionType)))
            {
                m_LogCollection.Add(enumsValue, new List<FaceBookAction>());
            }

         
        }
    }
}
