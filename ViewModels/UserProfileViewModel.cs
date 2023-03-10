using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMvcApp.ViewModels
{
    public class UserProfileViewModel
    {
        public string EmailAddress { get; set; }

        public string Name { get; set; }

        public string ProfileImage { get; set; }

        public string AccessToken { get; set; }

        public Boolean IsAuthenticated { get; set; }
    }
}
