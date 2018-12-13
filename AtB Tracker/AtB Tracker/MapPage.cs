using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin;
using Xamarin.Forms.GoogleMaps;

namespace AtB_Tracker
{
	public class MapPage : ContentPage
{
        VMServiceClient vmService;

        public MapPage()
        {
            var map = new Map(){
                
                MapType = MapType.Street,
                MyLocationEnabled = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;

            vmService = new VMServiceClient();

            VehicleMonitoringDelivery[] answer = null;
            ExtensionsStructure answerExtension = null;
            BaseProducerResponse response = vmService.GetVehicleMonitoring(new ServiceRequestInfo(), new VehicleMonitoringRequest(), new ExtensionsStructure(), out answer, out answerExtension);
            System.Diagnostics.Debug.WriteLine(response.Address);
        }
    }
}