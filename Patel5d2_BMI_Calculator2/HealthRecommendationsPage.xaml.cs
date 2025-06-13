namespace Patel5d2_BMICalculator2;

public partial class HealthRecommendationsPage : ContentPage
{
    public HealthRecommendationsPage(string bmiCategory, string gender)
    {
        InitializeComponent();
        RecommendationLabel.Text = GetRecommendation(bmiCategory, gender);
    }

    private string GetRecommendation(string category, string gender)
    {
        switch (category)
        {
            case "Overweight":
                return gender == "Male"
                    ? "For men, a higher BMI can increase health risks. Focus on a balanced diet rich in protein and vegetables, and incorporate both cardio and strength training."
                    : "For women, managing weight is key for long-term health. Consider a mix of aerobic exercises like brisk walking or cycling, and a diet with controlled portions.";
            case "Normal":
                return gender == "Male"
                    ? "Great job! You are in a healthy weight range for a man. Maintain your status with regular physical activity and a nutritious diet."
                    : "Excellent! You fall within the healthy weight range for a woman. Continue your healthy habits to support your overall well-being.";
            case "Underweight":
                return gender == "Male"
                    ? "Being underweight can be a concern for men. Focus on nutrient-dense foods, increase calorie intake healthily, and consider strength training to build muscle mass."
                    : "For women, being underweight may affect energy levels and health. Ensure you are eating enough calories from healthy sources and consult a healthcare provider if needed.";
            default:
                return "No recommendation available. Please consult a doctor.";
        }
    }

    private async void OnBackToResultsClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnBackToHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}