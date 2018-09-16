using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DO_Login.Models
{
    public class BidModel : INotifyPropertyChanged
    {
        private OfferModel _offer { get; set; }
        public OfferModel Offer
        {
            get { return _offer; }
            set
            {
                _offer = value;
                OnPropertyChanged("Offer");
            }
        }

        private long _youNewBid { get; set; }
        public long YouNewBid
        {
            get { return _youNewBid; }
            set
            {
                _youNewBid = value;
                OnPropertyChanged("YouNewBid");
            }
        }

        private TimeSpan _time { get; set; }
        public TimeSpan Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged("Time");
            }
        }

        private bool _isRunning { get; set; }
        public bool isRunning
        {
            get { return _isRunning; }
            set
            {
                _isRunning = value;
                OnPropertyChanged("isRunning");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
