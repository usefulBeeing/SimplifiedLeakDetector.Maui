namespace SimplifiedLeakDetector;

public partial class DetectorPage : ContentPage
{
    public DetectorPage()
    {
	InitializeComponent();
	
	if (Flags.DoneTesting == false)
	    TestForLeaks();
    }

    async void TestForLeaks()
    {
        if (Flags.DoneTesting == false)
        {
            Flags.DoneTesting = true;

            await Navigation.PushAsync(new DetectorPage()); // Push

            await Task.Delay(TimeSpan.FromSeconds(5));

            await Navigation.PopAsync(); // Pop
        }

        // Give the app enough time to report
        // possible leak results before exiting
        await Task.Delay(TimeSpan.FromSeconds(10));

        System.Environment.Exit(1);
    }
}

public static class Flags
{
    public static bool DoneTesting { get; set; } = false;
}
