﻿using Android.App;
using Android.Runtime;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using RandomMelodyGenerator.Core;
using System;

namespace RandomMelodyGenerator.Droid
{
    [Application]
    public class MainApplication: MvxAndroidApplication<MvxAndroidSetup<App>, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer):
            base(javaReference, transfer)
        {
        }
    }
}