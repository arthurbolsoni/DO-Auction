using DO_Login.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DO_Login.Services;
using System.Threading.Tasks;
using DO_Login.Core;
using DO_Login.ViewModels;
using Bindery;

namespace DO_Login.Views
{
    public partial class AuctionView : ViewBase
    {
        public AuctionView()
        {
            InitializeComponent();
        }

        public override void OnNavigatedTo(object nav)
        {
            base.OnNavigatedTo(nav);
            PerformBinding();

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler((s, e) => { tbTime.Text = Program.Locator.AuctionViewModel.CurrentTimeServerString; });
            timer1.Start();
        }

        public override void PerformBinding()
        {
            AuctionViewModel viewModel = Program.Locator.AuctionViewModel;

            //BindingManager.For(this)
              //  .Bind(offerModelBindingSource, _ => _.DataSource)
                //.To(viewModel, vm => vm.api.offers)
                //.Setup(configuration => configuration.IsTwoWay = true)
                //.Setup(configuration => configuration.UpdateSourceTrigger = UpdateSourceType.OnPropertyChanged);

            //BindingManager.For(this)
              //  .Bind(userModelBindingSource, _ => _.DataSource)
              //  .To(viewModel, vm => vm.api.user)
               // .Setup(configuration => configuration.IsTwoWay = true)
               // .Setup(configuration => configuration.UpdateSourceTrigger = UpdateSourceType.OnPropertyChanged);

            //BindingManager.For(this).BindCommand(button1).To(viewModel, _ => _.AddBidCommand);


            var binder = Create.Binder(viewModel);

            //user
            binder.Control(tbSID).Property(c => c.Text).Bind(vm => vm.api.user.SID);
            binder.Control(tbCredits).Property(c => c.Text).Bind(vm => vm.api.user.credits);
            binder.Control(tbServer).Property(c => c.Text).Bind(vm => vm.api.user.server);

            //offers
            binder.Control(cbOffers).Property(c => c.DataSource).Bind(vm => vm.api.offers);
            binder.Control(cbOffers).Property(c => c.SelectedValue).Bind(vm => vm.SelectedItemOffer);
            binder.Control(lbHighest).Property(c => c.Text).Bind(vm => vm.SelectedItemOffer.highest);
            binder.Control(lbCurrentBid).Property(c => c.Text).Bind(vm => vm.SelectedItemOffer.currentBid);
            binder.Control(lbYouBid).Property(c => c.Text).Bind(vm => vm.SelectedItemOffer.youBid);

            //new bid
            binder.Control(tbNewBid).Property(c => c.Text).Set(vm => vm.NewBid);
            binder.Control(tbTimeBid).Property(c => c.Text).Set(vm => vm.Time);
            binder.Control(button1).OnClick(viewModel.AddBidCommand);

            //viewGrid
            binder.Control(gvBids).Property(c => c.Rows).Set(vm => vm.DataGridViewCollection);
            binder.Control(gvBids).Property(c => c.DataSource).Bind(vm => vm.BidDataSource);

            //time
            //binder.Control(tbTime).Property(c => c.Text).Bind(vm => vm.CurrentTimeServer);
        }
    }
}
