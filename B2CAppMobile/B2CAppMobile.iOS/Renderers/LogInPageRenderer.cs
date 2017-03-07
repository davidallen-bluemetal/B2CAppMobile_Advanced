
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using Microsoft.Identity.Client;

using B2CAppMobile;
using B2CAppMobile.iOS;

[assembly: ExportRenderer(typeof(LogInPage), typeof(LogInPageRenderer))]
namespace B2CAppMobile.iOS
{
    public class LogInPageRenderer : PageRenderer
    {
        private LogInPage _page;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            _page = e.NewElement as LogInPage;
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _page.PlatformParameters = new PlatformParameters(this);
        }


    }
}
