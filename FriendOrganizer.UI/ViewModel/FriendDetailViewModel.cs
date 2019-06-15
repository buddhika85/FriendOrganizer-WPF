using System;
using System.Threading.Tasks;
using FriendOrganizer.Model;
using FriendOrganizer.UI.Annotations;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Event;
using Prism.Events;

namespace FriendOrganizer.UI.ViewModel
{
    public class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private IFriendDataService _friendDataService;
        private IEventAggregator _eventAggregator;

        private Friend _friend;

        public FriendDetailViewModel(IFriendDataService friendDataService, IEventAggregator eventAggregator)
        {
            _friendDataService = friendDataService;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenFriendDetailViewEvent>().Subscribe(OnOpenFriendDetailView);
        }

        private async void OnOpenFriendDetailView(int friendId)
        {
            await LoadAsync(friendId);
        }

        public async Task LoadAsync(int friendId)
        {
            Friend = await _friendDataService.GetFriendByIdAsync(friendId);
        }

        public Friend Friend
        {
            get => _friend;
            set
            {
                if (value != null)
                {
                    _friend = value;
                    OnPropertyChanged();
                } 
            }
        }
    }
}
