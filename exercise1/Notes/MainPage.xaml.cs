namespace Notes;

public partial class MainPage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");


    public MainPage()
    {
        InitializeComponent();
        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }
    }
    public void OnSaveButtonClicked(object sender, System.EventArgs e)
    {

    }
    public void OnDeleteButtonClicked(object sender, System.EventArgs e)
    {
        editor.Text = "";
;    }
}

