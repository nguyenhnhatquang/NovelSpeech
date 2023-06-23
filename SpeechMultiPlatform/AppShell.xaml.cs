﻿using SpeechMultiPlatform.Core.Views;

namespace SpeechMultiPlatform;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		
		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
	}
}
