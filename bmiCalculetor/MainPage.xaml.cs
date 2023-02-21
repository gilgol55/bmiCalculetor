using System.ComponentModel;

namespace bmiCalculetor;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        double BMI=WeightStepper.Value/Math.Pow(HeightSlider.Value/100.0,2);
        if (BMI < 18.5) { calculation.Text = $"your bmi is {BMI} you are under weight "; }
        else if (BMI < 25) { calculation.Text = $"your bmi is {BMI} you are fine"; }
        else if (BMI < 30) { calculation.Text = $"your bmi is {BMI} you are over weight "; }
        else if (BMI < 18.5) { calculation.Text = $"your bmi is {BMI} you are extremly over weight "; }
    }
}





