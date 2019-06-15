using System;
using System.Threading.Tasks;
using FriendOrganizer.Model;
using FriendOrganizer.UI.Annotations;
using FriendOrganizer.UI.Data;

namespace FriendOrganizer.UI.ViewModel
{
    public class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private readonly IFriendDataService _friendDataService;

        private Friend _friend;

        public FriendDetailViewModel(IFriendDataService friendDataService)
        {
            _friendDataService = friendDataService;
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
