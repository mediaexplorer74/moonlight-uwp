﻿//
// DirectXPage.xaml.h
// Declaration of the DirectXPage class.
//

#pragma once

#include "StreamPage.g.h"

#include "Common\DeviceResources.h"
#include "moonlight_xbox_dxMain.h"

namespace moonlight_xbox_dx
{
	/// <summary>
	/// A page that hosts a DirectX SwapChainPanel.
	/// </summary>
	public ref class StreamPage sealed
	{
	public:
		StreamPage();
		virtual ~StreamPage();
		void OnBackRequested(Platform::Object^ e, Windows::UI::Core::BackRequestedEventArgs^ args);

	private:
		// Track our independent input on a background worker thread.
		Windows::Foundation::IAsyncAction^ m_inputLoopWorker;
		Windows::UI::Core::CoreIndependentInputSource^ m_coreInput;

		// Resources used to render the DirectX content in the XAML page background.
		std::shared_ptr<DX::DeviceResources> m_deviceResources;
		std::unique_ptr<moonlight_xbox_dxMain> m_main; 
		bool m_windowVisible;
		void Page_Loaded(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
	};
}

