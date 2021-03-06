﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace Covid19Radar.ViewModels
{
    public class LicenseAgreementPageViewModel : ViewModelBase
    {
        private string _url;

        public string Url
        {
            get { return _url; }
            set { SetProperty(ref _url, value); }
        }

        public LicenseAgreementPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = Resources.AppResources.TitleLicenseAgreement;
            Url = Resources.AppResources.UrlLicense;
        }
    }
}
