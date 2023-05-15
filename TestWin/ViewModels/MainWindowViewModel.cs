namespace TestWin.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() 
        {
            var firstWinwosViewModel = new SmallWindowViewModel();
            var SmallWindow=new SmallWindowViewModel();
            var albumViewModel=new AlbumViewModel();
        }
    }
}