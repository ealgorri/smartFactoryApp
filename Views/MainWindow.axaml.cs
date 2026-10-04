using Avalonia.Controls;
using Avalonia.Interactivity;
using smartFactoryApp.ViewModels;

namespace smartFactoryApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
   
/* Property um aus dem DataContext deiner View den MainViewModel herauszuholen.  
Jede Avalonia‑View hat ein DataContext. Dort steckt typischerweise das ViewModel drin.
-- as MainViewModel  
Der Ausdruck versucht, den DataContext in einen MainViewModel umzuwandeln.
Wenn es klappt → du bekommst ein MainViewModel.
Wenn nicht → du bekommst null (deshalb das ? im Rückgabetyp). */
    private MainViewModel? ViewModel =>
   DataContext as MainViewModel;

private void MoveLeft_Click(object? sender, RoutedEventArgs e)
{
    ViewModel?.MoveLeft();
}

    private void MoveRight_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveRight();
    }   
    
    private void MoveUp_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveUp();
    }

    private void MoveDown_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveDown();
    }
     private void MoveUpRight_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveUpRight();
    }
    private void MoveUpLeft_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveUpLeft();
    }
    private void MoveDownRight_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveDownRight();
    }
    private void MoveDownLeft_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveDownLeft();
    }
    private void MoveRotateRight_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveRotateRight();
    }
    private void MoveRotateLeft_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveRotateLeft();
    }
    private void Stop_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.Stop();
    }
}