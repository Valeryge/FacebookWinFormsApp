using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
   public class DemoFullUserData
    {
        public DemoFullUserData(User i_FbUser)
        {
            Name = "(server)" + i_FbUser.Name;
            Email = "(server)" + i_FbUser.Email;
            BirthDay = "(server)" + i_FbUser.Birthday;
            SignificantOther = i_FbUser.SignificantOther != null ? "(server)" + i_FbUser.SignificantOther.Name : "(Default)Ashley";
            WorkPlace = i_FbUser.WorkExperiences[0] != null ? "(server)" + i_FbUser.WorkExperiences[0].Name : "(Default)Facebook inc.";
            HomeTown = i_FbUser.Hometown != null ? "(server)" + i_FbUser.Hometown.Name : "(Default)NewYork west";
            Education = i_FbUser.Educations[0] != null ? "(server)" + i_FbUser.Educations[0].ToString() : "(Default)Harvard";
        }

        public string Name { get;  }
        public string Email { get;  }
        public string BirthDay { get;  }
        public string SignificantOther { get; }
        public string WorkPlace { get;  }
        public string HomeTown { get; }
        public string Education { get; }
    }
}
