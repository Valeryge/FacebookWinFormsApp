using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{

    public class LogManager
    {
        private Dictionary<FaceBookAction.ActionType, List<FaceBookAction>> m_LogCollection;
        private List<FaceBookAction> k_ActionsList;

        public List<FaceBookAction> ActionsList
        {
            get => k_ActionsList;
            set => k_ActionsList = value;
        }

        public Dictionary<FaceBookAction.ActionType, List<FaceBookAction>> logCollection
        {
            get => m_LogCollection;
            set => m_LogCollection = value;
        }

        public LogManager()
        {
            m_LogCollection = new Dictionary<FaceBookAction.ActionType, List<FaceBookAction>>();
            k_ActionsList = new List<FaceBookAction>();
            foreach (FaceBookAction.ActionType enumsValue in Enum.GetValues(typeof(FaceBookAction.ActionType)))
            {
                m_LogCollection.Add(enumsValue, new List<FaceBookAction>());
            }

            //var sortedDict = from entry in m_LogCollection orderby entry.Value ascending select entry;
        }

        public int GetActivityCountByType(FaceBookAction.ActionType i_ActionType)
        {
            return k_ActionsList.Where(action => action.Type == i_ActionType).Count();
        }
    }
}
