namespace Patel5d2_BMICalculator2;

public partial class BMIResultPage : ContentPage
{
    private readonly string _bmiCategory;
    private readonly string _gender;

    public BMIResultPage(double weight, double height, string gender)
    {
        InitializeComponent();

        // Assign the gender field immediately
        _gender = gender;

        // Handle invalid input case
        if (height <= 0)
        {
            // Assign default values to satisfy the compiler and inform the user
            _bmiCategory = "Invalid Input";
            BmiValueLabel.Text = "---";
            CategoryLabel.Text = _bmiCategory;
            SetCategoryColor(_bmiCategory);
            return; // Exit constructor
        }

        // Perform calculation and assign the category field
        double bmi = (weight / (height * height)) * 703;
        _bmiCategory = GetBmiCategory(bmi, gender);

        // Update the UI
        BmiValueLabel.Text = bmi.ToString("F1");
        CategoryLabel.Text = _bmiCategory;
        SetCategoryColor(_bmiCategory);
    }

    private string GetBmiCategory(double bmi, string gender)
    {
        if (gender == "Male")
        {
            if (bmi >= 25) return "Overweight";
            if (bmi > 18.5) return "Normal";
            return "Underweight";
        }
        else // Female
        {
            if (bmi >= 24) return "Overweight";
            if (bmi > 18) return "Normal";
            return "Underweight";
        }
    }

    private void SetCategoryColor(string category)
    {
        switch (category)
        {
            case "Overweight":
                CategoryLabel.TextColor = Colors.OrangeRed;
                break;
            case "Normal":
                CategoryLabel.TextColor = Colors.Green;
                break;
            case "Underweight":
                CategoryLabel.TextColor = Colors.LightBlue;
                break;
            default:
                CategoryLabel.TextColor = Colors.Gray;
                break;
        }
    }

    private async void OnViewRecommendationsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HealthRecommendationsPage(_bmiCategory, _gender));
    }

    private async void OnRecalculateClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}