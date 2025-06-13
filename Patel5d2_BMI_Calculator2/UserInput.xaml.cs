namespace Patel5d2_BMICalculator2;

public partial class UserInputPage : ContentPage
{
    // Fix for CS8625: Made the string nullable as it starts as null.
    private string? _selectedGender;

    public UserInputPage()
    {
        InitializeComponent();
    }

    private void OnGenderSelected(object sender, TappedEventArgs e)
    {
        // Add a null-check for safety
        if (sender is not Border selectedBorder)
        {
            return;
        }

        MaleBorder.Stroke = Colors.Gray;
        FemaleBorder.Stroke = Colors.Gray;

        selectedBorder.Stroke = Colors.CornflowerBlue;

        _selectedGender = selectedBorder == MaleBorder ? "Male" : "Female";
    }

    private void OnHeightSliderChanged(object sender, ValueChangedEventArgs e)
    {
        int height = (int)e.NewValue;
        HeightLabel.Text = $"{height} in";
    }

    private void OnWeightSliderChanged(object sender, ValueChangedEventArgs e)
    {
        int weight = (int)e.NewValue;
        WeightLabel.Text = $"{weight} lbs";
    }

    private async void OnCalculateClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_selectedGender))
        {
            await DisplayAlert("Validation Error", "Please select a gender.", "OK");
            return;
        }

        double height = HeightSlider.Value;
        double weight = WeightSlider.Value;

        await Navigation.PushAsync(new BMIResultPage(weight, height, _selectedGender));
    }
}