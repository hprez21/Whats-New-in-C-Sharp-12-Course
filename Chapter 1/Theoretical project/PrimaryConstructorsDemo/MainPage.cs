public class MainPage(ITranslation translation)
{
    public void Button_Clicked()
    {
        Console.WriteLine(translation.Translate("Hello"));
    }
}