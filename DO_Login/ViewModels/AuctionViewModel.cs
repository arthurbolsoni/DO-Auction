using DO_Login.Core;
using DO_Login.Models;
using DO_Login.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DO_Login.ViewModels
{
    public class AuctionViewModel : ViewModelBase
    {
        private TimeSpan _currentTimeServer;
        public TimeSpan CurrentTimeServer { get => _currentTimeServer; set { _currentTimeServer = value; RaisePropertyChanged();
                CurrentTimeServerString = _currentTimeServer.ToString(); } }

        private String _currentTimeServerString;
        public String CurrentTimeServerString { get => _currentTimeServerString; set { _currentTimeServerString = value; RaisePropertyChanged(); } }

        //NEW BID
        private String _newBid;
        public String NewBid { get => _newBid; set { _newBid = value; RaisePropertyChanged(); } }

        private String _time;
        public String Time { get => _time; set { _time = value; RaisePropertyChanged(); } }

        //SELECTED OFFER
        private OfferModel _SelectedItemOffer;
        public OfferModel SelectedItemOffer
        {
            get => _SelectedItemOffer;
            set
            {
                _SelectedItemOffer = value;
                RaisePropertyChanged();
            }
        }

        //GRID VIEW ROWS
        private DataGridViewRowCollection _DataGridViewCollection;
        public DataGridViewRowCollection DataGridViewCollection
        {
            get { return _DataGridViewCollection; }
            set
            {
                _DataGridViewCollection = value;
                RaisePropertyChanged();
            }
        }

        //YOU BIDS
        private BindingList<BidModel> _bids = new BindingList<BidModel>();
        public BindingList<BidModel> Bids
        {
            get => _bids;
            set
            {
                _bids = new BindingList<BidModel>(value);
                RaisePropertyChanged();
            }
        }

        private RelayCommand _AddBidCommand;
        public RelayCommand AddBidCommand => _AddBidCommand = new RelayCommand(() => AddBid());

        static System.Timers.Timer _timer;
        static System.Timers.Timer _timer2;

        //API
        public DOApiService api { get; set; }

        private IEnumerable<Object> _BidDataSource;
        public IEnumerable<Object> BidDataSource
        {
            get => _BidDataSource;
            set
            {
                _BidDataSource = _bids.Select(bid => new
                {
                    Offer = bid.Offer.name,
                    YouNewBid = bid.YouNewBid,
                    Time = bid.Time,
                    LootId = bid.Offer.lootId
                }).ToList();
                RaisePropertyChanged();
            }
        }

        private void AddBid()
        {
            try
            {
                _bids.Add(new BidModel()
                {
                    Offer = (OfferModel)SelectedItemOffer,
                    YouNewBid = Convert.ToInt64(NewBid),
                    Time = TimeSpan.Parse(Time)
                });

                BidDataSource = Bids;
            }
            catch(Exception e)
            {
                //MessageBox.Show("Only numbers in bid.");
            }
        }

        public void updateOffers()
        {
            //fazer a cada 5 sec
            String request = api.GetAuctionBySID();
            OfferModel SelectedItem = SelectedItemOffer;

            api.offers = HtmlElementService.GetOffers(request);
            SelectedItemOffer = SelectedItem;

            //comparar offers com bids pelo lootid

            api.offers.ForEach(x =>
            {
                var bidList = Bids.ToList().FindAll(b => b.Offer.lootId == x.lootId);

                bidList.ForEach(a =>
                {
                    if (a != null && api.user.name == x.highest && a.YouNewBid <= x.currentBid)
                    {
                        ListColor(Color.Green, a.Offer.lootId, a.YouNewBid.ToString());
                        return;
                    };

                    if (a != null && a.YouNewBid <= x.currentBid)
                    {
                        ListColor(Color.Red, a.Offer.lootId, a.YouNewBid.ToString());
                    };

                    ListColor(Color.Blue, a.Offer.lootId, a.YouNewBid.ToString());
                });
            });
        }

        public void interval()
        {
            _timer2 = new System.Timers.Timer(1000);
            _timer2.Elapsed += new ElapsedEventHandler((s, e) => { CurrentTimeServer = CurrentTimeServer.Subtract(TimeSpan.FromSeconds(1)); });
            _timer2.Elapsed += new ElapsedEventHandler((s, e) => { api.setBid(Bids.ToList().FindAll(bid => bid.Time >= CurrentTimeServer).ToList()); });
            _timer2.Enabled = true;

            _timer = new System.Timers.Timer(3000);
            _timer.Elapsed += new ElapsedEventHandler((s, e) => { updateOffers(); });
            _timer.Enabled = true;
        }

        private void ListColor(Color color, String lootId, String youNewBid)
        {
            var a = DataGridViewCollection.OfType<DataGridViewRow>().ToList().FindAll(x => x.Cells[3].Value.ToString() == lootId).ToList().FindAll(x => x.Cells[1].Value.ToString() == youNewBid);
            if (a != null)
            {
                a.ToList().ForEach(x => x.DefaultCellStyle.BackColor = color);
            }
        }

        public override void OnNavigatedTo(Object nav)
        {
            api = (DOApiService)nav;

            CurrentTimeServer = DOApiService.GetTime(api.GetAuctionBySID());

            interval();
            base.OnNavigatedTo(nav);
        }

        public AuctionViewModel()
        {
            SelectedItemOffer = new OfferModel();
            NewBid = "";
            Time = null;
            BidDataSource = Bids;
        }
    }
}