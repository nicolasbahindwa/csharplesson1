using Asp.netDemoShared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Net;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AspIdentityDemoClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class register : Page
    {
        public register()
        {
            this.InitializeComponent();
        }

        private async void Submit_Click(object sender, RoutedEventArgs e)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (x, cert, chain, SslPolicyErrors) => { return true; };
            

            HttpClient client = new HttpClient(handler);

            var model = new RegisterViewModel
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                ConfirmPassword = txtConfirmPassword.Text
                
            };
            var jsonData = JsonConvert.SerializeObject(model);

            var contect = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://localhost:44332/api/auth/register", contect);

            var responseBody = await response.Content.ReadAsStringAsync();

            var ResponseObject = JsonConvert.DeserializeObject<UserManagerResponse>(responseBody);

            if (ResponseObject.IsSuccess)
            {
                var dialog = new MessageDialog("Your account have been created successfuly");
                await dialog.ShowAsync();
            }
            else
            {
                var dialog = new MessageDialog(ResponseObject.Errors.FirstOrDefault());
                await dialog.ShowAsync();

            }
        }
    }
}
