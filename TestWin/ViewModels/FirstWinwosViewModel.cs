using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestWin.ViewModels
{
    public class FirstWinwosViewModel:ViewModelBase
    {
        public FirstWinwosViewModel()
        {
            ShowDialog = new Interaction<SmallWindowViewModel, AlbumViewModel?>();

            BuyMusicCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var store = new SmallWindowViewModel();

                var result = await ShowDialog.Handle(store);
            });

        }

        public ICommand BuyMusicCommand { get; }

        public Interaction<SmallWindowViewModel, AlbumViewModel?> ShowDialog { get; }
    }
}
