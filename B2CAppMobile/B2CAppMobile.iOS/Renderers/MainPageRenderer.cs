
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using Microsoft.Identity.Client;

using B2CAppMobile;
using B2CAppMobile.iOS;


[assembly: ExportRenderer(typeof(MainPage), typeof(MainPageRenderer))]
namespace B2CAppMobile.iOS
{
    public class MainPageRenderer : PageRenderer
    {
        private MainPage _page;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            _page = e.NewElement as MainPage;           
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _page.PlatformParameters = new PlatformParameters(this);
        }
    }
}
