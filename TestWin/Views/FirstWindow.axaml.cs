using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System;
using System.Threading.Tasks;
using TestWin.ViewModels;

namespace TestWin.Views
{
    public partial class FirstWindow : ReactiveUserControl<FirstWinwosViewModel>
    {
        public FirstWindow()
        {
            InitializeComponent();
            this.WhenActivated(d => d(ViewModel!.ShowDialog.RegisterHandler(DoShowDialogAsync)));
        }
        private async Task DoShowDialogAsync(InteractionContext<SmallWindowViewModel, AlbumViewModel?> interaction)
        {
            //var dialog = new SmallWindowViewModel();
            //dialog.DataContext = interaction.Input;

            //var result = await dialog.ShowDialog<AlbumViewModel?>(this);
            //interaction.SetOutput(result);
        }


    }
}
