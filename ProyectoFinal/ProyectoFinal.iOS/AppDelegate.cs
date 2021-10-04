﻿using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoFinal.Constants;
using Foundation;
using Google.Maps;
using Prism;
using Prism.Ioc;
using UIKit;

namespace ProyectoFinal.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            Xamarin.FormsGoogleMaps.Init(AppContanst.GoogleMapsApiKey);

            LoadApplication(new App(new IOSInitializer()));
            return base.FinishedLaunching(app, options);
        }
        public class IOSInitializer : IPlatformInitializer
        {
            public void RegisterTypes(IContainerRegistry container)
            { }
        }
    }
}
