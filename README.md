# What is Simplified Leak Detector?
As the name suggests, it is a simplified Leak detection tool or project built around the [MemoryToolkit.Maui package](https://github.com/AdamEssenmacher/MemoryToolkit.Maui).

# How to test a component for possible leaks?
- Add a component to the Detector XAML Page.
- Start the app in debugging mode.
- Navigate to Detector Page to start testing for leaks!
- Wait until the page refreshes itself.
- Keep your eye on the Output window.
- The leak report will be released.
- The app will shutdown automatically within seconds.
# What is a component?
A component is any element or control or package that can fit in a XAML page.

For example, 
- Maui native elements like Grid, Button, Image, CollectionView, DatePicker ...etc
- Elements of Libraries like [MAUI Community Toolkit](https://github.com/CommunityToolkit/Maui).
- Any third-party UI kit.
# What makes this tool simplified?
Because all you have to do is add a XAML component, fire the app, and sit back and watch :)
# How reliable is this tool?
This is an experimental project built around another toolkit; therefore, it comes with ZERO promises.
# How can I help?
Please feel free to fork in and add value to this project.

A value could mean code, a suggestion, or even an honest opinion about the reliability of this project.
# Screenshots:

<img width="297" alt="_homepage" src="https://github.com/user-attachments/assets/5fef1816-9645-4120-8608-30faa43be494">

    Success story :)

<img width="548" alt="_GCsuccess" src="https://github.com/user-attachments/assets/da692ead-7941-42e4-9822-bab269176944">

    Leak detected :(

<img width="459" alt="_leakDetected" src="https://github.com/user-attachments/assets/769ee003-6037-46b8-8080-2d69ccde8bca">

    Comparing 3rd party Calendar controls for possible leaks.
    
    In the following report, syncfusion Calendar control leaks badly!
<img width="575" alt="_calendarControls" src="https://github.com/user-attachments/assets/fa7e8dd0-14ed-4138-8518-49376c172b24">
<img width="586" alt="_calendarControlsLeakTestResult" src="https://github.com/user-attachments/assets/478c4cd9-5b73-426d-a328-fc41a3ff17c9">

   

