using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DialogsExemplo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnToast.Clicked += (sender, e) => {

                UserDialogs.Instance.Toast("Toast!! Eu entendia HELP no Mortal Kombat", TimeSpan.FromSeconds(10));
            };

            btnLoading.Clicked += async (sender, e) => {

                using (var Dialog = UserDialogs.Instance.Loading("Uma hora acaba..", null, null, true, MaskType.Black))
                {
                    await Task.Delay(3000);
                }
            };

            btnActionSheet.Clicked +=  (sender, e) => {

                var ActionSheetConfig = new ActionSheetConfig()
                    .SetTitle("Este Artigo Foi")
                    .SetUseBottomSheet(true);

                ActionSheetConfig.Add("Mais ou menos");
                ActionSheetConfig.Add("Bom");
                ActionSheetConfig.Add("Otimo");
                ActionSheetConfig.Add("Darth Vader Vestido de Batman Montado em um Charizard");


                UserDialogs.Instance.ActionSheet(ActionSheetConfig);
            };
        }
	}
}
