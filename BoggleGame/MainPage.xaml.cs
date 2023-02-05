using BoggleGame.Game;

namespace BoggleGame;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new GameViewModel();
    }
}

