﻿using System.Collections.Generic;
using NGM.OpenAuthentication.Models;

namespace NGM.OpenAuthentication.ViewModels {
    public class VerifiedAccountsViewModel {

        public int UserId { get; set; }

        public IList<OpenAuthenticationPart> Accounts { get; set;}

    }
}