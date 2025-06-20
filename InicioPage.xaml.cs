namespace GeekHubApp;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();
        StartAnimations();
    }

    private async void StartAnimations()
    {
        MainLayout.Opacity = 0;
        MainLayout.TranslationY = 40;

        await Task.Delay(200);
        await Task.WhenAll(
            MainLayout.FadeTo(1, 1000, Easing.CubicInOut),
            MainLayout.TranslateTo(0, 0, 1000, Easing.CubicOut)
        );
    }

    private async void OnSeriesClicked(object sender, EventArgs e)
    {
        await btnSeries.ScaleTo(0.9, 100);
        await btnSeries.ScaleTo(1, 100);
        await DisplayAlert("Series", "Explora las mejores series geek", "OK");
    }

    private async void OnJuegosClicked(object sender, EventArgs e)
    {
        await btnJuegos.ScaleTo(0.9, 100);
        await btnJuegos.ScaleTo(1, 100);
        await DisplayAlert("Juegos", "Descubre los mejores juegos", "OK");
    }

    private async void GoToDragonBall(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("dragonball");
    }

    private async void GoToNaruto(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("naruto");
    }

    private async void GoToStrangerThings(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("strangerthings");
    }

    private async void GoToMario(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("mario");
    }
}
